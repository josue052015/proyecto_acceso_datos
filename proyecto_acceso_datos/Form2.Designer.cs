namespace proyecto_acceso_datos
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FACTURASPJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCXPPJDataSet1 = new proyecto_acceso_datos.SCXPPJDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FACTURASPJTableAdapter = new proyecto_acceso_datos.SCXPPJDataSet1TableAdapters.FACTURASPJTableAdapter();
            this.FREGRESAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FACTURASPJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // FACTURASPJBindingSource
            // 
            this.FACTURASPJBindingSource.DataMember = "FACTURASPJ";
            this.FACTURASPJBindingSource.DataSource = this.SCXPPJDataSet1;
            // 
            // SCXPPJDataSet1
            // 
            this.SCXPPJDataSet1.DataSetName = "SCXPPJDataSet1";
            this.SCXPPJDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FACTURASPJBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_acceso_datos.RFACTURA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1631, 837);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FACTURASPJTableAdapter
            // 
            this.FACTURASPJTableAdapter.ClearBeforeFill = true;
            // 
            // FREGRESAR
            // 
            this.FREGRESAR.Location = new System.Drawing.Point(1409, 690);
            this.FREGRESAR.Name = "FREGRESAR";
            this.FREGRESAR.Size = new System.Drawing.Size(167, 106);
            this.FREGRESAR.TabIndex = 1;
            this.FREGRESAR.Text = "REGRESAR";
            this.FREGRESAR.UseVisualStyleBackColor = true;
            this.FREGRESAR.Click += new System.EventHandler(this.FREGRESAR_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 837);
            this.Controls.Add(this.FREGRESAR);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "REPORTE DE FACTURAS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FACTURASPJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FACTURASPJBindingSource;
        private SCXPPJDataSet1 SCXPPJDataSet1;
        private SCXPPJDataSet1TableAdapters.FACTURASPJTableAdapter FACTURASPJTableAdapter;
        private System.Windows.Forms.Button FREGRESAR;
    }
}