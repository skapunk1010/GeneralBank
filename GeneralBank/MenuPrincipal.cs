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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCliente form = new AgregarCliente();
            form.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarCuenta form = new AgregarCuenta();
            form.Show();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloquearCuenta form = new BloquearCuenta();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
