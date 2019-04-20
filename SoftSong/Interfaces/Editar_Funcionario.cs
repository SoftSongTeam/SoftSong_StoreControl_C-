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
    public partial class Editar_Funcionario : UserControl
    {
        public Editar_Funcionario()
        {
            InitializeComponent();
            Edicao(this.Controls);
            Caminho_Antigo = conexao.executeQueryComStringRetorno("select caminho_imagem from tblFuncionario where CPF='" + Popup.id + "'");
            if (txt_CPF.Text.Length == 10)
                txt_CPF.Text = "0" + txt_CPF.Text;
        }
        ClasseConexao conexao = new ClasseConexao();
        public static String Caminho_Antigo;
        public static String Destino;
        DataSet ds = new DataSet();

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            String sex;
            if (cxc_Sexo.selectedIndex.ToString() == "3")
                sex = "9";
            else
                sex = cxc_Sexo.selectedIndex.ToString();
            {
                DialogResult fi = MessageBox.Show("Voce tem certeza que deseja atualizar suas informaçoes?", "Atualizaçãõ", MessageBoxButtons.YesNo);
                if (fi.Equals(DialogResult.Yes))
                {
                    try
                    {
                        conexao = new ClasseConexao();
                        ds = new DataSet();
                        if (Destino == null)
                            Destino = Caminho_Antigo;
                        String f = "Update tblFuncionario set nome='" + txt_Nome.Text + "', email='" + txt_Email.Text + "', CPF='" + txt_CPF.Text + "', genero='" + sex + "', senha='" + txt_Senha.Text + "', caminho_imagem='" + Destino + "' Where CPF=" + Popup.id;
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
                    String Nome = "funcionario" + (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tblFuncionario")) + 1).ToString() + ".jpg";
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
                    string n = (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tblFuncionario")) + 1).ToString();
                    i.Save(@"C:\Users\Public\Documents\Fotos_Sistema\funcionario" + n + ".jpg");
                    Destino = @"C:\Users\Public\Documents\Fotos_Sistema\funcionario" + n + ".jpg";
                    pictureBox4.Load(Destino);
                }
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
                    String f = "Delete From tblFuncionario Where CPF='" + Popup.id + "'";
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
            if (Popup.id.Length == 10)
                Popup.id = "0" + Popup.id;
            int i = 4;
            String a = "Select CPF,email,nome,tel1,senha,genero,caminho_imagem from tblFuncionario where CPF='" + Popup.id + "'";
            String[] ed = conexao.Retorna_Array(a);
            foreach (Control ctrl in controles)
            {
                if (ctrl is Bunifu.Framework.UI.BunifuMetroTextbox)
                {
                    ctrl.Text = ed[i].ToString();
                    i--;
                }
                else if (ctrl is Bunifu.Framework.UI.BunifuDropdown)
                {
                    try
                    {
                        cxc_Sexo.selectedIndex = Convert.ToInt32(ed[5]);
                    }
                    catch { cxc_Sexo.selectedIndex = 3; }
                }
                else if (ctrl is PictureBox)
                    pictureBox4.Load(ed[6].ToString());
            }

        }
    }
    }
