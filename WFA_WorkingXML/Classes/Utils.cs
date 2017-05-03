using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Components
{
    public static class Utils
    {
        public static string MTD_LerArquivoTexto(string pNomeArquivo)
        {
            String strAppDir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"\bin\Debug", @"\Files").Replace(@"file:\","") ;

            String strFullPathToMyFile = System.IO.Path.Combine(strAppDir, pNomeArquivo);
            return System.IO.File.ReadAllText(strFullPathToMyFile);
        }

        public static string MTD_ObterCaminhoArquivo(string pNomeArquivo)
        {
            string strAppDir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"\bin\Debug", @"\Files").Replace(@"file:\", "");

            string strFullPathToMyFile = System.IO.Path.Combine(strAppDir, pNomeArquivo);

            return strFullPathToMyFile;


        }


        
    }
}
