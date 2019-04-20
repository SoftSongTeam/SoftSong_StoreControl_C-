using SoftSong.Classes;
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
    public partial class Form1 : Form
    {
        ////////////////////////////////////////////////
        //                                            //
        //   Tudo que Estiver Com UserControles na    //
        //          Frente chama uma nova tela        //
        //                                            //
        ////////////////////////////////////////////////
        
        
        public Form1()
        {
            InitializeComponent();
            //Aplica bordas arredondadas ao form
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
            //Mexe o mouse na posiçao x e y
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            //Chama a funcao UserControles com os parametros de Nome do UserControl e this.Controls
            UserControles(this.Controls, "Home");
        }

        ScriptEngine engine = new ScriptEngine();
        public static bool by = false;
        public static string pass;
        public void UserControles(Control.ControlCollection controles, String NomeUserControl)
        {
            //Percorre o Form atras de elementos doo tipo UserControl (Home, Cadastrar, etc) para abrir outro logo em seguida e nao sobrecarregar o sistema
            controles = this.Controls;
            foreach (Control ctrl in controles)
            {
                if (ctrl is UserControl)
                {
                    ((UserControl)(ctrl)).Dispose();
                }
            }
            //Codigo enviado a Classe ScriptEngine para gerar UserControl
            engine.CodigoDinamico(@"" +
                                    NomeUserControl + " ts = new " + NomeUserControl + "();" +
                                    "ts.Location = new Point(58, 55);" +
                                    "Controles.Add(ts);"
                                , this.Controls);

        }


        int X = 0;
        int Y = 0;

        //Abre e Fecha o menu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Se menu estiver com tamanho de aberto, feche
            if(sideMenu.Width == 252)
            {
                Logo.Visible = false;
                lilnote.Visible = true;
                LogoAnimator.Hide(Logo);
                sideMenu.Visible = false;
                sideMenu.Width = 40;
                //Executa  Animaçao
                PanelAnimator.ShowSync(sideMenu);
            }
            //Se estiver com tamanho de pequeno
            else
            {
                Logo.Visible = false;
                lilnote.Visible = false;
                sideMenu.Visible = false;
                sideMenu.Width = 252;
                //Executa animaçoes de Girar logo e Abrir Menu
                PanelAnimator.ShowSync(sideMenu);
                LogoAnimator.ShowSync(Logo);
            }
        }

        //Fecha Aplicaçao
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimiza Aplicaçao
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Calcula movimento do mouse
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        //Adiciona as coordenadas a posiçao
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        //Deixa o botao Home Selecionado
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Home.selected = true;
        }

        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            UserControles(this.Controls, "MenuControl");
        }

        //Quando um UserControl precisa chamar uma nova tela de dentro dele(Por exemplo, a Home chamar a tela do carrinho), ele tem q ser fechado antes do outro ser criado
        //porem ele nao pode "Se matar" logo o formulario q precisa chamar outro, determina uma variavel booleana como verdadeira(bool by) e uma String com o nome do UserControl(String pass) que ele quer q seja aberto
        //, o timer abaixo ve a alteraçao na variavel e libera a funçao, depois deixando a variavle by como falsa novamente
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (by == true)
            {
                UserControles(this.Controls, pass);
            }
            by = false;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            UserControles(this.Controls, "Home");
        }

        private void btn_Gerenciar_Click(object sender, EventArgs e)
        {
            UserControles(this.Controls, "MenuProdutos");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UserControles(this.Controls, "MenuPromo");
        }
    }
}
