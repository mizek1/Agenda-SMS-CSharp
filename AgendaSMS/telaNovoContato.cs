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
    public partial class telaNovoContato : Form
    {
        public telaNovoContato()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text) && !String.IsNullOrWhiteSpace(txtTelefone.Text) && !String.IsNullOrWhiteSpace(txtAniversario.Text))
            {
                if (Convert.ToDateTime(txtAniversario.Text) > Convert.ToDateTime("01/01/1950") 
                    && Convert.ToDateTime(txtAniversario.Text) < DateTime.Now)
                {
                    Contato novoContato = new Contato.Builder()
                    .setIdUsuario(usuario_Singleton.getInstance().Id)
                    .setNome(txtNome.Text)
                    .setAniversario(txtAniversario.Text)
                    .setTelefone(txtTelefone.Text)
                    .criaContato();
                    novoContato.insereContatoBanco();
                    MessageBox.Show("Contato cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                } else
                {
                    MessageBox.Show("Data fora dos limites, verifique!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            } else
            {
                MessageBox.Show("Campos vazios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
