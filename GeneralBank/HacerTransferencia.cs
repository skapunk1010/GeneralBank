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
            txtCuentaOrigen.Focus();
            AcceptButton = btnValidar;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Connect();
            String query = "SELECT COUNT(idcuenta) FROM cuenta WHERE idcuenta = " + txtCuentaOrigen.Text + " OR idcuenta = " + txtCuentaDestino.Text;
            DatabaseConnection.Sql_string = query;
            short entry = (short)DatabaseConnection.ExecuteFloatReader();
            if (entry > 1)
            {
                groupBox1.Visible = true;
                txtCuentaOrigen.Enabled = false;
                txtCuentaDestino.Enabled = false;
                this.AcceptButton = btnAceptar;
                txtCantTransferir.Focus();
            }
            else
            {
                //txtCuentaOrigen.Text = query; txtCuentaDestino.Text = "(" + entry + ")";
                MessageBox.Show("Cuenta inválida ");
                groupBox1.Visible = false;
                txtCuentaOrigen.Enabled = true;
                txtCuentaDestino.Enabled = true;
                this.AcceptButton = btnValidar;
                txtCuentaOrigen.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCuentaOrigen.Text != "" && txtCuentaDestino.Text != "")
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
                catch { MessageBox.Show("Introduzca un monto válido"); }

                Transferencia tran = new Transferencia(monto, destino);
                tran.NumCuenta = numCuenta;
                tran.Tipo = Movimiento.Tipos.TRANSFERENCIA;

                ConfirmacionTransferencia form = new ConfirmacionTransferencia(tran);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduzca un número de cuenta de origen y uno de destino");
            }

        }
    }
}
