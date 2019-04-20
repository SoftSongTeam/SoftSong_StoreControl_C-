using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftSong.Popups;
using System.IO;
using DevExpress.XtraEditors.Camera;

namespace SoftSong.Interfaces
{
    public partial class Editar_Fornecedor_Transportadora : UserControl
    {
        public Editar_Fornecedor_Transportadora()
        {
            InitializeComponent();
            Edicao(this.Controls);
        }
        ClasseConexao conexao = new ClasseConexao();
        public static String Caminho_Antigo;
        public static String Destino;
        DataSet ds = new DataSet();

        String a;
        String[] ed;
        public void Edicao(Control.ControlCollection controles)
        {
            if (Popup.x == "Transportadora")
            {
                a = "Select nome,email,CNPJ,tel1,endereco,cidade,CEP,estado,caminho_imagem from tblTransportadora where CNPJ='" + Popup.id + "'";
                Caminho_Antigo = conexao.executeQueryComStringRetorno("select caminho_imagem from tblTransportadora where CNPJ='" + Popup.id + "'");
            }
            else if (Popup.x == "Fornecedor")
            {
                a = "Select nome,email,CNPJ,tel1,endereco,cidade,CEP,estado,caminho_imagem from tblFornecedor where CNPJ='" + Popup.id + "'";
                Caminho_Antigo = conexao.executeQueryComStringRetorno("select caminho_imagem from tblFornecedor where CNPJ='" + Popup.id + "'");
            }
            ed = conexao.Retorna_Array(a);
            txt_Nome.Text = ed[0];
            txt_Email.Text = ed[1];
            txt_CNPJ.Text = ed[2];
            txt_Tel.Text = ed[3];
            txt_Endereco.Text = ed[4];
            txt_Cidade.Text = ed[5];
            txt_CEP.Text = ed[6];
            cxc_UF.selectedIndex = Convert.ToInt32(ed[7]);
            pictureBox4.Load(ed[8]);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult fi = MessageBox.Show("Voce tem certeza que deseja atualizar essas informaçoes?", "Atualizaçãõ", MessageBoxButtons.YesNo);
            if (fi.Equals(DialogResult.Yes))
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    if (Destino == null)
                        Destino = Caminho_Antigo;
                    String f = "Update tbl" + Popup.x + " set nome='" + txt_Nome.Text + "', email='" + txt_Email.Text + "', CNPJ='" + txt_CNPJ.Text + "', tel1='" + txt_Tel.Text + "', endereco='" + txt_Endereco.Text + "', cidade='" + txt_Cidade.Text + "', CEP='" + txt_CEP.Text + "', estado='" + cxc_UF.selectedIndex.ToString() + "' Where CNPJ=" + Popup.id;
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

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            DialogResult fi = MessageBox.Show("Voce tem certeza que deseja excluir esse Cadastro?", "Excluir", MessageBoxButtons.YesNo);
            if (fi.Equals(DialogResult.Yes))
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    String f = "Delete From tblProduto Where ID" + Popup.x + "=" + Popup.id;
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


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Tirar uma foto agora ou selecionar dos arquivos?(Sim para foto, Não para arquivos)", "Tirar foto", MessageBoxButtons.YesNo);
            if (d.Equals(DialogResult.No))
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "openFileDialog1")
                {
                    pictureBox4.Load(openFileDialog1.FileName);
                    String Caminho = openFileDialog1.FileName.ToString();
                    String Nome = "funcionario" + (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tbl" + Popup.x)) + 1).ToString() + ".jpg";
                    Destino = System.IO.Path.Combine(@"C:\Users\Public\Documents\Fotos_Sistema", Nome);
                    if (!Directory.Exists(@"C:\Users\Public\Documents\Fotos_Sistema"))
                    {
                        Directory.CreateDirectory(@"C:\Users\Public\Documents\Fotos_Sistema");
                    }
                    System.IO.File.Copy(Caminho, Destino, true);
                }
            }
            else if (d.Equals(DialogResult.Yes))
            {
                TakePictureDialog g = new TakePictureDialog();
                if (g.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image i = g.Image;
                    string n = (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tbl" + Popup.x)) + 1).ToString();
                    i.Save(@"C:\Users\Public\Documents\Fotos_Sistema\" + Popup.x + n + ".jpg");
                    Destino = @"C:\Users\Public\Documents\Fotos_Sistema\funcionario" + Popup.x + n + ".jpg";
                    pictureBox4.Load(Destino);
                }
            }
        }
        }
    }

