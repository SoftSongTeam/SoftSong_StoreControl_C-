using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSong.Classes
{
    class ScriptEngine
    {
        //Essa classe cria uma classe a partir de string *ALTAMENTE COMPLEXO*
        //Explicaçao: A partir de um compilador dentro de uma classe, a gente usa uma String com todo o codigo de uma classe Completa para emular uma classe alteravel em tempo de uso.
        public object CodigoDinamico(string sCSCode, object oParam)
        {
            CSharpCodeProvider c = new CSharpCodeProvider();
            ICodeCompiler icc = c.CreateCompiler();
            CompilerParameters cp = new CompilerParameters();

            cp.ReferencedAssemblies.Add("system.dll");
            cp.ReferencedAssemblies.Add("system.xml.dll");
            cp.ReferencedAssemblies.Add("system.data.dll");
            cp.ReferencedAssemblies.Add("system.windows.forms.dll");
            cp.ReferencedAssemblies.Add("system.drawing.dll");
            cp.ReferencedAssemblies.Add("Softsong.exe");

            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;
            StringBuilder sb = new StringBuilder("");

            sb.Append("using System;\n");
            sb.Append("using System.Xml;\n");
            sb.Append("using System.Data;\n");
            sb.Append("using System.Data.SqlClient;\n");
            sb.Append("using System.Windows.Forms;\n");
            sb.Append("using System.Drawing;\n");
            sb.Append("using SoftSong.Interfaces;\n");
            sb.Append("using SoftSong.Popups;\n");

            sb.Append("namespace CSSoftSong{ \n");
            sb.Append("public class CSSoftSong{ \n");
            sb.Append("public object AbrirUser(Control.ControlCollection Controles){\n");
            sb.Append("object o = new object(); \n");
            sb.Append(sCSCode + " \n");
            sb.Append("return o; \n");
            sb.Append("} \n");
            sb.Append("} \n");
            sb.Append("}\n");
            //Debug.WriteLine(sb.ToString())// ' look at this to debug your eval string

            CompilerResults cr = icc.CompileAssemblyFromSource(cp, sb.ToString());
            if (cr.Errors.Count > 0)
            {
                MessageBox.Show("ERRO: " + cr.Errors[0].ErrorText, "Erro compilando esse codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            System.Reflection.Assembly a = cr.CompiledAssembly;
            object o = a.CreateInstance("CSSoftSong.CSSoftSong");
            Type t = o.GetType();
            MethodInfo mi = t.GetMethod("AbrirUser");
            object[] oParams = new object[1];
            oParams[0] = oParam;
            object s = mi.Invoke(o, oParams);
            return s;
        }
    }
}
