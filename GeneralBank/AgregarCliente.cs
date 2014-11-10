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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
            dropTipoTelefono.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellidoPaterno.Text) || String.IsNullOrEmpty(txtApellidoMaterno.Text) ||
                String.IsNullOrEmpty(txtCalle.Text)  || String.IsNullOrEmpty(txtCiudad.Text) || String.IsNullOrEmpty(txtColonia.Text) ||
                String.IsNullOrEmpty(txtEstado.Text) || String.IsNullOrEmpty(txtNumExterior.Text))
            {
                MessageBox.Show("Es necesario llenar los campos requeridos");
            }
            else {
                String nombre           = txtNombre.Text;
                String apellidoPaterno  = txtApellidoPaterno.Text;
                String apellidoMaterno  = txtApellidoMaterno.Text;
                String dia              = diaNacimiento.Value.ToString();
                String mes              = mesNacimiento.Value.ToString();
                String anho             = anhoNacimiento.Value.ToString();
                String nss              = txtNss.Text;
                String rfc              = txtRfc.Text;
                String ladaTelefono     = txtLada.Text;
                String telefono         = txtTelefono.Text;
                String tipoTel          = dropTipoTelefono.SelectedItem.ToString();
                String calle            = txtCalle.Text;
                String numExterior      = txtNumExterior.Text;
                String numInterior      = txtNumInterior.Text;
                String cp               = txtCp.Text;
                String colonia          = txtColonia.Text;
                String ciudad           = txtCiudad.Text;
                String estado           = txtEstado.Text;
            
                String query = "INSERT INTO Cliente(nombre,apellidoPaterno,apellidoMaterno, nss, rfc, fechaNacimiento)"+ 
                    "VALUES('"+nombre+"','"+apellidoPaterno+"','"+apellidoMaterno+"','"+nss+"','"+rfc+"','"+anho+"-"+mes+"-"+dia+"')";
                DatabaseConnection.Sql_string = query;
                int idCliente =  DatabaseConnection.ExecuteStatement();
                if (idCliente == 0) {
                    MessageBox.Show("Error al insertar el cliente");
                    return;
                }
                query = "INSERT INTO Domicilio(idCliente,calle, numeroExterior, numeroInterior, colonia, codigoPostal, ciudad, estado )"+
                        "VALUES(" + idCliente + ",'" + calle + "'," + numExterior + ",'" + numInterior + "','"+colonia+"','"+cp+"','"+ciudad+"','"+estado+"')";
                DatabaseConnection.Sql_string = query;
                int idDomicilio = DatabaseConnection.ExecuteStatement();
                if (idDomicilio == 0) {
                    MessageBox.Show("Error al insertar el domicilio");
                    return;
                }
                query = "INSERT INTO Telefono(idCliente, lada, telefono, tipoTelefono)"+ 
                        "VALUES("+idCliente+",'"+ladaTelefono+"','"+telefono+"','"+tipoTel+"');";
                DatabaseConnection.Sql_string = query;
                int idTelefono = DatabaseConnection.ExecuteStatement();
                if (idTelefono == 0) {
                    MessageBox.Show("Error al insertar el telefono");
                    return;
                }
                btnLimpiar_Click(sender, e);
                MessageBox.Show("Cliente insertado de forma correcta!");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MenuPrincipal().Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            diaNacimiento.Value = 1;
            mesNacimiento.Value = 1;
            anhoNacimiento.Value = 1950;
            txtRfc.Text = "";
            txtNss.Text = "";
            txtLada.Text = "";
            txtTelefono.Text = "";
            dropTipoTelefono.SelectedIndex = 0;
            txtCalle.Text = "";
            txtNumExterior.Text = "";
            txtNumInterior.Text = "";
            txtColonia.Text = "";
            txtEstado.Text = "";
            txtCp.Text = "";
            txtCiudad.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.');
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.');
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.');
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back);
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Back);
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtLada_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
