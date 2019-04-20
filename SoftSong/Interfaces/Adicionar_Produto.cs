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

namespace SoftSong.Interfaces
{
    public partial class Adicionar_Produto : UserControl
    {
        public Adicionar_Produto()
        {
            InitializeComponent();
            //Chama funçao preencher.
            Preencher();
        }
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        public static String Destino;

        //Essa funçao, ao clicar no pictureBox, abre uma caixa do explorer para carregar uma imagem e pegar o caminho dele pra colocar no banco
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //abre o Explorador de arquivos
            openFileDialog1.ShowDialog();
            //Carrega a imagem
            pictureBox4.Load(openFileDialog1.FileName);
            //coloca o caminho da imagem numa String
            String Caminho = openFileDialog1.FileName.ToString();
            //pega o nome da imagem
            String Nome = Path.GetFileName(openFileDialog1.ToString());
            //Combina caminho da imagem ao nome dela
            Destino = System.IO.Path.Combine(@"C:\Users\Public\Documents\Fotos_Sistema", Nome);
            //checa se o diretorio do aplicativo existe, se nao existir, ele cria a pasta Fotos_Sistema 
            if (!Directory.Exists(@"C:\Users\Public\Documents\Fotos_Sistema"))
            {
                Directory.CreateDirectory(@"C:\Users\Public\Documents\Fotos_Sistema");
            }
            //Coloca a imagem na pasta Fotos_Sistema
            System.IO.File.Copy(Caminho, Destino, true);
        }
        ClasseValida valida = new ClasseValida();
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new ClasseConexao();
                ds = new DataSet();
                //Insere o produto no banco
                string cc = conexao.executeQueryComStringRetorno("Select IDCategoria from tblCategoria where nome = '" + cxc_Trans.selectedValue.ToString() + "'");
                string ff = conexao.executeQueryComStringRetorno("Select IDFornecedor from tblFornecedor where nome = '" + cxc_Forn.selectedValue.ToString() + "'");
                String f = "INSERT INTO tblProduto VALUES (" + ff + "," + cc + ",'" + txt_Produto.Text + "', " + txt_Preco.Text + ", '" + txt_Descricao.Text + "', '" + Destino + "')";
                ds = conexao.Executa_sql(f);
                //ds = conexao.executa_sql("Insert Into Fisica values('1211','a','aa','aa','a','aa','aa','aa','a')");
                MessageBox.Show("Produto Cadastrado com sucesso.");
                //Limpa todos os controles do Form para cadastro de um novo produto
                valida.Limpar(this.Controls);
                txt_Descricao.Text = "";
            }
            catch
            {
                DialogResult d = MessageBox.Show("Ocorreu um problema ao conectar com o banco, reiniciar a aplicaçao?", "Erro 234", MessageBoxButtons.YesNo);
                if (d.Equals(DialogResult.Yes)) Application.Restart();
                else Application.Exit();
            }
        }

        String forn = "";
        String cat = "";
        //Funçao que preenche os drop_downs do form(Categoria e fornecedores) com dados do banco, para serem usados na hora do cadastro
        private void Preencher()
        {

            int c = 0;
            int d = 0;
            while (true)
            {
                c++;
                try
                {
                    //Procura Fornecedora com id = c, quando nao houverem mais registros, ele cai no catch e da break; nessa funçao, parando ela;
                    String a = conexao.executeQueryComStringRetorno("Select nome from tblFornecedor where IDFornecedor = " + c);
                    forn += a + ";";
                }
                catch
                {if (c == 1)
                    {
                        MessageBox.Show("Nao existem fornecedores cadastrados"); Form1.by = true;
                        Form1.pass = "Home";
                    } break;}
            }
            while (true)
            {
                d++;
                try
                {
                    //Procura Fornecedora com id = c, adicionando ela a um array, quando nao houverem mais registros, ele cai no catch e da break nessa funçao, parando ela;
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
