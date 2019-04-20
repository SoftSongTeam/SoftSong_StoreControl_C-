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
using DevExpress.XtraEditors.Camera;

namespace SoftSong.Interfaces
{
    public partial class Cadastrar_Funcionario : UserControl
    {

        ////////////////////////////////////////////////
        //                                            //
        //    Todos os forms de cadastro de pessoas   //
        //            seguem o mesmo padrao           //
        //      Vide Cadastrar_Cliente, la ta tudo    //
        //                                            //
        ////////////////////////////////////////////////
        public Cadastrar_Funcionario()
        {
            InitializeComponent();
        }
        ClasseValida valida = new ClasseValida();
        ClasseConexao conexao = new ClasseConexao();
        DataSet ds = new DataSet();
        public static String Destino;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            valida.Limpar(this.Controls);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            valida.Remove(this.Controls);
            String a = valida.valCPF(txt_CPF.Text) + valida.valEmail(txt_Email.Text);
            String sex;
            if (cxc_UF.selectedIndex.ToString() == "3")
                sex = "9";
            else
                sex = cxc_UF.selectedIndex.ToString();
            if (a == "" && Destino != null)
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    String f = "INSERT INTO tblFuncionario VALUES (2, '" + txt_Nome.Text + "', '" + txt_CPF.Text + "', '" + txt_Tel.Text + "', '" + txt_Email.Text + "','" + txt_Senha.Text + "','" + Destino + "','" + sex + "')";
                    ds = conexao.Executa_sql(f);
                    MessageBox.Show("Funcionario Cadastrado com sucesso.");
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
            else
                MessageBox.Show("Corrija os campos Incorretos");
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
                    String Nome = "funcionario"  + (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tblFuncionario")) + 1).ToString() + ".jpg";
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
    }
}
