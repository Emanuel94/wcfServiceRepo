namespace ConsumiendoWCF_WForm
{
    partial class FormMedicamento
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
            this.dgMedicamento = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLbNuveo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLbEditar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLbEliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLBSalir = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMedicamento
            // 
            this.dgMedicamento.AllowUserToOrderColumns = true;
            this.dgMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedicamento.GridColor = System.Drawing.SystemColors.Info;
            this.dgMedicamento.Location = new System.Drawing.Point(0, 0);
            this.dgMedicamento.Name = "dgMedicamento";
            this.dgMedicamento.ReadOnly = true;
            this.dgMedicamento.RowHeadersWidth = 102;
            this.dgMedicamento.RowTemplate.Height = 40;
            this.dgMedicamento.Size = new System.Drawing.Size(1924, 851);
            this.dgMedicamento.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLbNuveo,
            this.toolStripLbEditar,
            this.toolStripLbEliminar,
            this.toolStripLBSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 62);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLbNuveo
            // 
            this.toolStripLbNuveo.Name = "toolStripLbNuveo";
            this.toolStripLbNuveo.Size = new System.Drawing.Size(105, 55);
            this.toolStripLbNuveo.Text = "Nuevo";
            this.toolStripLbNuveo.Click += new System.EventHandler(this.toolStripLbNuveo_Click);
            // 
            // toolStripLbEditar
            // 
            this.toolStripLbEditar.Name = "toolStripLbEditar";
            this.toolStripLbEditar.Size = new System.Drawing.Size(93, 55);
            this.toolStripLbEditar.Text = "Editar";
            this.toolStripLbEditar.Click += new System.EventHandler(this.toolStripLbEditar_Click);
            // 
            // toolStripLbEliminar
            // 
            this.toolStripLbEliminar.Name = "toolStripLbEliminar";
            this.toolStripLbEliminar.Size = new System.Drawing.Size(122, 55);
            this.toolStripLbEliminar.Text = "Eliminar";
            this.toolStripLbEliminar.Click += new System.EventHandler(this.toolStripLbEliminar_Click);
            // 
            // toolStripLBSalir
            // 
            this.toolStripLBSalir.Name = "toolStripLBSalir";
            this.toolStripLBSalir.Size = new System.Drawing.Size(73, 55);
            this.toolStripLBSalir.Text = "Salir";
            // 
            // FormMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 851);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgMedicamento);
            this.Name = "FormMedicamento";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedicamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedicamento;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLbNuveo;
        private System.Windows.Forms.ToolStripLabel toolStripLbEditar;
        private System.Windows.Forms.ToolStripLabel toolStripLbEliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLBSalir;
    }
}

