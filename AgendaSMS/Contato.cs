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

        private Contato(Builder builder)
        {
            this.id = 0;
            this.id_usuario = builder.Id_usuario;
            this.nome = builder.Nome;
            this.aniversario = builder.Aniversario;
            this.telefone = builder.Telefone;
        }

        public void insereContatoBanco()
        {
            conexao.insereContato(this);
        }

        public class Builder : IContatoBuilder<Builder, Contato>
        {
            int id_usuario;
            private String nome;
            private String aniversario;
            private String telefone;
            public Contato criaContato()
            {
                return new Contato(this);
            }

            public Builder setAniversario(string aniversario)
            {
                this.aniversario = aniversario;
                return this;
                    
            }

            public Builder setIdUsuario(int idUsuario)
            {
                this.id_usuario = idUsuario;
                return this;
            }

            public Builder setNome(string nome)
            {
                this.nome = nome;
                return this;
            }

            public Builder setTelefone(string telefone)
            {
                this.telefone = telefone;
                return this;
            }

            public int Id_usuario { get => id_usuario; }
            public string Nome { get => nome; }
            public string Aniversario { get => aniversario; }
            public string Telefone { get => telefone; }
        } 
        public int Id { get => id; }
        public int Id_usuario { get => id_usuario; }
        public string Nome { get => nome; }
        public string Aniversario { get => aniversario; }
        public string Telefone { get => telefone; }
    }
    
}
