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

namespace SoftSong.Interfaces
{
    public partial class Editar_Cliente : UserControl
    {
        public Editar_Cliente()
        {
            InitializeComponent();
            Edicao(this.Controls);
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
            if (cxc_UF.selectedIndex.ToString() == "3")
                sex = "9";
            else
                sex = cxc_UF.selectedIndex.ToString();
            DialogResult fi = MessageBox.Show("Voce tem certeza que deseja atualizar suas informaçoes?", "Atualizaçãõ", MessageBoxButtons.YesNo);
            if (fi.Equals(DialogResult.Yes))
            {
                try
                {
                    conexao = new ClasseConexao();
                    ds = new DataSet();
                    if (Destino == null)
                        Destino = Caminho_Antigo;
                    String f = "Update tblCliente set nome='" + txt_Nome.Text + "', email='" + txt_Email.Text + "', CPF='" + txt_CPF.Text + "', tel1='" + txt_Tel.Text + "', endereco='" + txt_Endereco.Text + "', cidade='" + txt_Cidade.Text + "', CEP='" + txt_CEP.Text + "', estado='" + cxc_UF.selectedIndex.ToString() + "', genero='" + cxc_Sexo.selectedIndex.ToString() + "' Where CPF=" + Popup.id;
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
            else
            {
                Form1.by = true;
                Form1.pass = "Home";
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
                    String f = "Delete From tblCliente Where CPF=" + Popup.id + "";
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
            if (Popup.id.Length < 11)
                Popup.id = "0" + Popup.id;
            int i = 6;
            String a = "Select CPF,email,nome,tel1,endereco,cidade,CEP,estado,genero from tblCliente where CPF='" + Popup.id + "'";
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
                    if (ctrl.Name == "cxc_UF")
                        cxc_UF.selectedIndex = Convert.ToInt32(ed[7]);
                    else if (ctrl.Name == "cxc_Sexo")
                    {
                        try
                        {
                            cxc_Sexo.selectedIndex = Convert.ToInt32(ed[8]);
                        }
                        catch
                        {
                            cxc_Sexo.selectedIndex = 3;
                        }
                    }
                }



            }

        }
    }
}
