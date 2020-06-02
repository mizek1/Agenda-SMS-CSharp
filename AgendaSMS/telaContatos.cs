using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSMS
{
    public partial class telaContatos : Form
    {
        usuario_Singleton usuario = usuario_Singleton.getInstance();
        public telaContatos(int id_usuario)
        {
            InitializeComponent();
        }

        private void novoContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaNovoContato telaNovoContato = new telaNovoContato();
            telaNovoContato.ShowDialog();
        }

        private void listarContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Não chama nada pois já está na tela da lista de contatos
        }

        private void alterarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Não chama nada pois necessário selecionar um contato para alterar
        }

        private void excluirContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Não chama nada pois necessário selecionar um contato para remover
        }

        private void novaConversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaConversas telaConversas = new telaConversas();
            this.Hide();
            telaConversas.ShowDialog();
        }

        private void abrirConversasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaConversas telaConversas = new telaConversas();
            this.Hide();
            telaConversas.ShowDialog();
        }

        private void abrirHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaHistorico telaHistorico = new telaHistorico();
            this.Hide();
            //precisa pegar o contato selecionado e abrir o histórico
            telaHistorico.ShowDialog();
        }

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaUsuario telaUsuario = new telaUsuario();
            telaUsuario.ShowDialog();
        }

        private void btnVisualizarContato_Click(object sender, EventArgs e)
        {

        }

        private void telaContatos_Load(object sender, EventArgs e)
        {
            // parei aki
        }
    }
}
