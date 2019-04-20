using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Classe Auto-explicativa, nao perderei meu tempo
class ClasseValida
    {
    public String valCPF(String cpf)
    {

        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        string tempCpf;
        string digito;
        int soma;
        int resto;
        cpf = cpf.Trim();
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)

            return "CPF Invalido ";

        tempCpf = cpf.Substring(0, 9);

        soma = 0;

        for (int i = 0; i < 9; i++)

            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

        resto = soma % 11;

        if (resto < 2)

            resto = 0;

        else

            resto = 11 - resto;

        digito = resto.ToString();

        tempCpf = tempCpf + digito;

        soma = 0;

        for (int i = 0; i < 10; i++)

            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

        resto = soma % 11;

        if (resto < 2)

            resto = 0;

        else

            resto = 11 - resto;

        digito = digito + resto.ToString();

        if (cpf.EndsWith(digito) == false)
            return "CPF invalido ";
        else
            return "";
    }

    public String valEmail(String email)
    {
        if (email.Contains("@") && email.Contains("."))
        {
            String[] check = (email).Split('@');
            String val1 = (check[0]);
            String val2 = (check[1]);
            if (val1.Length >= 1)
                return "";
            else
                return "Email invalido ";
        }
        else
            return "Email invalido ";
    }
    public void Limpar(Control.ControlCollection controles)
    {
        foreach (Control ctrl in controles)
        {
            if (ctrl is BunifuMetroTextbox)
                ((BunifuMetroTextbox)(ctrl)).Text = String.Empty;
        }
    }
    public void Remove(Control.ControlCollection controles)
    {
        string[] comAcentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù",
            "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô",
            "û", "Â", "Ê", "Î", "Ô", "Û" };

        string[] semAcentos = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o",
            "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e",
            "i", "o", "u", "A", "E", "I", "O", "U" };
        int a;
        foreach (Control ctrl in controles)
        {
            if (ctrl is BunifuMetroTextbox)
            {
                for (a = 0; a < comAcentos.Length; a++)
                    ((BunifuMetroTextbox)(ctrl)).Text = (((BunifuMetroTextbox)(ctrl)).Text).Replace(comAcentos[a], semAcentos[a]);
            }
        }
    }
}
