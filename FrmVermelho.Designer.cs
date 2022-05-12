namespace AppExemploMenu
{
    partial class FrmVermelho
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
            this.exibirFormVermelho = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAmareloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formVermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAzulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormVermelho.SuspendLayout();
            this.SuspendLayout();
            // 
            // exibirFormVermelho
            // 
            this.exibirFormVermelho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.exibirFormVermelho.Location = new System.Drawing.Point(0, 0);
            this.exibirFormVermelho.Name = "exibirFormVermelho";
            this.exibirFormVermelho.Size = new System.Drawing.Size(800, 24);
            this.exibirFormVermelho.TabIndex = 0;
            this.exibirFormVermelho.Text = "menuStrip1";
            this.exibirFormVermelho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.exibirFormVermelho_ItemClicked);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formAmareloToolStripMenuItem,
            this.formVermelhoToolStripMenuItem,
            this.formAzulToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // formAmareloToolStripMenuItem
            // 
            this.formAmareloToolStripMenuItem.Name = "formAmareloToolStripMenuItem";
            this.formAmareloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAmareloToolStripMenuItem.Text = "Form Amarelo";
            // 
            // formVermelhoToolStripMenuItem
            // 
            this.formVermelhoToolStripMenuItem.Name = "formVermelhoToolStripMenuItem";
            this.formVermelhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formVermelhoToolStripMenuItem.Text = "Form Vermelho";
            // 
            // formAzulToolStripMenuItem
            // 
            this.formAzulToolStripMenuItem.Name = "formAzulToolStripMenuItem";
            this.formAzulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAzulToolStripMenuItem.Text = "Form Azul";
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exibirFormVermelho);
            this.MainMenuStrip = this.exibirFormVermelho;
            this.Name = "FrmVermelho";
            this.Text = "Form2";
            this.exibirFormVermelho.ResumeLayout(false);
            this.exibirFormVermelho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip exibirFormVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAmareloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formVermelhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAzulToolStripMenuItem;
    }
}