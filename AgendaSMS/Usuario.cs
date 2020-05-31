using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{
    public class Usuario
    {
        private int id;
        private String login;
        private String senha;
        private String nome;
        private String telefone;
        private List<Contato> contatos;

        public Usuario(int id, string login, string senha, string nome, string telefone)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal List<Contato> Contatos { get => contatos; set => contatos = value; }
    }
}
