using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace AgendaSMS
{
    class conexaoBanco_Singleton
    {
        private static conexaoBanco_Singleton _instance;
        private OdbcConnection cnDB;
        private static OdbcDataAdapter adDB = new OdbcDataAdapter();
//        private static OdbcCommandBuilder cbDB = new OdbcCommandBuilder(adDB);
        private static DataSet dsDB = new DataSet();

        private conexaoBanco_Singleton()
        {
            String szConnect = "DSN=PostgreSQL35W;" +
                                "UID=jrfmzllubyxwmy;" +
                                "PWD=0a568ea7b45b071e0456645c883d3cd48fb0dea380f6c31f116c2a66cf38a2af";

            cnDB = new OdbcConnection(szConnect);

            try
            {
                cnDB.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + "StackTrace: \n\n" + ex.StackTrace);
                Console.WriteLine("\nPress  to continue...");
                Console.Read();
                return;
            }
        }

        public static conexaoBanco_Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new conexaoBanco_Singleton();
            }
            return _instance;
        }

        public void loginBanco(String _usuario, String _senha)
        {
            adDB.SelectCommand = new OdbcCommand("select id, nome, telefone from usuario where usuario = ? and senha = ?", cnDB);

            OdbcParameter param1 = new OdbcParameter();
            param1.DbType = DbType.String;
            param1.Value = _usuario;
            adDB.SelectCommand.Parameters.Add(param1);

            OdbcParameter param2 = new OdbcParameter();
            param2.DbType = DbType.String;
            param2.Value = _senha;
            adDB.SelectCommand.Parameters.Add(param2);

            adDB.Fill(dsDB);

            if (dsDB.Tables[0].Rows.Count > 0)
            {
                usuario_Singleton usuario = usuario_Singleton.getInstance();
                usuario.Id = Convert.ToInt32(dsDB.Tables[0].Rows[0]["id"].ToString());
                usuario.Nome = dsDB.Tables[0].Rows[0]["nome"].ToString();
                usuario.Telefone = dsDB.Tables[0].Rows[0]["telefone"].ToString();
            }
            adDB.Dispose();
        }

        public int numeroRegistros(String _pesquisa)
        {
            adDB.SelectCommand = new OdbcCommand("select id from "+_pesquisa, cnDB);
            adDB.Fill(dsDB);
            int registros = dsDB.Tables[0].Rows.Count;
            adDB.Dispose();
            return registros;
        }
        public void testeSelect()
        {
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
        }
    }
}
