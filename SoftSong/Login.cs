using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Mexe o mouse na posiçao x ou y
            this.MouseDown += new MouseEventHandler(Form3_MouseDown);
            this.MouseMove += new MouseEventHandler(Form3_MouseMove);
            //Aplica Bordas arredondadas ao formulario
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
            
        }
        Form1 home = new Form1();
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        int X = 0;
        int Y = 0;
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
            Form1 home = new Form1();
        }
        public static String usu;
        public static String Nivel;
        public static String Imagem;

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Fecha o formulario
            this.Close();
        }

        //Se enter for pressionado essa funçao é chamada pra fazer o login
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Login_Click_1(sender, e);
            }
        }
        //Foca numa texbox oculta pra salvar a senha
        private void txt_Senha_KeyUp(object sender, EventArgs e)
        {
            txt_Copia.Focus();
        }
        //Foca numa texbox oculta pra salvar a senha
        private void txt_Senha_MouseHover(object sender, EventArgs e)
        {
            txt_Copia.Focus();
        }
        //Foca numa texbox oculta pra salvar a senha
        private void txt_Senha_MouseEnter(object sender, EventArgs e)
        {
            txt_Copia.Focus();
        }
        //Coloca * no lugar de cada letra para ocultar senha
        private void txt_Copia_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txt_Copia.Text.Length > 0))
                txt_Senha.text += txt_Copia.Text.Replace(txt_Copia.Text, "*");
            else
            {
                txt_Copia.Text = "";
                txt_Senha.text = "";
            }
            if (txt_Copia.Text.Length < txt_Senha.text.Length && txt_Copia.Text.Length > 0)
                txt_Senha.text = txt_Senha.text.Remove(txt_Senha.text.Length - 2);
        }
        //Faz login
        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                //Executa Consulta no banco para verificar se login e senha constam
                ds = conexao.Executa_sql("select nome from tblFuncionario where email='" + txt_Login.text + "' and senha='" + txt_Copia.Text + "'");
                //Se consulta retornar verdadeiro, ele segue
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Pega nome de usuario do banco de acordo com login
                    usu = conexao.executeQueryComStringRetorno("select nome from tblFuncionario where email='" + txt_Login.text + "' and senha='" + txt_Copia.Text + "'");
                    //Pega nivel de acesso do usuario do banco
                    Nivel = conexao.executeQueryComStringRetorno("select nivel_acesso from tblFuncionario where email='" + txt_Login.text + "' and senha='" + txt_Copia.Text + "'");
                    home.Show();
                    this.Hide();
                }
                //Se login e senha nao constarem no banco, caimos aqui
                else
                {
                    MessageBox.Show("Login ou Senha incorretos.");
                    //Texto do Login e da senha ficam em branco
                    txt_Copia.Text = "";
                    txt_Senha.text = "";
                }
            }
            //So caimos aqui se tiver problema de conexao com o banco
            catch
            {
                DialogResult d = MessageBox.Show("Ocorreu um problema ao conectar com o banco, reiniciar a aplicaçao?", "Erro 234", MessageBoxButtons.YesNo);
                if (d.Equals(DialogResult.Yes)) Application.Restart();
                else Application.Exit();
            }
        }
        //Foca numa texbox oculta pra salvar a senha
        private void txt_Senha_Click(object sender, EventArgs e)
        {
            txt_Copia.Focus();
        }
        //Se enter for pressionado no elemento Txt_Copia essa funçao é chamada pra fazer o login
        private void txt_Copia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Login_Click_1(sender, e);
            }
        }
    }
}
