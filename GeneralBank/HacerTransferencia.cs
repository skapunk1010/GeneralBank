using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneralBank.Clases;

namespace GeneralBank
{
    public partial class HacerTransferencia : Form
    {
        public HacerTransferencia()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            float monto = 0;
            String numCuenta = "";
            String destino = "";
            try
            {
                monto = (float)Convert.ToDecimal(txtCantTransferir.Text);
                numCuenta = txtCuentaOrigen.Text;
                destino = txtCuentaDestino.Text;
            }
            catch { }
            //Transferencia transf = new Transferencia(0, 0, "", "", null, monto, destino, numCuenta);
            ConfirmacionTransferencia form = new ConfirmacionTransferencia(numCuenta, destino, monto);
            form.Show();
            this.Close();
        }
    }
}
