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
    public partial class AgregarSucursal : Form
    {
        public AgregarSucursal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCalle.Text = "";
            txtNumExterior.Text = "";
            txtNumInterior.Text = "";
            txtColonia.Text = "";
            txtCp.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MenuPrincipal().Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCalle.Text) || String.IsNullOrEmpty(txtNumExterior.Text) ||
                String.IsNullOrEmpty(txtCiudad.Text) || String.IsNullOrEmpty(txtColonia.Text) ||
                String.IsNullOrEmpty(txtEstado.Text) || String.IsNullOrEmpty(txtCp.Text))
            {
                MessageBox.Show("Es necesario llenar todos los campos marcados con * ");
            } else {
                String calle        = txtCalle.Text;
                int numExterior     = Convert.ToInt16(txtNumExterior.Text);
                String numInterior  = txtNumInterior.Text;
                String colonia      = txtColonia.Text;
                String ciudad       = txtCiudad.Text;
                String cp           = txtCp.Text;
                String estado       = txtEstado.Text;
                String telefono     = txtTelefono.Text;

                String query = "INSERT INTO Sucursal(calle,numeroExterior,numeroInterior,ciudad,colonia,estado,cp,telefono) "+
                    "VALUES('"+calle+"',"+numExterior+",'"+numInterior+"','"+ciudad+"','"+colonia+"','"+estado+"','"+cp+"','"+telefono+"')";
                DatabaseConnection.Sql_string = query;
                int idSucursal = DatabaseConnection.ExecuteStatement();
                if (idSucursal == 0) {
                    MessageBox.Show("Error al insertar la sucursal");
                    return;
                }
                btnLimpiar_Click(sender, e);
                MessageBox.Show("Sucursal insertada correctamente!");
            }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.' || e.KeyChar == '#');
        }

        private void txtNumExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back);
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Back);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
