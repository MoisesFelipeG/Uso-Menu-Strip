using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAmarelo : Form
    {
        public FrmAmarelo()
        {
            InitializeComponent();
        }

        

        private void formAzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }

        private void formAmareloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }

        private void formVermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }
    }
}
