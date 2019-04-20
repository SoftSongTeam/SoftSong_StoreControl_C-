using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftSong.Interfaces;

namespace SoftSong.Popups
{
    public partial class Popup : UserControl
    { 
        public Popup()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
            if (MenuControl.sql == "deletePromo")
            {
                txt_Pesquisar.text = "Clique em uma promoçao para deleta-la";
                txt_Pesquisar.Enabled = false;
                ds = conexao.Executa_sql("select * from tblPromocao");
                if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
        DataSet ds = new DataSet();
        ClasseConexao conexao = new ClasseConexao();
        String a;

        private void txt_Pesquisar_OnTextChange(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (MenuControl.sql == "Funcionario")
                a = "select 'Funcionario' as NomeTabela,nome, email,IDFuncionario IDs,nivel_acesso,CPF from tblFuncionario where nome like '%" + txt_Pesquisar.text + "%'";
            else if (MenuControl.sql == "Cliente")
                a = "select 'Cliente' as NomeTabela,nome, email, IDCliente, nivel_acesso,CPF from tblCliente where nome like '%" + txt_Pesquisar.text + "%'";
            else if (MenuControl.sql == "Transportadora")
                a = "select 'Transportadora' as NomeTabela,nome, email,IDTransportadora IDs,CNPJ from tblTransportadora where nome like '%" + txt_Pesquisar.text + "%'";
            else if (MenuControl.sql == "Fornecedor")
                a = "select 'Fornecedor' as NomeTabela,nome, email, IDFornecedor,CNPJ from tblFornecedor where nome like '%" + txt_Pesquisar.text + "%'";
            else if (MenuControl.sql == "Produto")
                a = "select nome, descricao,preco_unitario,IDProduto from tblProduto where nome like '%" + txt_Pesquisar.text + "%'";
            else if (MenuControl.sql == "Promo")
                a = "select nome, descricao,preco_unitario,IDProduto from tblProduto";
            ds = conexao.Executa_sql(a);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public static String id;
        public static string x;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (MenuControl.sql == "Funcionario")
                    id = (Convert.ToInt64(dataGridView1["CPF", e.RowIndex].Value)).ToString();
                else if (MenuControl.sql == "Cliente")
                    id = (Convert.ToInt64(dataGridView1["CPF", e.RowIndex].Value)).ToString();
                else if (MenuControl.sql == "Transportadora")
                {
                    id = (Convert.ToInt64(dataGridView1["CNPJ", e.RowIndex].Value)).ToString();
                    MenuControl.sql = "Fornecedor_Transportadora";
                    x = "Transportadora";
                }
                else if (MenuControl.sql == "Fornecedor")
                {
                    id = (Convert.ToInt64(dataGridView1["CNPJ", e.RowIndex].Value)).ToString();
                    MenuControl.sql = "Fornecedor_Transportadora";
                    x = "Fornecedor";
                }
                else if (MenuControl.sql == "Produto")
                    id = (Convert.ToInt32(dataGridView1["IDProduto", e.RowIndex].Value)).ToString();
                else if (MenuControl.sql == "Promo")
                    id = (Convert.ToInt32(dataGridView1["IDProduto", e.RowIndex].Value)).ToString();
                if (MenuControl.sql != "Promo")
                {
                    Form1.pass = "Editar_" + MenuControl.sql;
                    if (MenuControl.sql == "deletePromo")
                    {
                        DialogResult fi = MessageBox.Show("Voce tem certeza que deseja excluir essa promoçao?", "Excluir", MessageBoxButtons.YesNo);
                        if (fi.Equals(DialogResult.Yes))
                        {
                            conexao.Executa_sql("Delete from tblPromocao where ID_Produto = " + (dataGridView1["ID_Produto", e.RowIndex].Value).ToString());
                            String a = "select tblProduto.nome, tblPromocao.desconto,tblProduto.IDProduto, tblPromocao.data_fim from tblProduto inner join tblPromocao on tblProduto.IDProduto = tblPromocao.ID_Produto";
                            ds = conexao.Executa_sql(a);
                            if (ds != null)
                                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        }
                        Form1.pass = "Home";
                    }
                }
                else
                    Form1.pass = "Cadastrar_Promocao";
                Form1.by = true;
            }
            catch
            { MessageBox.Show("Campo Vazio"); }
        }
    }
}
