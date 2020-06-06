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
    public partial class telaVisualizarContato : Form
    {
        Contato contato;
        public telaVisualizarContato(Contato contato)
        {
            this.contato = contato;
            InitializeComponent();
            txtNome.Text = contato.Nome;
            txtTelefone.Text = contato.Telefone;
            txtAniversario.Text = contato.Aniversario;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void telaVisualizarContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
