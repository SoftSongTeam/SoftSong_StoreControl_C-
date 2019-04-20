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
    public partial class Cadastrar_Promocao : UserControl
    {
        public Cadastrar_Promocao()
        {
            InitializeComponent();
            //Chama funçao recuperar
            Recuperar();
        }
        DataSet ds = new DataSet();
        public string[] a;
        ClasseConexao conexao = new ClasseConexao();

        //pega todos os produtos do banco
        public void Recuperar()
        {
            a = conexao.Retorna_Array("Select * from tblProduto");
            label8.Text = a[3];
            txt_Preco.Text = a[4];
            String[] x = txt_Preco.Text.Split(',');
            x[1] = x[1].Remove(x[1].Length - 2);
            txt_Preco.Text = x[0] + "," + x[1];
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                String tf;
                String[] tff = txt_Tempo.Text.Split('/');
                tf = tff[2] + "-" + tff[1] + "-" + tff[0];
                String[] date = DateTime.Now.ToString().Split(' ');
                String[] tii = date[0].Split('/');
                String ti = tii[2] + "-" + tii[1] + "-" + tii[0];
                txt_Preco.Text = txt_Preco.Text.Replace(",", ".");
                ds = new DataSet();
                String x = "Insert into tblPromocao Values (" + Popup.id + ",'" + ti + "', '" + tf + "', " + txt_Preco.Text + ")";
                //MessageBox.Show(a);
                ds = conexao.Executa_sql(x);
                MessageBox.Show("Promoçao Adicionada com Sucesso!!");
                Form1.pass = "Home";
                Form1.by = true;
            }
            catch (Exception)
            {

            }
        }

        private void txt_Tempo_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Tempo.Text.Length == 8 && !txt_Tempo.Text.Contains("/") )
                txt_Tempo.Text = txt_Tempo.Text.Insert(2, "/").Insert(5, "/");
        }
    }
}
