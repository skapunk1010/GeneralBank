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
            txtNumCuenta.Focus();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            String query = "SELECT COUNT(idcuenta) FROM cuenta WHERE idcuenta = " + txtNumCuenta.Text;
            DatabaseConnection.Sql_string = query;
            short entry = (short)DatabaseConnection.ExecuteFloatReader();
            if(entry > 0)
            {
                groupBox1.Visible = true;
                txtNumCuenta.Enabled = false;
                this.AcceptButton = btnAceptar;
                txtCantDepositar.Focus();
            }
            else
            {
                //txtNumCuenta.Text = query;
                MessageBox.Show("Cuenta inválida ");
                groupBox1.Visible = false;
                txtNumCuenta.Enabled = true;
                this.AcceptButton = btnValidar;
                txtNumCuenta.Focus();
            }
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
                dep.Tipo = Movimiento.Tipos.DEPOSITO;

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
