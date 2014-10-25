using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneralBank
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HacerDeposito form = new HacerDeposito();
            form.Show();
        }

        private void transferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HacerTransferencia form = new HacerTransferencia();
            form.Show();
        }
    }
}
