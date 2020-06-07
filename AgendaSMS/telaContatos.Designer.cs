namespace AgendaSMS
{
    partial class telaContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaContatos));
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
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscarContato = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnVisualizarContato = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlterarContato = new System.Windows.Forms.Button();
            this.btnRemoverContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.novoContatoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.novoContatoToolStripMenuItem.Text = "Novo contato";
            this.novoContatoToolStripMenuItem.Click += new System.EventHandler(this.btnNovoContato_Click);
            // 
            // listarContatosToolStripMenuItem
            // 
            this.listarContatosToolStripMenuItem.Name = "listarContatosToolStripMenuItem";
            this.listarContatosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listarContatosToolStripMenuItem.Text = "Visualizar contato";
            this.listarContatosToolStripMenuItem.Click += new System.EventHandler(this.btnVisualizarContato_Click);
            // 
            // alterarContatoToolStripMenuItem
            // 
            this.alterarContatoToolStripMenuItem.Name = "alterarContatoToolStripMenuItem";
            this.alterarContatoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alterarContatoToolStripMenuItem.Text = "Alterar contato";
            this.alterarContatoToolStripMenuItem.Click += new System.EventHandler(this.btnAlterarContato_Click);
            // 
            // excluirContatoToolStripMenuItem
            // 
            this.excluirContatoToolStripMenuItem.Name = "excluirContatoToolStripMenuItem";
            this.excluirContatoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.excluirContatoToolStripMenuItem.Text = "Excluir contato";
            this.excluirContatoToolStripMenuItem.Click += new System.EventHandler(this.btnRemoverContato_Click);
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
            this.novaConversaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novaConversaToolStripMenuItem.Text = "Nova conversa";
            this.novaConversaToolStripMenuItem.Click += new System.EventHandler(this.novaConversaToolStripMenuItem_Click);
            // 
            // abrirConversasToolStripMenuItem
            // 
            this.abrirConversasToolStripMenuItem.Name = "abrirConversasToolStripMenuItem";
            this.abrirConversasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.abrirConversasToolStripMenuItem.Text = "Abrir conversas";
            this.abrirConversasToolStripMenuItem.Click += new System.EventHandler(this.abrirConversasToolStripMenuItem_Click);
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
            this.abrirHistóricoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.abrirHistóricoToolStripMenuItem.Text = "Abrir histórico";
            this.abrirHistóricoToolStripMenuItem.Click += new System.EventHandler(this.abrirHistóricoToolStripMenuItem_Click);
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
            this.alterarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alterarUsuárioToolStripMenuItem.Text = "Alterar usuário";
            this.alterarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGrid.Location = new System.Drawing.Point(0, 119);
            this.dGrid.MultiSelect = false;
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.Size = new System.Drawing.Size(521, 206);
            this.dGrid.TabIndex = 2;
            this.dGrid.DoubleClick += new System.EventHandler(this.btnVisualizarContato_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnBuscarContato);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.btnVisualizarContato);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAlterarContato);
            this.panel1.Controls.Add(this.btnRemoverContato);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(20, 53);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(78, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscarContato
            // 
            this.btnBuscarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarContato.Image")));
            this.btnBuscarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarContato.Location = new System.Drawing.Point(445, 52);
            this.btnBuscarContato.Name = "btnBuscarContato";
            this.btnBuscarContato.Size = new System.Drawing.Size(65, 23);
            this.btnBuscarContato.TabIndex = 1;
            this.btnBuscarContato.Text = "&Buscar";
            this.btnBuscarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarContato.UseVisualStyleBackColor = true;
            this.btnBuscarContato.Click += new System.EventHandler(this.btnBuscarContato_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(208, 55);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(231, 20);
            this.txtBusca.TabIndex = 0;
            // 
            // btnVisualizarContato
            // 
            this.btnVisualizarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarContato.Image")));
            this.btnVisualizarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarContato.Location = new System.Drawing.Point(208, 16);
            this.btnVisualizarContato.Name = "btnVisualizarContato";
            this.btnVisualizarContato.Size = new System.Drawing.Size(78, 23);
            this.btnVisualizarContato.TabIndex = 2;
            this.btnVisualizarContato.Text = "&Visualizar";
            this.btnVisualizarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarContato.UseVisualStyleBackColor = true;
            this.btnVisualizarContato.Click += new System.EventHandler(this.btnVisualizarContato_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(294, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Novo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNovoContato_Click);
            // 
            // btnAlterarContato
            // 
            this.btnAlterarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarContato.Image")));
            this.btnAlterarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarContato.Location = new System.Drawing.Point(364, 16);
            this.btnAlterarContato.Name = "btnAlterarContato";
            this.btnAlterarContato.Size = new System.Drawing.Size(63, 23);
            this.btnAlterarContato.TabIndex = 4;
            this.btnAlterarContato.Text = "&Alterar";
            this.btnAlterarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarContato.UseVisualStyleBackColor = true;
            this.btnAlterarContato.Click += new System.EventHandler(this.btnAlterarContato_Click);
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverContato.Image")));
            this.btnRemoverContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverContato.Location = new System.Drawing.Point(435, 16);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverContato.TabIndex = 5;
            this.btnRemoverContato.Text = "&Remover";
            this.btnRemoverContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverContato.UseVisualStyleBackColor = true;
            this.btnRemoverContato.Click += new System.EventHandler(this.btnRemoverContato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contatos";
            // 
            // telaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 332);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "telaContatos";
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.telaContatos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telaContatos_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarContato;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnVisualizarContato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlterarContato;
        private System.Windows.Forms.Button btnRemoverContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}