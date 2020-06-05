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
        conexaoBanco_Singleton conexao = conexaoBanco_Singleton.getInstance();
        usuario_Singleton usuario = usuario_Singleton.getInstance();
        public telaContatos()
        {
            InitializeComponent();
        }

        public telaContatos getInstance()
        {
            return this;
        }

        private void telaContatos_Load(object sender, EventArgs e)
        {
            dGrid.DataSource = conexao.getDtContatos();
            formatarGrid();
        }

        private void formatarGrid()
        {
            dGrid.Columns["id_contato"].Visible = false;
            dGrid.Columns["id_usuario"].Visible = false;
            dGrid.Columns["nome"].HeaderText = "Contato";
            dGrid.Columns["telefone"].HeaderText = "Telefone";
            dGrid.Columns["aniver"].HeaderText = "Aniversário";
            dGrid.Columns["aniver"].DefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;
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

        private int linhaAtual()
        {
            DataGridViewRow linhaAtual = dGrid.CurrentRow;
            return linhaAtual.Index;
        }

        private void btnVisualizarContato_Click(object sender, EventArgs e)
        {
            int indexLinha = linhaAtual();

            Contato visualizaContato;
            visualizaContato = new Contato.Builder()
                .setIdUsuario(Convert.ToInt32(dGrid.Rows[indexLinha].Cells[1].Value))
                .setNome(Convert.ToString(dGrid.Rows[indexLinha].Cells[2].Value))
                .setAniversario(Convert.ToString(dGrid.Rows[indexLinha].Cells[4].Value))
                .setTelefone(Convert.ToString(dGrid.Rows[indexLinha].Cells[3].Value))
                .criaContato();

            telaVisualizarContato telaVisualizarContato = new telaVisualizarContato(visualizaContato);
            telaVisualizarContato.ShowDialog();
        }

        private void btnNovoContato_Click(object sender, EventArgs e)
        {
            telaNovoContato telaNovoContato = new telaNovoContato();
            telaNovoContato.ShowDialog();
        }

        private void btnAlterarContato_Click(object sender, EventArgs e)
        {
/*
 *int indexLinha = linhaAtual();

            Contato visualizaContato;
            visualizaContato = new Contato.Builder()
                .setIdUsuario(Convert.ToInt32(dGrid.Rows[indexLinha].Cells[1].Value))
                .setNome(Convert.ToString(dGrid.Rows[indexLinha].Cells[2].Value))
                .setAniversario(Convert.ToString(dGrid.Rows[indexLinha].Cells[4].Value))
                .setTelefone(Convert.ToString(dGrid.Rows[indexLinha].Cells[3].Value))
                .criaContato();

            telaVisualizarContato telaVisualizarContato = new telaVisualizarContato(visualizaContato);
            telaVisualizarContato.ShowDialog();
*/
        }
        private void btnRemoverContato_Click(object sender, EventArgs e)
        {
            int indexLinha = linhaAtual();
            String mensagem = "Confirma remoção do contato?\n" +
                Convert.ToString(dGrid.Rows[indexLinha].Cells[2].Value) + "\n" +
                Convert.ToString(dGrid.Rows[indexLinha].Cells[3].Value) + "\n" +
                Convert.ToString(dGrid.Rows[indexLinha].Cells[4].Value).Substring(0,10);

            if (MessageBox.Show(mensagem, 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                conexao.removerContato(Convert.ToInt32(dGrid.Rows[indexLinha].Cells[0].Value));
                
                dGrid.DataSource = conexao.getDtContatos();
            }
        }
        private void btnBuscarContato_Click(object sender, EventArgs e)
        {

        }

        private void telaContatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
