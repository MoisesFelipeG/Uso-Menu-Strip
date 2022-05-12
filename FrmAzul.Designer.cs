namespace AppExemploMenu
{
    partial class FrmAzul
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
            this.exibirFormAzul = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAmareloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAzulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formVermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAzul.SuspendLayout();
            this.SuspendLayout();
            // 
            // exibirFormAzul
            // 
            this.exibirFormAzul.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.exibirFormAzul.Location = new System.Drawing.Point(0, 0);
            this.exibirFormAzul.Name = "exibirFormAzul";
            this.exibirFormAzul.Size = new System.Drawing.Size(800, 24);
            this.exibirFormAzul.TabIndex = 0;
            this.exibirFormAzul.Text = "menuStrip1";
            this.exibirFormAzul.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.exibirFormAzul_ItemClicked);
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
            this.formAmareloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAmareloToolStripMenuItem.Text = "Form Amarelo";
            // 
            // formAzulToolStripMenuItem
            // 
            this.formAzulToolStripMenuItem.Name = "formAzulToolStripMenuItem";
            this.formAzulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAzulToolStripMenuItem.Text = "Form Azul";
            // 
            // formVermelhoToolStripMenuItem
            // 
            this.formVermelhoToolStripMenuItem.Name = "formVermelhoToolStripMenuItem";
            this.formVermelhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formVermelhoToolStripMenuItem.Text = "Form Vermelho";
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exibirFormAzul);
            this.MainMenuStrip = this.exibirFormAzul;
            this.Name = "FrmAzul";
            this.Text = "Form3";
            this.exibirFormAzul.ResumeLayout(false);
            this.exibirFormAzul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip exibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAmareloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAzulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formVermelhoToolStripMenuItem;
    }
}