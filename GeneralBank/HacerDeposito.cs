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
    public partial class HacerDeposito : Form
    {
        public HacerDeposito()
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
            try
            {
                monto = (float) Convert.ToDecimal(txtCantDepositar.Text);
                numCuenta = txtNumCuenta.Text;
            }
            catch { }
            //Deposito dep = new Deposito(0, 0, "", "", null, monto, numCuenta);
            ConfirmacionDeposito form = new ConfirmacionDeposito(numCuenta, monto);
            form.Show();
            this.Close();
        }
    }
}
