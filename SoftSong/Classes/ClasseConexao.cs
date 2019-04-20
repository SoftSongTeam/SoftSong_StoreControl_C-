using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

public class ClasseConexao
{

    SqlConnection conexao = new SqlConnection();

    private SqlConnection conectar()
    {
        try
        {
            //A conexao é feita a partir da string abaixo pois ela contem os dados necessarios para a conexao 
            String strConexao = "Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=LojaMusica; Data Source=" + Environment.MachineName;
            conexao.ConnectionString = strConexao;
            conexao.Open();
            return conexao;
        }
        //se der erro na conexao ele cai aqui e chama uma funçao para se desconectar
        catch (Exception)
        {
            desconectar();
            return null;
        }
    }

    //Aqui ele se desconecta
    public void desconectar()
    {
        
            if ((conexao.State == ConnectionState.Open))
            {
                conexao.Close();
                conexao.Dispose();
            }
        
        
    }

    //Classe que executa comandos sql na conexao previamente aberta 
    public DataSet Executa_sql(String comando_sql)
    {

        try
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conectar());
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            return ds;
        }
        catch (Exception)
        {
            return null;
        }
        finally
        {
            desconectar();
        }
    }

    //Disney pra gente 
    public int executa_IncAltExcParametros(SqlCommand comando) //incluir, alterar, excluir
    {
        /*
        con = new ClasseConexao();
        String nome = txtNome.Text;
        String fone = txtFone.Text;
        byte[] imagem = ImgToByte(caminhoImagem);
        SqlCommand cmd = new SqlCommand("INSERT INTO contatosIMG(nome,fone,img) VALUES(@nome,@fone,@img)");
        cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;
        cmd.Parameters.Add("@fone", SqlDbType.NVarChar, 50).Value = fone;
        cmd.Parameters.Add("@img", SqlDbType.VarBinary, imagem.Length).Value = imagem;
        int x = con.executa_IncAltExcParametros(cmd); //retorna o número de linhas afetadas no DB
        if(x > 0)
        {
            btnAdicionarImagem.Visible = false;
            btnSalvar.Visible = false;
            atualizar_dados();
            MessageBox.Show("Registro Salvo");
        }
        else
        {
            MessageBox.Show("Falha ao inserir registro");
        }			
        */
        int retorno = 0;
        try
        {
            comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
            retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
        }
        catch (Exception) { }
        desconectar();
        return retorno;
    }

    //Nao funciona, Noa usamos
    public DataTable executa_Procedure(String x)
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        try
        {
            conectar();
            cmd = new SqlCommand("minha_procedure", conectar()); //não digitar Exec, não passar os parâmetros
            cmd.Parameters.Add(new SqlParameter("@par1", x));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
        }
        catch (Exception) { }
        return dt;
    }

    //Retorna unica String com unico resultado de uma consulta SQL, apenas para consultas muito especificas ou pedreragens(temos algumas por preguiça)
    public string executeQueryComStringRetorno(string sql)
    {
        try
        {
            string dado;
            SqlCommand sqlComm = new SqlCommand(sql, conectar());
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dado = dt.Rows[0][0].ToString();
            return dado;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            desconectar();
        }
    }

    //Outra pedreragem, nao usamos Mais
    public void Recuperar_Edicao(string sql, Control.ControlCollection controles)
    {
        ArrayList lista = new ArrayList();
        try
        {
            SqlCommand sqlComm = new SqlCommand(sql, conectar());
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dtrow in dt.Rows)
            {
                lista.Add(string.Join(";", dtrow.ItemArray.Select(item => item.ToString())));
            }
             String[] a = (lista[0].ToString()).Split(';');
            foreach (Control ctrl in controles)
            {
                if (ctrl.Name == "txt_Nome")
                    ((Bunifu.Framework.UI.BunifuMetroTextbox)(ctrl)).Text = a[0];
                else if (ctrl.Name == "txt_Email")
                    if (ctrl is Label)
                        ((Label)(ctrl)).Text = a[1];
                    else
                    ((Bunifu.Framework.UI.BunifuMetroTextbox)(ctrl)).Text = a[1];
                else if (ctrl.Name == "txt_CPF")
                    if(ctrl is Label)
                        ((Label)(ctrl)).Text = a[2];
                    else
                        ((Bunifu.Framework.UI.BunifuMetroTextbox)(ctrl)).Text = a[2];
                else if (ctrl.Name == "cxc_UF")
                    if(ctrl is Label)
                        ((Label)(ctrl)).Text = a[3];
                    else
                        ((Bunifu.Framework.UI.BunifuDropdown)(ctrl)).selectedIndex = Convert.ToInt32(a[3]);
                
                else if (ctrl.Name == "txt_Senha")
                    ((Bunifu.Framework.UI.BunifuMetroTextbox)(ctrl)).Text = a[4];
                else if (ctrl.Name == "pictureBox4")
                    ((PictureBox)(ctrl)).Load(a[5]);
            }
            
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            desconectar();
        }
    }

    //Versao nao pedreira e bonita da que retorna uma String apenas, essa retorna um array completo de uma consulta
    public String[] Retorna_Array(string sql)
    {
        ArrayList lista = new ArrayList();
        try
        {
            SqlCommand sqlComm = new SqlCommand(sql, conectar());
            sqlComm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dtrow in dt.Rows)
            {
                lista.Add(string.Join(";", dtrow.ItemArray.Select(item => item.ToString())));
            }
            String[] a = (lista[0].ToString()).Split(';');
            return a;
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            desconectar();
        }
    }
    //??
    public void ex(String sql)
    {
        try
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conectar());
        }
        catch (Exception)
        {
            
        }
        finally
        {
            desconectar();
        }
    }

    //Disney do Rubens :O
    public bool manutencao(String comando_sql) //teste
    {
        try
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = comando_sql;
            comando.Connection = conectar();
            conexao.Open();
            comando.ExecuteScalar();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        finally
        {
            desconectar();
        }
    }
}
