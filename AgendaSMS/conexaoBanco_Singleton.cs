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
        usuario_Singleton usuario = usuario_Singleton.getInstance();
        private static conexaoBanco_Singleton _instance;
        private OdbcConnection cnDB;
        private static OdbcDataAdapter adDB = new OdbcDataAdapter();
        private static DataSet dsDB = new DataSet();
        private static DataTable dtContatos = new DataTable();

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
                usuario.Id = Convert.ToInt32(dsDB.Tables[0].Rows[0]["id"]);
                usuario.Nome = dsDB.Tables[0].Rows[0]["nome"].ToString();
                usuario.Telefone = dsDB.Tables[0].Rows[0]["telefone"].ToString();

                getContatosUsuario(usuario.Id);
            }
            adDB.Dispose();
        }

        public void getContatosUsuario(int _id)
        {
            adDB.SelectCommand = new OdbcCommand("select * from vw_contatos where id_usuario = ?", cnDB);

            OdbcParameter param1 = new OdbcParameter();
            param1.DbType = DbType.String;
            param1.Value = usuario.Id;
            adDB.SelectCommand.Parameters.Add(param1);

            dtContatos = new DataTable();
            adDB.Fill(dtContatos);

            adDB.Dispose();
        }

        public DataTable getDtContatos()
        {
            return dtContatos;
        }

        public int getNumeroDeRegistros(String _pesquisa)
        {
            adDB.SelectCommand = new OdbcCommand("select id from "+_pesquisa, cnDB);
            adDB.Fill(dsDB);
            int registros = dsDB.Tables[0].Rows.Count;
            adDB.Dispose();
            return registros;
        }

        public void insereContato(Contato contato)
        {
            OdbcCommand insereContato = new OdbcCommand("INSERT INTO contato (id, id_usuario, nome, aniver, telefone) VALUES (?, ?, ?, ?, ?)", cnDB);
            
            insereContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Id", System.Data.Odbc.OdbcType.Int, 0));
            insereContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Id_Usuario", System.Data.Odbc.OdbcType.Int, 0));
            insereContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Nome", System.Data.Odbc.OdbcType.VarChar, 40));
            insereContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Aniversario", System.Data.Odbc.OdbcType.Date, 0));
            insereContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Telefone", System.Data.Odbc.OdbcType.VarChar, 20));

            insereContato.Parameters["Id"].Value = contato.Id;
            insereContato.Parameters["Id_Usuario"].Value = contato.Id_usuario;
            insereContato.Parameters["Nome"].Value = contato.Nome;
            insereContato.Parameters["Aniversario"].Value = contato.Aniversario;
            insereContato.Parameters["Telefone"].Value = contato.Telefone;

            insereContato.ExecuteNonQuery();
            insereContato.Dispose();

            getContatosUsuario(usuario.Id);
        }

        public void atualizaContato(Contato contato)
        {
            OdbcCommand atualizaContato = new OdbcCommand("UPDATE contato set nome = ?, aniver = ?, telefone = ? WHERE id = ?", cnDB);

            atualizaContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Nome", System.Data.Odbc.OdbcType.VarChar, 40));
            atualizaContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Aniversario", System.Data.Odbc.OdbcType.Date, 0));
            atualizaContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Telefone", System.Data.Odbc.OdbcType.VarChar, 20));
            atualizaContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Id", System.Data.Odbc.OdbcType.Int, 0));

            atualizaContato.Parameters["Nome"].Value = contato.Nome;
            atualizaContato.Parameters["Aniversario"].Value = contato.Aniversario;
            atualizaContato.Parameters["Telefone"].Value = contato.Telefone;
            atualizaContato.Parameters["Id"].Value = contato.Id;

            atualizaContato.ExecuteNonQuery();
            atualizaContato.Dispose();

            getContatosUsuario(usuario.Id);
        }

        public void removerContato(int id_contato)
        {
            OdbcCommand removeContato = new OdbcCommand("DELETE FROM contato WHERE id = ?", cnDB);
            removeContato.Parameters.Add(new System.Data.Odbc.OdbcParameter("Id", System.Data.Odbc.OdbcType.Int, 0));
            removeContato.Parameters["Id"].Value = id_contato;
            removeContato.ExecuteNonQuery();
            removeContato.Dispose();
            getContatosUsuario(usuario.Id);
        }

    }
}

