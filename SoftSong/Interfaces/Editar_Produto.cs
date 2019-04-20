using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SoftSong.Popups;

namespace SoftSong.Interfaces
{
    public partial class Editar_Produto : UserControl
    {
        public Editar_Produto()
        {
            InitializeComponent();
            Preencher();
            Edicao(this.Controls);
        }
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        public static String Caminho_Antigo;
        public static String Destino;

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            
                DialogResult fi = MessageBox.Show("Voce tem certeza que deseja atualizar esse Produto?", "Atualizaçãõ", MessageBoxButtons.YesNo);
                if (fi.Equals(DialogResult.Yes))
                {
                    try
                    {
                        conexao = new ClasseConexao();
                        ds = new DataSet();
                        if (Destino == null)
                            Destino = Caminho_Antigo;
                        string cc = conexao.executeQueryComStringRetorno("Select IDCategoria from tblCategoria where nome = '" + cxc_Trans.selectedValue.ToString() + "'");
                        string ff = conexao.executeQueryComStringRetorno("Select IDFornecedor from tblFornecedor where nome = '" + cxc_Forn.selectedValue.ToString() + "'");
                        txt_Preco.Text = txt_Preco.Text.Replace(',', '.');
                        String f = "Update tblProduto set nome='" + txt_Produto.Text + "', descricao='" + txt_Descricao.Text + "', preco_unitario='" + txt_Preco.Text + "', ID_Fornecedor=" + ff + ", ID_Categoria=" + cc + ", caminho_imagem='" + Destino + "' Where IDProduto=" + Popup.id;
                        ds = conexao.Executa_sql(f);
                        MessageBox.Show("Alteraçoes Feitas com Sucesso");
                        Form1.by = true;
                        Form1.pass = "Home";
                }
                    catch
                    {
                        DialogResult d = MessageBox.Show("Ocorreu um problema ao conectar com o banco, reiniciar a aplicaçao?", "Erro 234", MessageBoxButtons.YesNo);
                        if (d.Equals(DialogResult.Yes)) Application.Restart();
                        else Application.Exit();
                    }
                }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!openFileDialog1.FileName.Contains("openFileDialog1"))
            {
                pictureBox4.Load(openFileDialog1.FileName);
                String Caminho = openFileDialog1.FileName.ToString();
                String Nome = Path.GetFileName(openFileDialog1.ToString());
                Destino = System.IO.Path.Combine(@"C:\Users\Public\Documents\Fotos_Sistema", Nome);
                if (!Directory.Exists(@"C:\Users\Public\Documents\Fotos_Sistema"))
                {
                    Directory.CreateDirectory(@"C:\Users\Public\Documents\Fotos_Sistema");
                }
                System.IO.File.Copy(Caminho, Destino, true);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            DialogResult fi = MessageBox.Show("Voce tem certeza que deseja excluir esse Cadastro?", "Excluir", MessageBoxButtons.YesNo);
            if (fi.Equals(DialogResult.Yes))
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    String f = "Delete From tblProduto Where IDProduto='" + Popup.id + "'";
                    ds = conexao.Executa_sql(f);
                    MessageBox.Show("Produto excluido com Sucesso");
                    Form1.by = true;
                    Form1.pass = "Home";
                }
                catch
                {
                    DialogResult d = MessageBox.Show("Ocorreu um problema ao conectar com o banco, reiniciar a aplicaçao?", "Erro 234", MessageBoxButtons.YesNo);
                    if (d.Equals(DialogResult.Yes)) Application.Restart();
                    else Application.Exit();
                }
            }
        }

        public void Edicao(Control.ControlCollection controles)
        {
            int i = 0;
            String a = "Select preco_unitario,nome,descricao,ID_Categoria,ID_Fornecedor,caminho_imagem from tblProduto where IDProduto='" + Popup.id + "'";
            String[] ed = conexao.Retorna_Array(a);
            txt_Produto.Text = ed[1];
            txt_Preco.Text = ed[0];
            String[] x = txt_Preco.Text.Split(',');
            x[1] = x[1].Remove(x[1].Length - 2);
            txt_Preco.Text = x[0] + "," + x[1]; 
            txt_Descricao.Text = ed[2]; 
            Caminho_Antigo = ed[5];
            pictureBox4.Load(ed[5]);
            cxc_Forn.selectedIndex = Convert.ToInt32(ed[4]) - 1;
            cxc_Trans.selectedIndex = Convert.ToInt32(ed[3]) - 1;
        }

        String forn = "";
        String cat = "";
        private void Preencher()
        {

            int c = 0;
            int d = 0;
            while (true)
            {
                c++;
                try
                {
                    String a = conexao.executeQueryComStringRetorno("Select nome from tblFornecedor where IDFornecedor = " + c);
                    forn += a + ";";
                }
                catch
                { break; }
            }
            while (true)
            {
                d++;
                try
                {
                    String a = conexao.executeQueryComStringRetorno("Select nome from tblCategoria where IDCategoria = " + d);
                    cat += a + ";";
                }
                catch
                { break; }
            }
            cat = cat.Remove(cat.Length - 1);
            forn = forn.Remove(forn.Length - 1);
            String[] cat1 = cat.Split(';');
            String[] forn1 = forn.Split(';');
            for (int i = 0; i < (forn1.Length + cat1.Length); i++)
            {
                if (i < forn1.Length)
                    cxc_Forn.AddItem(forn1[i].ToString());
                if (i < cat1.Length)
                    cxc_Trans.AddItem(cat1[i].ToString());
            }
        }
    }
}
