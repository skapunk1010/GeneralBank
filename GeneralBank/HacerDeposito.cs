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
            if (txtNumCuenta.Text != "")
            {
                float monto = 0;
                String numCuenta = "";
                try
                {
                    monto = (float)Convert.ToDecimal(txtCantDepositar.Text);
                    numCuenta = txtNumCuenta.Text;
                }
                catch { }

                Deposito dep = new Deposito(monto);
                dep.NumCuenta = numCuenta;
                ConfirmacionDeposito form = new ConfirmacionDeposito(dep);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduzca un número de cuenta");
            }
        }
    }
}
