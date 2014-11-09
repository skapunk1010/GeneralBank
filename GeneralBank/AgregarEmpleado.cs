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
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
            anhoNacimiento.Value = 2000;
            anhoIngreso.Value = 2000;
            dropTipoTelefono.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            comboPuesto.SelectedIndex = 0;
            radioMatutino.Checked = true;
            radioMasculino.Checked = true;

            String query = "SELECT idSucursal FROM Sucursal";
            DatabaseConnection.Sql_string = query;
            DatabaseConnection.ExecuteReader();
            if (DatabaseConnection.ArrayResult != null) {
                List<String> resultado = DatabaseConnection.ArrayResult;
                List<ComboBoxItem> items = new List<ComboBoxItem>();
                foreach(String indice in resultado){
                    items.Add(new ComboBoxItem(indice, Convert.ToInt32(indice)));
                }
                comboSucursal.DisplayMember = "Name";
                comboSucursal.ValueMember = "Value";
                comboSucursal.DataSource = items;
                comboSucursal.SelectedIndex = 0;
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
            anhoNacimiento.Value = 2000;
            radioMasculino.Checked = true;
            txtNss.Text = "";
            txtRfc.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
            txtLada.Text = "";
            dropTipoTelefono.SelectedIndex = 0;
            txtCalle.Text = "";
            txtNumExterior.Text = "";
            txtNumInterior.Text = "";
            txtCp.Text = "";
            txtColonia.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            diaIngreso.Value = 1;
            mesIngreso.Value = 1;
            anhoIngreso.Value = 2000;
            numericSueldo.Value = 0;
            comboStatus.SelectedIndex = 0;
            comboPuesto.SelectedIndex = 0;
            radioMatutino.Checked = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellidoPaterno.Text) || String.IsNullOrEmpty(txtCalle.Text) || 
                String.IsNullOrEmpty(txtColonia.Text)|| String.IsNullOrEmpty(txtCiudad.Text) || String.IsNullOrEmpty(txtEstado.Text) ||
                String.IsNullOrEmpty(txtLada.Text)   || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe de llenar todos los campos requeridos!");
            }else{
                String nombre = txtNombre.Text;
                String apellidoPaterno = txtApellidoPaterno.Text;
                String apellidoMaterno = txtApellidoMaterno.Text;
                String diaNac = diaNacimiento.Value.ToString();
                String mesNac = mesNacimiento.Value.ToString();
                String anhoNac = anhoNacimiento.Value.ToString();
                //Sexo
                String nss = txtNss.Text;
                String rfc = txtRfc.Text;
                String curp = txtCurp.Text;
                String ladaTel = txtLada.Text;
                String telefono = txtTelefono.Text;
                String calle = txtCalle.Text;
                int numExterior = Convert.ToInt32(txtNumExterior.Text);
                String numInterior = txtNumInterior.Text;
                String cp = txtCp.Text;
                String colonia = txtColonia.Text;
                String ciudad = txtCiudad.Text;
                String estado = txtEstado.Text;

                int idSucursal = Convert.ToInt32(comboSucursal.SelectedValue.ToString());
                String diaIngresoString = diaIngreso.Value.ToString();
                String mesIngresoString = mesIngreso.Value.ToString();
                String anhoIngresoString = anhoIngreso.Value.ToString();
                float sueldo = (float)Convert.ToDouble(numericSueldo.Value.ToString());
                String status = comboStatus.SelectedItem.ToString();
                String puesto = comboPuesto.SelectedItem.ToString();
                String horario = "";
                if (radioMatutino.Checked){
                    horario = "M";
                }else if(radioVespertino.Checked){
                    horario = "V";
                }

                String query =  "INSERT INTO Empleado(idSucursal, nombre, apellidoPaterno,apellidoMaterno, fechaNacimiento, fechaIngreso,"+
                                "nss, rfc, sueldo, curp, status, puesto, horario) VALUES("+idSucursal+", '"+nombre+"','"+apellidoPaterno+"','"+apellidoMaterno+"',"+
                                "'" + anhoNac + "-" + mesNac + "-" + diaNac + "','" + anhoIngresoString + "-" + mesIngresoString + "-" + diaIngresoString + "', '" + nss + "','" + rfc + "'," +
                                ""+sueldo+", '"+curp+"','"+status+"','"+puesto+"','"+horario+"')";
                
                DatabaseConnection.Sql_string = query;
                int idEmpleado = DatabaseConnection.ExecuteStatement();
                if (idEmpleado == 0) {
                    MessageBox.Show("Hubo algún error al insertar el empleado");
                    return;
                }
                query = "INSERT INTO Telefono(idEmpleado, lada, telefono) VALUES ("+idEmpleado+", '"+ladaTel+"','"+telefono+"')";
                DatabaseConnection.Sql_string = query;
                int idTelefono = DatabaseConnection.ExecuteStatement();
                if (idTelefono == 0) {
                    MessageBox.Show("Hubo algún error al insertar el telefono");
                    return;
                }
                query = "INSERT INTO Domicilio(idEmpleado, calle, numeroExterior, numeroInterior, colonia, codigoPostal, ciudad, estado) VALUES(" +
                        ""+idEmpleado+",'"+calle+"', "+numExterior+",'"+numInterior+"','"+colonia+"','"+cp+"','"+ciudad+"','"+estado+"')";
                DatabaseConnection.Sql_string = query;
                int idDomicilio = DatabaseConnection.ExecuteStatement();
                if (idDomicilio == 0) {
                    MessageBox.Show("Hubo algún error al insertar el domicilio del empleado.");
                    return;
                }
                btnLimpiar_Click(sender, e);
                MessageBox.Show("Empleado insertado correctamente!");
            }
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

        private void txtNss_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtLada_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNumExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == '.');
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNumInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-');
        }
    }
}
