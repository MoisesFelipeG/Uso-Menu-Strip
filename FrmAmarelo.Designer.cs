namespace AppExemploMenu
{
    partial class FrmAmarelo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirFormAmarelo = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAmareloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAzulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formVermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAmarelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exibirFormAmarelo
            // 
            this.exibirFormAmarelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.exibirFormAmarelo.Location = new System.Drawing.Point(0, 0);
            this.exibirFormAmarelo.Name = "exibirFormAmarelo";
            this.exibirFormAmarelo.Size = new System.Drawing.Size(800, 24);
            this.exibirFormAmarelo.TabIndex = 1;
            this.exibirFormAmarelo.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formAmareloToolStripMenuItem,
            this.formAzulToolStripMenuItem,
            this.formVermelhoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // formAmareloToolStripMenuItem
            // 
            this.formAmareloToolStripMenuItem.Name = "formAmareloToolStripMenuItem";
            this.formAmareloToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formAmareloToolStripMenuItem.Text = "Form Amarelo";
            this.formAmareloToolStripMenuItem.Click += new System.EventHandler(this.formAmareloToolStripMenuItem_Click);
            // 
            // formAzulToolStripMenuItem
            // 
            this.formAzulToolStripMenuItem.Name = "formAzulToolStripMenuItem";
            this.formAzulToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formAzulToolStripMenuItem.Text = "Form Azul";
            this.formAzulToolStripMenuItem.Click += new System.EventHandler(this.formAzulToolStripMenuItem_Click);
            // 
            // formVermelhoToolStripMenuItem
            // 
            this.formVermelhoToolStripMenuItem.Name = "formVermelhoToolStripMenuItem";
            this.formVermelhoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formVermelhoToolStripMenuItem.Text = "Form Vermelho";
            this.formVermelhoToolStripMenuItem.Click += new System.EventHandler(this.formVermelhoToolStripMenuItem_Click);
            // 
            // FrmAmarelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exibirFormAmarelo);
            this.MainMenuStrip = this.exibirFormAmarelo;
            this.Name = "FrmAmarelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.exibirFormAmarelo.ResumeLayout(false);
            this.exibirFormAmarelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip exibirFormAmarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAmareloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAzulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formVermelhoToolStripMenuItem;
    }
}

