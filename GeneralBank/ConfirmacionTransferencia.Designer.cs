namespace GeneralBank
{
    partial class ConfirmacionTransferencia
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtIdTransaccion = new System.Windows.Forms.TextBox();
            this.lblIdTransaccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(36, 33);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.Size = new System.Drawing.Size(379, 154);
            this.txtInformacion.TabIndex = 0;
            this.txtInformacion.Text = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(340, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(340, 291);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.Enabled = false;
            this.txtIdTransaccion.Location = new System.Drawing.Point(277, 250);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.Size = new System.Drawing.Size(138, 20);
            this.txtIdTransaccion.TabIndex = 3;
            // 
            // lblIdTransaccion
            // 
            this.lblIdTransaccion.AutoSize = true;
            this.lblIdTransaccion.Location = new System.Drawing.Point(187, 253);
            this.lblIdTransaccion.Name = "lblIdTransaccion";
            this.lblIdTransaccion.Size = new System.Drawing.Size(84, 13);
            this.lblIdTransaccion.TabIndex = 4;
            this.lblIdTransaccion.Text = "Id. Transacción:";
            // 
            // ConfirmacionTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 336);
            this.Controls.Add(this.lblIdTransaccion);
            this.Controls.Add(this.txtIdTransaccion);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtInformacion);
            this.MaximumSize = new System.Drawing.Size(470, 375);
            this.MinimumSize = new System.Drawing.Size(470, 375);
            this.Name = "ConfirmacionTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInformacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtIdTransaccion;
        private System.Windows.Forms.Label lblIdTransaccion;
    }
}