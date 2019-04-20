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
    public partial class MenuProdutos : UserControl
    {
        public MenuProdutos()
        {
            InitializeComponent();
        }

        private void Add_Prod_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Prod);
            PanelAnimator.ShowSync(Add_Prod);
        }

        private void Edit_Prod_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Edit_Prod);
            PanelAnimator.ShowSync(Edit_Prod);
        }

        private void Add_Prod_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Adicionar_Produto";
        }

        private void Edit_Prod_Click(object sender, EventArgs e)
        {
            MenuControl.sql = "deletePromo";
            Form1.by = true;
            Form1.pass = "Popup";            
        }
    }
}
