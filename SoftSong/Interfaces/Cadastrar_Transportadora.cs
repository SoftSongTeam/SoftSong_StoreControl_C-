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
    public partial class Cadastrar_Transportadora : UserControl
    {
        ////////////////////////////////////////////////
        //                                            //
        //    Todos os forms de cadastro de pessoas   //
        //            seguem o mesmo padrao           //
        //      Vide Cadastrar_Cliente, la ta tudo    //
        //                                            //
        ////////////////////////////////////////////////
        public Cadastrar_Transportadora()
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
            String a = valida.valEmail(txt_Email.Text);
            if (a == "" && Destino != null)
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    String f = "INSERT INTO tblTransportadora VALUES ('" + txt_Nome.Text + "', '" + txt_CNPJ.Text + "', '" + txt_Tel.Text + "', '" + txt_Email.Text + "', '" + txt_Endereco.Text + "', '" + txt_Cidade.Text + "', '" + cxc_UF.selectedIndex.ToString() + "', '" + txt_CEP.Text + "', '" + Destino + "')";
                    ds = conexao.Executa_sql(f);
                    //ds = conexao.executa_sql("Insert Into Fisica values('1211','a','aa','aa','a','aa','aa','aa','a')");
                    MessageBox.Show("Transportadora Cadastrada com sucesso.");
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
                MessageBox.Show("Corrija os campos incorretos.");
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
                    String Nome = "transportadora" + (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tblTransportadora")) + 1).ToString() + ".jpg";
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
                    string n = (Convert.ToInt32(conexao.executeQueryComStringRetorno("Select Count(*) from tblTransportadora")) + 1).ToString();
                    i.Save(@"C:\Users\Public\Documents\Fotos_Sistema\transportadora" + n + ".jpg");
                    Destino = @"C:\Users\Public\Documents\Fotos_Sistema\transportadora" + n + ".jpg";
                    pictureBox4.Load(Destino);
                }
            }
        }
    }
}
