using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{
    class Mensagem
    {
        private int id;
        private Usuario remetente;
        private Contato destinatario;
        private String corpoMensagem;
        private DateTime date;

        public Mensagem(int id, Usuario remetente, Contato destinatario, string mensagem, DateTime date)
        {
            this.id = id;
            this.remetente = remetente;
            this.destinatario = destinatario;
            this.corpoMensagem = mensagem;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public Usuario Remetente { get => remetente; set => remetente = value; }
        public string CorpoMensagem { get => corpoMensagem; set => corpoMensagem = value; }
        public DateTime Date { get => date; set => date = value; }
        internal Contato Destinatario { get => destinatario; set => destinatario = value; }
    }
}
