using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftSong.Classes;

namespace SoftSong.Interfaces
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            if (Carrinho.carrineo.Count == 1)
                lbl_Items.Text = Carrinho.carrineo.Count.ToString() + " Item";
            else
                lbl_Items.Text = Carrinho.carrineo.Count.ToString() + " Itens";
            dataGridView1.ForeColor = Color.Black;
        }
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        public static String idProduto;

        private void txt_Pesquisar_OnTextChange(object sender, EventArgs e)
        {
            ds = new DataSet();
            String a = "select nome, descricao,preco_unitario,IDProduto from tblProduto where nome like '%" + txt_Pesquisar.text + "%'";
            //MessageBox.Show(a);
            ds = conexao.Executa_sql(a);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void btn_Logoff_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Carrinho";
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduto = (Convert.ToInt32(dataGridView1["IDProduto", e.RowIndex].Value)).ToString();
            Form1.by = true;
            Form1.pass = "Visualizar_Produto";
        }
    }
}
