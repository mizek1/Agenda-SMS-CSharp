namespace AgendaSMS
{
    partial class telaConversas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConversas));
            this.btnBuscarContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaConversaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirConversasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirHistóricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnVisualizarContato = new System.Windows.Forms.Button();
            this.btnRemoverContato = new System.Windows.Forms.Button();
            this.btnAbrirConversa = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarContato
            // 
            this.btnBuscarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarContato.Image")));
            this.btnBuscarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarContato.Location = new System.Drawing.Point(130, 298);
            this.btnBuscarContato.Name = "btnBuscarContato";
            this.btnBuscarContato.Size = new System.Drawing.Size(65, 23);
            this.btnBuscarContato.TabIndex = 10;
            this.btnBuscarContato.Text = "Buscar";
            this.btnBuscarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarContato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conversas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem,
            this.conversasToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoContatoToolStripMenuItem,
            this.listarContatosToolStripMenuItem,
            this.alterarContatoToolStripMenuItem,
            this.excluirContatoToolStripMenuItem});
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.contatosToolStripMenuItem.Text = "Contatos";
            // 
            // novoContatoToolStripMenuItem
            // 
            this.novoContatoToolStripMenuItem.Name = "novoContatoToolStripMenuItem";
            this.novoContatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoContatoToolStripMenuItem.Text = "Novo contato";
            // 
            // listarContatosToolStripMenuItem
            // 
            this.listarContatosToolStripMenuItem.Name = "listarContatosToolStripMenuItem";
            this.listarContatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarContatosToolStripMenuItem.Text = "Listar contatos";
            // 
            // alterarContatoToolStripMenuItem
            // 
            this.alterarContatoToolStripMenuItem.Name = "alterarContatoToolStripMenuItem";
            this.alterarContatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarContatoToolStripMenuItem.Text = "Alterar contato";
            // 
            // excluirContatoToolStripMenuItem
            // 
            this.excluirContatoToolStripMenuItem.Name = "excluirContatoToolStripMenuItem";
            this.excluirContatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirContatoToolStripMenuItem.Text = "Excluir contato";
            // 
            // conversasToolStripMenuItem
            // 
            this.conversasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaConversaToolStripMenuItem,
            this.abrirConversasToolStripMenuItem});
            this.conversasToolStripMenuItem.Name = "conversasToolStripMenuItem";
            this.conversasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.conversasToolStripMenuItem.Text = "Conversas";
            // 
            // novaConversaToolStripMenuItem
            // 
            this.novaConversaToolStripMenuItem.Name = "novaConversaToolStripMenuItem";
            this.novaConversaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaConversaToolStripMenuItem.Text = "Nova conversa";
            // 
            // abrirConversasToolStripMenuItem
            // 
            this.abrirConversasToolStripMenuItem.Name = "abrirConversasToolStripMenuItem";
            this.abrirConversasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirConversasToolStripMenuItem.Text = "Abrir conversas";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirHistóricoToolStripMenuItem});
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // abrirHistóricoToolStripMenuItem
            // 
            this.abrirHistóricoToolStripMenuItem.Name = "abrirHistóricoToolStripMenuItem";
            this.abrirHistóricoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirHistóricoToolStripMenuItem.Text = "Abrir histórico";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // alterarUsuárioToolStripMenuItem
            // 
            this.alterarUsuárioToolStripMenuItem.Name = "alterarUsuárioToolStripMenuItem";
            this.alterarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarUsuárioToolStripMenuItem.Text = "Alterar usuário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.btnBuscarContato);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 326);
            this.panel1.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 299);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.Text = "Pesquisar...";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.btnEnviarMensagem);
            this.panel2.Controls.Add(this.txtMensagem);
            this.panel2.Location = new System.Drawing.Point(219, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 326);
            this.panel2.TabIndex = 12;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(4, 298);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(360, 20);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "Enviar mensagem";
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarMensagem.Image")));
            this.btnEnviarMensagem.Location = new System.Drawing.Point(370, 297);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(29, 23);
            this.btnEnviarMensagem.TabIndex = 1;
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(191, 288);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(395, 287);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnVisualizarContato
            // 
            this.btnVisualizarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarContato.Image")));
            this.btnVisualizarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarContato.Location = new System.Drawing.Point(286, 41);
            this.btnVisualizarContato.Name = "btnVisualizarContato";
            this.btnVisualizarContato.Size = new System.Drawing.Size(90, 23);
            this.btnVisualizarContato.TabIndex = 13;
            this.btnVisualizarContato.Text = "Ver contato";
            this.btnVisualizarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarContato.UseVisualStyleBackColor = true;
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverContato.Image")));
            this.btnRemoverContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverContato.Location = new System.Drawing.Point(505, 41);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(118, 23);
            this.btnRemoverContato.TabIndex = 14;
            this.btnRemoverContato.Text = "Remover contato";
            this.btnRemoverContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverContato.UseVisualStyleBackColor = true;
            // 
            // btnAbrirConversa
            // 
            this.btnAbrirConversa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirConversa.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirConversa.Image")));
            this.btnAbrirConversa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirConversa.Location = new System.Drawing.Point(382, 41);
            this.btnAbrirConversa.Name = "btnAbrirConversa";
            this.btnAbrirConversa.Size = new System.Drawing.Size(117, 23);
            this.btnAbrirConversa.TabIndex = 15;
            this.btnAbrirConversa.Text = "Apagar conversa";
            this.btnAbrirConversa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirConversa.UseVisualStyleBackColor = true;
            // 
            // telaConversas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 408);
            this.Controls.Add(this.btnAbrirConversa);
            this.Controls.Add(this.btnRemoverContato);
            this.Controls.Add(this.btnVisualizarContato);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "telaConversas";
            this.Text = "Conversas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarContatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaConversaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirConversasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirHistóricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnVisualizarContato;
        private System.Windows.Forms.Button btnRemoverContato;
        private System.Windows.Forms.Button btnAbrirConversa;
    }
}