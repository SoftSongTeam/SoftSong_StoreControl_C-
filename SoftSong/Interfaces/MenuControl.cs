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
    public partial class MenuControl : UserControl
    {
        private PictureBox[] btns;
        private Label[] lbls;
        public static String sql;
        public MenuControl()
        {
            InitializeComponent();
        }
        private void Esconder()
        {
            Form1.by = true;
            Form1.pass = "Popup";
        }

        private void Add_Cli_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Cli);
            PanelAnimator.ShowSync(Add_Cli);
        }

        private void Add_Fun_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Fun);
            PanelAnimator.ShowSync(Add_Fun);
        }

        private void Add_Forn_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Forn);
            PanelAnimator.ShowSync(Add_Forn);
        }

        private void Add_Trans_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Trans);
            PanelAnimator.ShowSync(Add_Trans);
        }

        private void Edit_Cli_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Edit_Cli);
            PanelAnimator.ShowSync(Edit_Cli);
        }

        private void Edit_Fun_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Edit_Fun);
            PanelAnimator.ShowSync(Edit_Fun);
        }

        private void Edit_Forn_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Edit_Forn);
            PanelAnimator.ShowSync(Edit_Forn);
        }

        private void Edit_Trans_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Edit_Trans);
            PanelAnimator.ShowSync(Edit_Trans);
        }

        private void Edit_Cli_Click(object sender, EventArgs e)
        {
            Esconder();
            sql = "Cliente";
        }

        private void Edit_Fun_Click(object sender, EventArgs e)
        {
            Esconder();
            sql = "Funcionario";
        }

        private void Edit_Forn_Click(object sender, EventArgs e)
        {
            Esconder();
            sql = "Fornecedor";
        }

        private void Edit_Trans_Click(object sender, EventArgs e)
        {
            Esconder();
            sql = "Transportadora";
        }

        private void Add_Cli_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Cadastrar_Cliente";
        }

        private void Add_Fun_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Cadastrar_Funcionario";
        }

        private void Add_Forn_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Cadastrar_Fornecedor";
        }

        private void Add_Trans_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Cadastrar_Transportadora";
        }
    }
}
