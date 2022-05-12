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
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void exibirFormAzul_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FrmAzul frm = new FrmAzul(); //INDICO QUAL FORM SERÁ ABERTO
            this.Close(); //fechar atual
            frm.ShowDialog();
        }
    }
}
