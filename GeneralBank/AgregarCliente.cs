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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatabaseConnection.Connect();
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
                "VALUES('"+nombre+"','"+apellidoPaterno+"','"+apellidoMaterno+"','"+nss+"','"+rfc+"','"+dia+"-"+mes+"-"+anho+"')";
            DatabaseConnection.Connect();
            int idCliente =  DatabaseConnection.ExecuteStatement(query);
            query = "INSERT INTO Domicilio(idCliente,calle, numeroExterior, numeroInterior, codigoPostal, ciudad, estado )"+
                    "VALUES(" + idCliente + ",'" + calle + "','" + numExterior + "','" + numInterior + "','"+cp+"','"+ciudad+"','"+estado+"')";
            query = "INSERT INTO Telefono(idCliente, lada, telefono, tipoTelefono)"+ 
                    "VALUES("+idCliente+",'"+ladaTelefono+"','"+telefono+"','"+tipoTel+"');";
            DatabaseConnection.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            txtLada.Text = "";
            dropTipoTelefono.SelectedIndex = 0;
            txtCalle.Text = "";
            txtNumExterior.Text = "";
            txtNumInterior.Text = "";
            txtColonia.Text = "";
            txtEstado.Text = "";
        }
    }
}
