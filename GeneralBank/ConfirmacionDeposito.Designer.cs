namespace GeneralBank
{
    partial class ConfirmacionDeposito
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
            this.txtInformacion = new System.Windows.Forms.RichTextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtIdTransaccion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblIdTransaccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(39, 38);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(371, 132);
            this.txtInformacion.TabIndex = 0;
            this.txtInformacion.Text = "";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(335, 200);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(277, 257);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(133, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.Enabled = false;
            this.txtIdTransaccion.Location = new System.Drawing.Point(277, 297);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.Size = new System.Drawing.Size(133, 20);
            this.txtIdTransaccion.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(140, 260);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(131, 13);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo actual de la cuenta:";
            // 
            // lblIdTransaccion
            // 
            this.lblIdTransaccion.AutoSize = true;
            this.lblIdTransaccion.Location = new System.Drawing.Point(179, 300);
            this.lblIdTransaccion.Name = "lblIdTransaccion";
            this.lblIdTransaccion.Size = new System.Drawing.Size(92, 13);
            this.lblIdTransaccion.TabIndex = 6;
            this.lblIdTransaccion.Text = "Id de transacción:";
            // 
            // ConfirmacionDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 380);
            this.Controls.Add(this.lblIdTransaccion);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtIdTransaccion);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtInformacion);
            this.Name = "ConfirmacionDeposito";
            this.Text = "Confirmación de Depósito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInformacion;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtIdTransaccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblIdTransaccion;
    }
}