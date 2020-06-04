using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSMS
{
    interface IContatoBuilder<B, C>
    {
        B setIdUsuario(int idUsuario);
        B setNome(String nome);
        B setTelefone(String telefone);
        B setAniversario(String aniversario);
        C criaContato();
    }
}
