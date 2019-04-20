using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSong.Interfaces
{
    public partial class Confirmar_Compra : UserControl
    {
        public String idCliente;
        public String trans;
        public Confirmar_Compra()
        {
            InitializeComponent();
            int c = 0;
            while (true)
            {
                c++;
                try
                {
                    String a = conexao.executeQueryComStringRetorno("Select nome from tblTransportadora where IDTransportadora = " + c);
                    trans += a + ";";
                }
                catch
                { break; }
            }
            try
            {
                trans = trans.Remove(trans.Length - 1);
                String[] trans1 = trans.Split(';');
                for (int i = 0; i < trans1.Length; i++)
                {
                    cxc_Trans.AddItem(trans1[i].ToString());
                }
                cxc_Trans.AddItem("Retirada Local");
            }
            catch
            {
                label10.Text = "Apenas retirada local disponivel";
                cxc_Trans.Visible = false;
            }
            x = conexao.executeQueryComStringRetorno("Select count(*) from tblTransportadora");
        }
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        String x;

        private void txt_Pesquisar_OnTextChange(object sender, EventArgs e)
        {
            ds = new DataSet();
            String a = "select IDCliente, nome, email, CPF from tblCliente where nome like '%" + txt_Pesquisar.text + "%'";
            //MessageBox.Show(a);
            ds = conexao.Executa_sql(a);
            if (ds != null)
                bunifuCustomDataGrid1.DataSource = ds.Tables[0].DefaultView;
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = (Convert.ToInt64(bunifuCustomDataGrid1["IDCliente", e.RowIndex].Value)).ToString();
            MessageBox.Show("Usuario Selecionado:" + ((bunifuCustomDataGrid1["nome", e.RowIndex].Value)).ToString());
        }
        String idT;

        private void btn_Final_Click(object sender, EventArgs e)
        {
            try
            {
                if (x != "0")
                    idT = conexao.executeQueryComStringRetorno("Select IDTransportadora from tblTransportadora where nome ='" + cxc_Trans.selectedValue.ToString() + "'");
                String idF = conexao.executeQueryComStringRetorno("Select IDFuncionario from tblFuncionario where nome = '" + Login.usu + "'");
                if (cxc_Trans.Visible == true)
                {
                    if (cxc_Trans.selectedValue.ToString() == "Retirada Local")
                        conexao.Executa_sql("Insert into tblPedido(ID_Funcionario, ID_Cliente) values (" + idF + "," + idCliente + ")");
                }
                else if (label10.Text == "Apenas retirada local disponivel")
                    conexao.Executa_sql("Insert into tblPedido(ID_Funcionario, ID_Cliente) values (" + idF + "," + idCliente + ")");
                else
                    conexao.Executa_sql("Insert into tblPedido values (" + idT + "," + idF + "," + idCliente + ")");
                for (int i = 0; i < Carrinho.carrineo.Count; i++)
                {
                    String y = conexao.executeQueryComStringRetorno("Select Count(*) from tblPedido");
                    conexao.Executa_sql("Insert into tblDetalhePedido values(" + Carrinho.carrineo[i] + "," + y + ")");

                }
                MessageBox.Show("Compra realizada com sucesso");
            }
            catch { MessageBox.Show("Ocorreu um erro ao efetuar a compra"); }
        }
    }
}
