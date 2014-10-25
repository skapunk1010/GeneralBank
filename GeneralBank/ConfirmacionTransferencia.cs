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
    public partial class ConfirmacionTransferencia : Form
    {
        private String origen, destino;
        private float monto;

        public ConfirmacionTransferencia(String origen, String destino, float monto)
        {
            InitializeComponent();
            this.origen = origen;
            this.destino = destino;
            this.monto = monto;

            txtInformacion.Text = "Se realizará una transferencia de la cuenta:" + Environment.NewLine + Environment.NewLine +
                                  origen + Environment.NewLine + Environment.NewLine +
                                  "A la cuenta:" + Environment.NewLine + Environment.NewLine +
                                  destino + Environment.NewLine + Environment.NewLine +
                                  "por la cantidad de:" + Environment.NewLine + Environment.NewLine +
                                  monto.ToString() + " MNX";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
