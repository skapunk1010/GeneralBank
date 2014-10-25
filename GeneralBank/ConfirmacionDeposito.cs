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
    public partial class ConfirmacionDeposito : Form
    {
        private String numCuenta;
        private float monto;

        public ConfirmacionDeposito(String cuenta, float monto)
        {
            InitializeComponent();
            this.numCuenta = cuenta;
            this.monto = monto;

            txtInformacion.Text = "Se realizará un depósito a la cuenta:" + Environment.NewLine + Environment.NewLine +
                                  numCuenta + Environment.NewLine + Environment.NewLine +
                                  "por la cantidad de:" + Environment.NewLine + Environment.NewLine +
                                  monto.ToString() + " MNX";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //cuenta.Saldo += monto;
            //txtSaldo.Text = cuenta.Saldo;
            //txtInformacion = movimiento.Id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
