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
    public partial class ConfirmacionDeposito : Form
    {
        private Deposito deposito;

        public ConfirmacionDeposito (Deposito deposito)
        {
            if (deposito.Tipo == Movimiento.Tipos.DEPOSITO)
            {
                InitializeComponent();
                btnContinuar.Enabled = false;
                AcceptButton = btAceptar;
                String numCuenta = deposito.NumCuenta;
                float monto = deposito.Monto;
                this.deposito = deposito;

                txtInformacion.Text = "Se realizará un depósito a la cuenta:" + Environment.NewLine + Environment.NewLine +
                                      numCuenta + Environment.NewLine + Environment.NewLine +
                                      "por la cantidad de:" + Environment.NewLine + Environment.NewLine +
                                      monto.ToString() + " MNX";
            }
            else
            {
                this.Close();
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            btAceptar.Enabled = false;
            DateTime fecha = DateTime.Now;
            deposito.Fecha = fecha.ToString("yyyy-MM-dd HH:mm:s");
            
            String query;
            DatabaseConnection.Connect();
            query = "INSERT INTO movimiento(claveTipoMovimiento, idCuentaOrigen, idCuentaDestino, fecha, monto )" +
                    "VALUES(" + (short)deposito.Tipo + "," + deposito.NumCuenta + "," + deposito.NumCuenta + ",'" + deposito.Fecha + "'," + deposito.Monto + ")";
            DatabaseConnection.Sql_string = query; //txtInformacion.Text += query;
            deposito.IdMovimiento = DatabaseConnection.ExecuteStatement();

            if (deposito.IdMovimiento >= 0)
            {
                float saldo = 0;
                txtIdTransaccion.Text = deposito.IdMovimiento.ToString();
                DatabaseConnection.Connect();
                query = "SELECT SUM(monto) FROM movimiento " +
                    "WHERE idCuentaDestino=" + deposito.NumCuenta;
                DatabaseConnection.Sql_string = query; //txtInformacion.Text += query;
                saldo = DatabaseConnection.ExecuteFloatReader();
                txtSaldo.Text = "$ " + saldo.ToString();
                MessageBox.Show("Depósito realizado correctamente");
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo realizar la transacción");
            }
            //DatabaseConnection.Close();
            btnContinuar.Enabled = true;
            AcceptButton = btnContinuar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
