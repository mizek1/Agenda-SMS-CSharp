using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{ 
    
    public class Contato
    {
        conexaoBanco_Singleton conexao = conexaoBanco_Singleton.getInstance();
        usuario_Singleton usuario = usuario_Singleton.getInstance();

        private int id;
        private int id_usuario;
        private String nome;
        private String aniversario;
        private String telefone;

        public Contato(int id, int id_usuario, string nome, string aniversario, string telefone)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.nome = nome;
            this.aniversario = aniversario;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Aniversario { get => aniversario; set => aniversario = value; }
        public string Telefone { get => telefone; set => telefone = value; }


    }
}
