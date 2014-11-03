namespace GeneralBank
{
    partial class AgregarSucursal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.lblCp = new System.Windows.Forms.Label();
            this.txtNumInterior = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblNumInterior = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumExterior = new System.Windows.Forms.TextBox();
            this.lblNumExterior = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.lblTelefono);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.txtColonia);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.lblColonia);
            this.groupBox2.Controls.Add(this.txtCp);
            this.groupBox2.Controls.Add(this.lblCp);
            this.groupBox2.Controls.Add(this.txtNumInterior);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.lblNumInterior);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Controls.Add(this.txtNumExterior);
            this.groupBox2.Controls.Add(this.lblNumExterior);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 197);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(414, 146);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(313, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(92, 100);
            this.txtEstado.MaxLength = 30;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado: *";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(294, 100);
            this.txtTelefono.MaxLength = 13;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(215, 103);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(488, 61);
            this.txtCiudad.MaxLength = 30;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 6;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(92, 61);
            this.txtColonia.MaxLength = 30;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 20);
            this.txtColonia.TabIndex = 4;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(409, 64);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(50, 13);
            this.lblCiudad.TabIndex = 17;
            this.lblCiudad.Text = "Ciudad: *";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(13, 64);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(52, 13);
            this.lblColonia.TabIndex = 13;
            this.lblColonia.Text = "Colonia: *";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(294, 61);
            this.txtCp.MaxLength = 5;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(100, 20);
            this.txtCp.TabIndex = 5;
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(215, 64);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(37, 13);
            this.lblCp.TabIndex = 15;
            this.lblCp.Text = "C.P.: *";
            // 
            // txtNumInterior
            // 
            this.txtNumInterior.Location = new System.Drawing.Point(488, 19);
            this.txtNumInterior.MaxLength = 6;
            this.txtNumInterior.Name = "txtNumInterior";
            this.txtNumInterior.Size = new System.Drawing.Size(100, 20);
            this.txtNumInterior.TabIndex = 3;
            this.txtNumInterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumInterior_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(92, 19);
            this.txtCalle.MaxLength = 45;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 1;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // lblNumInterior
            // 
            this.lblNumInterior.AutoSize = true;
            this.lblNumInterior.Location = new System.Drawing.Point(409, 22);
            this.lblNumInterior.Name = "lblNumInterior";
            this.lblNumInterior.Size = new System.Drawing.Size(67, 13);
            this.lblNumInterior.TabIndex = 11;
            this.lblNumInterior.Text = "Num.Interior:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(13, 22);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(40, 13);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "Calle: *";
            // 
            // txtNumExterior
            // 
            this.txtNumExterior.Location = new System.Drawing.Point(294, 19);
            this.txtNumExterior.MaxLength = 4;
            this.txtNumExterior.Name = "txtNumExterior";
            this.txtNumExterior.Size = new System.Drawing.Size(100, 20);
            this.txtNumExterior.TabIndex = 2;
            this.txtNumExterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExterior_KeyPress);
            // 
            // lblNumExterior
            // 
            this.lblNumExterior.AutoSize = true;
            this.lblNumExterior.Location = new System.Drawing.Point(211, 22);
            this.lblNumExterior.Name = "lblNumExterior";
            this.lblNumExterior.Size = new System.Drawing.Size(77, 13);
            this.lblNumExterior.TabIndex = 9;
            this.lblNumExterior.Text = "Num.Exterior: *";
            // 
            // AgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 230);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(662, 268);
            this.MinimumSize = new System.Drawing.Size(662, 268);
            this.Name = "AgregarSucursal";
            this.Text = "Agregar Sucursal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox txtNumInterior;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblNumInterior;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumExterior;
        private System.Windows.Forms.Label lblNumExterior;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;

    }
}