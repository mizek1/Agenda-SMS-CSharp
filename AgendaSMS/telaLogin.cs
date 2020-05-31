using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AgendaSMS
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void button_Acessar_Click(object sender, EventArgs e)
        {
            if ((! String.IsNullOrWhiteSpace(textBox_Usuario.Text)) && 
                (! String.IsNullOrWhiteSpace(textBox_Senha.Text)) && 
                (validarCredenciais(textBox_Usuario.Text, textBox_Senha.Text)))
            {
                    telaContatos telaContatos = new telaContatos();
                    this.Hide();
                    telaContatos.ShowDialog();
            }
            else
            {
                textBox_Usuario.Focus();
                MessageBox.Show("Usuário ou senha inválidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarCredenciais(String _usuario, String _senha)
        {
            conexaoBanco_Singleton conexao = conexaoBanco_Singleton.getInstance();
            return conexao.numeroRegistros("usuario where usuario = \'" + _usuario + "\' and senha = \'" + _senha + "\'") > 0;
        }
        private void button_Sair_Click(object sender, EventArgs e) => Close();

        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "Informe seu nome de usuário")
            {
                textBox_Usuario.Text = "";
                textBox_Usuario.ForeColor = Color.Black;
            }
        }

        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                textBox_Usuario.Text = "Informe seu nome de usuário";
                textBox_Usuario.ForeColor = Color.Gray;
            }
        }

        private void textBox_Senha_Leave(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "")
            {
                textBox_Senha.Text = "Informe sua senha";
                textBox_Senha.ForeColor = Color.Gray;
                textBox_Senha.PasswordChar = (char)0;
            }
        }

        private void textBox_Senha_Enter(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "Informe sua senha")
            {
                textBox_Senha.Text = "";
                textBox_Senha.ForeColor = Color.Black;
                textBox_Senha.PasswordChar = '*';
            }
        }

        private void Form_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
        }
    }
}
