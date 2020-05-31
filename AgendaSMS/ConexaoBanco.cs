using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AgendaSMS
{
    public class ConexaoBanco
    {
        private static string Host = "ec2-52-202-22-140.compute-1.amazonaws.com";
        private static string User = "qliarjcxcdyplr";
        private static string DBname = "d8piadgjd7c6pf";
        private static string Password = "241b283f3fd6e1505a15074c80c62cc1f58873632a54a8c7079bd6bbfc526876";
        private static string Port = "5432";

        static void Main(string[] args)
        {
            string connString = String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password); using (var conn = new NpgsqlConnection(connString))

            {
                Console.Out.WriteLine("Abrindo conexão");
                conn.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM contato", conn))
                {

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            string.Format(
                                "Reading from table=({0}, {1}, {2})",
                                reader.GetInt32(0).ToString(),
                                reader.GetString(1),
                                reader.GetInt32(2).ToString()
                                )
                            );
                    }
                }
            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
        }
    }
}
