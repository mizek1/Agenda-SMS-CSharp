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
            String szConnect =  "DSN=dsnname;" +
                                "UID=postgres" +
                                "PWD=*******";

            OdbcConnection cnDB = new OdbcConnection(szConnect);

            try
            {
                cnDB.Open();
            } catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + "StackTrace: \n\n" + ex.StackTrace);
                Console.WriteLine("\nPress  to continue...");
                Console.Read();
                return;
            }

            DataSet dsDB = new DataSet();
            OdbcDataAdapter adDB = new OdbcDataAdapter();
            OdbcCommandBuilder cbDB = new OdbcCommandBuilder(adDB);
            adDB.SelectCommand = new OdbcCommand(
                                     "SELECT * FROM contato",
                                     cnDB);
            adDB.Fill(dsDB);

            // Display the record count
            Console.WriteLine("Table 'csharptest' contains {0} rows.\n",
                              dsDB.Tables[0].Rows.Count);

            // List the columns (using a foreach loop)
            Console.WriteLine("Columns\n=======\n");

            foreach (DataColumn dcDB in dsDB.Tables[0].Columns)
                Console.WriteLine("{0} ({1})", dcDB.ColumnName, dcDB.DataType);
            Console.WriteLine("\n");

            // Iterate through the rows and display the data in the table (using a for loop).
            // Display the data column last for readability.
            Console.WriteLine("Data\n====\n");
            //for (int i = 0; i to continue...");
            Console.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Usuario());
        }
    }
}
