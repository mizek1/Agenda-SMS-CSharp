namespace AgendaSMS
{
    partial class telaVisualizarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaVisualizarContato));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtAniversario = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrirHistorico = new System.Windows.Forms.Button();
            this.btnAbrirConversa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar Contato";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNome.Location = new System.Drawing.Point(17, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(491, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefone.Location = new System.Drawing.Point(17, 125);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(491, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.Text = "Telefone";
            // 
            // txtAniversario
            // 
            this.txtAniversario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAniversario.Location = new System.Drawing.Point(17, 161);
            this.txtAniversario.Name = "txtAniversario";
            this.txtAniversario.ReadOnly = true;
            this.txtAniversario.Size = new System.Drawing.Size(491, 20);
            this.txtAniversario.TabIndex = 5;
            this.txtAniversario.Text = "Aniversário";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(456, 218);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnAbrirHistorico
            // 
            this.btnAbrirHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirHistorico.Image")));
            this.btnAbrirHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirHistorico.Location = new System.Drawing.Point(348, 218);
            this.btnAbrirHistorico.Name = "btnAbrirHistorico";
            this.btnAbrirHistorico.Size = new System.Drawing.Size(102, 23);
            this.btnAbrirHistorico.TabIndex = 7;
            this.btnAbrirHistorico.Text = "Abrir histórico";
            this.btnAbrirHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirHistorico.UseVisualStyleBackColor = true;
            // 
            // btnAbrirConversa
            // 
            this.btnAbrirConversa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirConversa.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirConversa.Image")));
            this.btnAbrirConversa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirConversa.Location = new System.Drawing.Point(236, 218);
            this.btnAbrirConversa.Name = "btnAbrirConversa";
            this.btnAbrirConversa.Size = new System.Drawing.Size(106, 23);
            this.btnAbrirConversa.TabIndex = 8;
            this.btnAbrirConversa.Text = "Abrir conversa";
            this.btnAbrirConversa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirConversa.UseVisualStyleBackColor = true;
            // 
            // telaVisualizarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 278);
            this.Controls.Add(this.btnAbrirConversa);
            this.Controls.Add(this.btnAbrirHistorico);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAniversario);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "telaVisualizarContato";
            this.Text = "Visualizar contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtAniversario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAbrirHistorico;
        private System.Windows.Forms.Button btnAbrirConversa;
    }
}