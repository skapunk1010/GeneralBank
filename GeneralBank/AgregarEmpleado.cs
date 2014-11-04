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
            if()
            {
            }else{
                String nombre = txtNombre.Text;
                String apellidoPaterno = txtApellidoPaterno.Text;
                String apellidoMaterno = txtApellidoMaterno.Text;
                String diaNacimiento = diaNacimiento.Value.toString();
                String mesNacimiento = mesNacimiento.Value.toString();
                String anhoNacimiento = anhoNacimiento.Value.toString();
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

                String diaIngreso = diaIngreso.Value.toString();
                String mesIngreso = mesIngreso.Value.toString();
                String anhoIngreso = anhoIngreso.Value.toString();
                float sueldo = (float)Convert.ToDouble(numericSueldo.Value.ToString());
                String status = comboStatus.SelectedValue.ToString();
                String puesto = comboPuesto.SelectedValue.ToString();

            }
        }
    }
}
