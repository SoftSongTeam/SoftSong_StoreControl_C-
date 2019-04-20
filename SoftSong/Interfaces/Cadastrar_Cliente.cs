using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;

namespace SoftSong.Interfaces
{
    public partial class Cadastrar_Cliente : UserControl
    {
        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }
        public static String Destino;
        ClasseValida valida = new ClasseValida();
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            //chama a classe valida para validar os elementos 
            valida.Remove(this.Controls);
            String sex;
            String a = valida.valCPF(txt_CPF.Text) + valida.valEmail(txt_Email.Text);
            //coloca o sexo nos padroes estabelecidos pela google
            if (cxc_Sexo.selectedIndex.ToString() == "3")
                sex = "9";
            else
                sex = cxc_Sexo.selectedIndex.ToString();
            //se a classe valida nao retornar nenhum erro, insere o Cliente no banco
            if (a == "")
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    //Insere Cliente no banco
                    String f = "INSERT INTO tblCliente VALUES (3, '" + txt_Nome.Text + "', '" + txt_Tel.Text + "', '" + txt_Email.Text + "', 'vdsvdsjgx2344a' ,'" + txt_CPF.Text + "','" + txt_Endereco.Text + "','" + txt_Cidade.Text + "','" + cxc_UF.selectedIndex.ToString() + "','" + txt_CEP.Text + "','" + sex + "')";
                    ds = conexao.Executa_sql(f);
                    //Metodo q envia email para o cliente, vide la embaixo 
                    EmailSenha(txt_Email.Text);
                    MessageBox.Show("Usuario Cadastrado com sucesso, acesse o seu email para definir sua senha.");
                    //Remember explicaçao sobre forms nao poderem se matar? vai no Form1 caso nao 
                    Form1.by = true;
                    Form1.pass = "Home";
                }
                //Deu merda no insert, caimos aqui
                catch
                {
                    DialogResult d = MessageBox.Show("Ocorreu um problema ao conectar com o banco, reiniciar a aplicaçao?", "Erro 234", MessageBoxButtons.YesNo);
                    if (d.Equals(DialogResult.Yes)) Application.Restart();
                    else Application.Exit();
                }
            }
            //Caso a classe valida retorne incoerencias, ele manda isso e impede a inserçao no banco
            else
                MessageBox.Show("Corrija o(s) campos incorretos.");
        }
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();
        //Classe q envia emails
        public void EmailSenha(String Endereco)
        {
            //Cria nova mensagem
            Email = new MailMessage();
            //Adiciona endereço a ela(Email do cliente)
            Email.To.Add(new MailAddress(Endereco));
            //define Email que vai enviar
            Email.From = new MailAddress("softassistancecsharp@gmail.com");
            //Define Assunto
            Email.Subject = "Defina sua senha";
            //Define que o email pode ser feito em estrutura html
            Email.IsBodyHtml = true;
            //Email em si(Nao serve pra nada ainda)
            Email.Body = "Ola Senhor(a). Seja bem vindo(a) como nosso novo cliente, por favor, redefina sua senha no link abaixo:";
            //Define provedor que usaremos para o email(Gmail, no caso)
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            using (cliente)
            {
                //Credencias do email que vai enviar, favor nao macaquiar
                cliente.Credentials = new System.Net.NetworkCredential("softassistancecsharp@gmail.com", "programando123");
                //C R I P T O G R A F I A
                cliente.EnableSsl = true;
                //Envia
                cliente.Send(Email);
            }
        }
        //Limpa tudo
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            valida.Limpar(this.Controls);
        }
    }
}
