using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SoftSong.Interfaces
{
    public partial class Carrinho : UserControl
    {
        public static ArrayList carrineo = new ArrayList();
        public static ArrayList unidades = new ArrayList();
        public Carrinho()
        {
            InitializeComponent();
            Carregar_Carrinho();
            if (carrineo.Count == 0)
                btn_Final.Enabled = false;
        }
        public String a;
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        DataSet dss = new DataSet();

        public void Carregar_Carrinho()
        {
            a = "";
            double val = 0;
            for (int i = 0; i < carrineo.Count; i++)
                a += "'" + carrineo[i].ToString() + "',";
            if (a.Length > 0)
                a = a.Remove(a.Length - 1);
            ds = new DataSet();
            dss = new DataSet();
            String x = "Select nome,IDProduto,descricao,preco_unitario,caminho_imagem Quantidade from tblProduto where IDProduto in (" + a + ")";
            try
            {
                ds = conexao.Executa_sql(x);
            }
            catch { }
            if (ds != null)
                bunifuCustomDataGrid1.DataSource = ds.Tables[0].DefaultView;
            else
                bunifuCustomDataGrid1.DataSource = null;
            for (int i = 0; i < carrineo.Count; i++)
            {
                dss = conexao.Executa_sql("Select desconto from tblPromocao where ID_Produto = " + (Convert.ToInt32(bunifuCustomDataGrid1["IDProduto", i].Value)));
                if (dss.Tables[0].Rows.Count > 0)
                {
                    x = conexao.executeQueryComStringRetorno("Select desconto from tblPromocao where ID_Produto = " + (Convert.ToInt32(bunifuCustomDataGrid1["IDProduto", i].Value)));
                    ((bunifuCustomDataGrid1["preco_unitario", i].Value)) = x;
                }
                ((bunifuCustomDataGrid1["Quantidade", i].Value)) = (Convert.ToInt32(unidades[i].ToString())).ToString();
                val += (Convert.ToInt32(unidades[i].ToString()) * (Convert.ToDouble(bunifuCustomDataGrid1["preco_unitario", i].Value)));

            }
            txt_Preco.Text = "R$" + val.ToString();
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo = (Convert.ToInt32(bunifuCustomDataGrid1["IDProduto", e.RowIndex].Value)).ToString();
            carrineo.RemoveAt(carrineo.IndexOf(codigo));
            Carregar_Carrinho();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            carrineo.Clear();
            Carregar_Carrinho();
        }

        private void btn_Final_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Confirmar_Compra";
        }
    }
}
