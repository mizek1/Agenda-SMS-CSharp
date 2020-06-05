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
    public partial class telaAlterarContato : Form
    {
        Contato contato;
        public telaAlterarContato(Contato contato)
        {
            this.contato = contato;
            InitializeComponent();
            txtNome.Text = contato.Nome;
            txtTelefone.Text = contato.Telefone;
            txtAniversario.Text = contato.Aniversario;
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text) && !String.IsNullOrWhiteSpace(txtTelefone.Text) && !String.IsNullOrWhiteSpace(txtAniversario.Text))
            {
                if (Convert.ToDateTime(txtAniversario.Text) > Convert.ToDateTime("01/01/1950")
                    && Convert.ToDateTime(txtAniversario.Text) < DateTime.Now)
                {
                    /*
                     *Contato novoContato = new Contato.Builder()
                                        .setIdUsuario(usuario_Singleton.getInstance().Id)
                                        .setNome(txtNome.Text)
                                        .setAniversario(txtAniversario.Text)
                                        .setTelefone(txtTelefone.Text)
                                        .criaContato();
                                        novoContato.insereContatoBanco();
                    MessageBox.Show("Contato atualizado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    */
                    MessageBox.Show("Falta fazer, fui dormir :D", "Quase!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data fora dos limites, verifique!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Campos vazios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
