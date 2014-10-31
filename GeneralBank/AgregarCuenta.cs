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
    public partial class AgregarCuenta : Form
    {
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumCuenta.Text = "";
            txtEmpleado.Text = "";
            txtSucursal.Text = "";
            dropTipoCuenta.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String numCuenta = txtNumCuenta.Text;
            String empleado = txtEmpleado.Text;
            String sucursal = txtSucursal.Text;
            String tipoCuenta = dropTipoCuenta.SelectedValue.ToString();

            //Validar datos
            //Validar cliente
            //Insertar
        }
    }
}
