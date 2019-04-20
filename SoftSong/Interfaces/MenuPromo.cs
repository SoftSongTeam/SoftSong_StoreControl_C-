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
    public partial class MenuPromo : UserControl
    {
        public MenuPromo()
        {
            InitializeComponent();
        }

        private void Add_Promo_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Add_Promo);
            PanelAnimator.ShowSync(Add_Promo);
        }

        private void Remove_Promo_MouseHover(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            PanelAnimator.HideSync(Remove_Promo);
            PanelAnimator.ShowSync(Remove_Promo);
        }

        private void Add_Promo_Click(object sender, EventArgs e)
        {
            Form1.by = true;
            Form1.pass = "Cadastrar_Promocao";
        }

        private void Remove_Promo_Click(object sender, EventArgs e)
        {

        }
    }
}
