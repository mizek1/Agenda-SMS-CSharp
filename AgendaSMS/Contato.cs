using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{
    class Contato
    {
        private int id;
        private int idUsuario;
        private String nome;
        private String aniversario;
        private String telefone;
        private List<Mensagem> conversa;

        public Contato(int id, int idUsuario, string nome, string aniversario, string telefone)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.nome = nome;
            this.aniversario = aniversario;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Aniversario { get => aniversario; set => aniversario = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
