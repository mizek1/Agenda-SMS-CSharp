using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace AgendaSMS
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conexaoBanco_Singleton conexao = conexaoBanco_Singleton.getInstance();
            conexao.testeSelect();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Usuario());

        }
    }
}
