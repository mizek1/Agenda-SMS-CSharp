using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{
    class usuario_Singleton
    {
        private static usuario_Singleton _instance;
        private int id = 0;
        private String login;
        private String senha;
        private String nome;
        private String telefone;
//        private List<Contato> contatos;

        public static usuario_Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new usuario_Singleton();
            }
            return _instance;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
  //      internal List<Contato> Contatos { get => contatos; set => contatos = value; }
    }
}
