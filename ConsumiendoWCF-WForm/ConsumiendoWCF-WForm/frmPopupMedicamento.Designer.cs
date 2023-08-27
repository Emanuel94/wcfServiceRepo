namespace ConsumiendoWCF_WForm
{
    partial class frmPopupMedicamento
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
            this.lbiDMedicamento = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFormaFarmaceutica = new System.Windows.Forms.Label();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbStock = new System.Windows.Forms.Label();
            this.lbPresentacion = new System.Windows.Forms.Label();
            this.txtIMedicamento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtConcentracion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.cbFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbiDMedicamento
            // 
            this.lbiDMedicamento.AutoSize = true;
            this.lbiDMedicamento.Location = new System.Drawing.Point(67, 57);
            this.lbiDMedicamento.Name = "lbiDMedicamento";
            this.lbiDMedicamento.Size = new System.Drawing.Size(215, 32);
            this.lbiDMedicamento.TabIndex = 0;
            this.lbiDMedicamento.Text = "Id Medicamento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(67, 142);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(114, 32);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concentración";
            // 
            // lbFormaFarmaceutica
            // 
            this.lbFormaFarmaceutica.AutoSize = true;
            this.lbFormaFarmaceutica.Location = new System.Drawing.Point(67, 292);
            this.lbFormaFarmaceutica.Name = "lbFormaFarmaceutica";
            this.lbFormaFarmaceutica.Size = new System.Drawing.Size(274, 32);
            this.lbFormaFarmaceutica.TabIndex = 3;
            this.lbFormaFarmaceutica.Text = "Forma Farmaceutica";
            // 
            // LbPrecio
            // 
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(67, 368);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(95, 32);
            this.LbPrecio.TabIndex = 4;
            this.LbPrecio.Text = "Precio";
            // 
            // LbStock
            // 
            this.LbStock.AutoSize = true;
            this.LbStock.Location = new System.Drawing.Point(67, 439);
            this.LbStock.Name = "LbStock";
            this.LbStock.Size = new System.Drawing.Size(85, 32);
            this.LbStock.TabIndex = 5;
            this.LbStock.Text = "Stock";
            // 
            // lbPresentacion
            // 
            this.lbPresentacion.AutoSize = true;
            this.lbPresentacion.Location = new System.Drawing.Point(67, 513);
            this.lbPresentacion.Name = "lbPresentacion";
            this.lbPresentacion.Size = new System.Drawing.Size(181, 32);
            this.lbPresentacion.TabIndex = 6;
            this.lbPresentacion.Text = "Presentacion";
            // 
            // txtIMedicamento
            // 
            this.txtIMedicamento.Location = new System.Drawing.Point(390, 57);
            this.txtIMedicamento.Name = "txtIMedicamento";
            this.txtIMedicamento.ReadOnly = true;
            this.txtIMedicamento.Size = new System.Drawing.Size(436, 38);
            this.txtIMedicamento.TabIndex = 7;
            this.txtIMedicamento.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(390, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 38);
            this.txtNombre.TabIndex = 8;
            // 
            // txtConcentracion
            // 
            this.txtConcentracion.Location = new System.Drawing.Point(390, 211);
            this.txtConcentracion.Name = "txtConcentracion";
            this.txtConcentracion.Size = new System.Drawing.Size(436, 38);
            this.txtConcentracion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(390, 362);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(436, 38);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDecimales);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(390, 436);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(436, 38);
            this.txtStock.TabIndex = 12;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressStock);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(390, 507);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(436, 38);
            this.txtPresentacion.TabIndex = 13;
            // 
            // cbFormaFarmaceutica
            // 
            this.cbFormaFarmaceutica.FormattingEnabled = true;
            this.cbFormaFarmaceutica.Location = new System.Drawing.Point(390, 285);
            this.cbFormaFarmaceutica.Name = "cbFormaFarmaceutica";
            this.cbFormaFarmaceutica.Size = new System.Drawing.Size(436, 39);
            this.cbFormaFarmaceutica.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(620, 646);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 63);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(194, 646);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(169, 63);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmPopupMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 853);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbFormaFarmaceutica);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtConcentracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIMedicamento);
            this.Controls.Add(this.lbPresentacion);
            this.Controls.Add(this.LbStock);
            this.Controls.Add(this.LbPrecio);
            this.Controls.Add(this.lbFormaFarmaceutica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbiDMedicamento);
            this.Name = "frmPopupMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopupMedicamento";
            this.Load += new System.EventHandler(this.frmPopupMedicamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbiDMedicamento;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFormaFarmaceutica;
        private System.Windows.Forms.Label LbPrecio;
        private System.Windows.Forms.Label LbStock;
        private System.Windows.Forms.Label lbPresentacion;
        private System.Windows.Forms.TextBox txtIMedicamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.ComboBox cbFormaFarmaceutica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}