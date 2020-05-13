namespace AgendaSMS
{
    partial class telaHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaHistorico));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirConversa = new System.Windows.Forms.Button();
            this.btnRemoverContato = new System.Windows.Forms.Button();
            this.btnVisualizarContato = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Histórico";
            // 
            // btnAbrirConversa
            // 
            this.btnAbrirConversa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirConversa.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirConversa.Image")));
            this.btnAbrirConversa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirConversa.Location = new System.Drawing.Point(268, 19);
            this.btnAbrirConversa.Name = "btnAbrirConversa";
            this.btnAbrirConversa.Size = new System.Drawing.Size(117, 23);
            this.btnAbrirConversa.TabIndex = 19;
            this.btnAbrirConversa.Text = "Apagar conversa";
            this.btnAbrirConversa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirConversa.UseVisualStyleBackColor = true;
            // 
            // btnRemoverContato
            // 
            this.btnRemoverContato.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverContato.Image")));
            this.btnRemoverContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverContato.Location = new System.Drawing.Point(391, 19);
            this.btnRemoverContato.Name = "btnRemoverContato";
            this.btnRemoverContato.Size = new System.Drawing.Size(118, 23);
            this.btnRemoverContato.TabIndex = 18;
            this.btnRemoverContato.Text = "Remover contato";
            this.btnRemoverContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverContato.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarContato
            // 
            this.btnVisualizarContato.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarContato.Image")));
            this.btnVisualizarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarContato.Location = new System.Drawing.Point(172, 19);
            this.btnVisualizarContato.Name = "btnVisualizarContato";
            this.btnVisualizarContato.Size = new System.Drawing.Size(90, 23);
            this.btnVisualizarContato.TabIndex = 17;
            this.btnVisualizarContato.Text = "Ver contato";
            this.btnVisualizarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarContato.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 277);
            this.panel1.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 268);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // telaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrirConversa);
            this.Controls.Add(this.btnRemoverContato);
            this.Controls.Add(this.btnVisualizarContato);
            this.Controls.Add(this.label1);
            this.Name = "telaHistorico";
            this.Text = "Histórico";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirConversa;
        private System.Windows.Forms.Button btnRemoverContato;
        private System.Windows.Forms.Button btnVisualizarContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
    }
}