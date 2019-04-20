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
    public partial class Visualizar_Produto : UserControl
    {
        public Visualizar_Produto()
        {
            InitializeComponent();
            txt_Nome.MaximumSize = new Size(170, 0);
            txt_Nome.AutoSize = true;
            txt_Descricao.MaximumSize = new Size(335, 0);
            txt_Descricao.AutoSize = true;
            promo = conexao.Executa_sql("Select ID_Produto from tblPromocao where ID_Produto = " + Home.idProduto);
            txt_Nome.Text = conexao.executeQueryComStringRetorno("select nome from tblProduto where IDProduto=" + Home.idProduto);
            txt_Descricao.Text = conexao.executeQueryComStringRetorno("select descricao from tblProduto where IDProduto=" + Home.idProduto);
            pictureBox4.Load(conexao.executeQueryComStringRetorno("select caminho_imagem from tblProduto where IDProduto=" + Home.idProduto));
            if (promo.Tables[0].Rows.Count > 0)
            {
                txt_Preco.Text = "R$" + conexao.executeQueryComStringRetorno("Select desconto from tblPromocao where ID_Produto = " + Home.idProduto);
                preço_antigo.Text = "R$" + conexao.executeQueryComStringRetorno("select preco_unitario from tblProduto where IDProduto=" + Home.idProduto);
                preço_antigo.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Strikeout);
                String[] y = preço_antigo.Text.Split(',');
                y[1] = y[1].Remove(y[1].Length - 2);
                preço_antigo.Text = y[0] + "," + y[1];
            }
            else
            {
                txt_Preco.Text = "R$" + conexao.executeQueryComStringRetorno("select preco_unitario from tblProduto where IDProduto=" + Home.idProduto);
                preço_antigo.Visible = false;
            }
            String[] x = txt_Preco.Text.Split(',');
            x[1] = x[1].Remove(x[1].Length - 2);
            txt_Preco.Text = x[0] + "," + x[1];
        }
        public static DataSet promo = new DataSet();
        ClasseConexao conexao = new ClasseConexao();

        private void btn_Carrinho_Click(object sender, EventArgs e)
        {
            Carrinho.carrineo.Add(Home.idProduto);
            Carrinho.unidades.Add(txt_Unidade.Text);
            MessageBox.Show("Produto adicionado com sucesso!");
            Form1.by = true;
            Form1.pass = "Home";
        }
    }
}
