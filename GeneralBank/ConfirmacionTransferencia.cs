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
    public partial class ConfirmacionTransferencia : Form
    {
        private Transferencia transferencia;

        public ConfirmacionTransferencia(Transferencia tran)
        {
            if (tran.Tipo == Movimiento.Tipos.TRANSFERENCIA)
            {
                InitializeComponent();
                btnContinuar.Enabled = false;
                AcceptButton = btnAceptar;
                this.transferencia = tran;
                String origen = transferencia.NumCuenta;
                String destino = transferencia.NumCuentaDestino;
                float monto = transferencia.Monto;

                txtInformacion.Text = "Se realizará una transferencia de la cuenta:" + Environment.NewLine + Environment.NewLine +
                                      origen + Environment.NewLine + Environment.NewLine +
                                      "A la cuenta:" + Environment.NewLine + Environment.NewLine +
                                      destino + Environment.NewLine + Environment.NewLine +
                                      "por la cantidad de:" + Environment.NewLine + Environment.NewLine +
                                      monto.ToString() + " MNX";
            }
            else
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            DateTime fecha = DateTime.Now;
            transferencia.Fecha = fecha.ToString("yyyy-MM-dd HH:mm:s");

            String query;
            DatabaseConnection.Connect();
            query = "INSERT INTO movimiento(claveTipoMovimiento, idCuentaOrigen, idCuentaDestino, fecha, monto )" +
                    "VALUES(" + (short)transferencia.Tipo + "," + transferencia.NumCuenta + "," + transferencia.NumCuenta + ",'" + transferencia.Fecha + "'," + "-"+transferencia.Monto + ")";
            DatabaseConnection.Sql_string = query;
            transferencia.IdMovimiento = DatabaseConnection.ExecuteStatement();

            DatabaseConnection.Connect();
            query = "INSERT INTO movimiento(claveTipoMovimiento, idCuentaOrigen, idCuentaDestino, fecha, monto )" +
                    "VALUES(" + (short)transferencia.Tipo + "," + transferencia.NumCuenta + "," + transferencia.NumCuentaDestino + ",'" + transferencia.Fecha + "'," + transferencia.Monto + ")";
            DatabaseConnection.Sql_string = query;
            transferencia.IdMovimiento = DatabaseConnection.ExecuteStatement();

            if (transferencia.IdMovimiento >= 0)
            {
                txtIdTransaccion.Text = transferencia.IdMovimiento.ToString();
                MessageBox.Show("Transferencia realizada correctamente");
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo realizar la transacción");
            }
            //DatabaseConnection.Close();
            btnContinuar.Enabled = true;
            AcceptButton = btnContinuar;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
