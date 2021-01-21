namespace proyecto_acceso_datos
{
    partial class FRESTADOCUENTAS
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
            this.ESTADODECUENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCXPPJDataSet5 = new proyecto_acceso_datos.SCXPPJDataSet5();
            this.ESTADODECUENTASTableAdapter = new proyecto_acceso_datos.SCXPPJDataSet5TableAdapters.ESTADODECUENTASTableAdapter();
            this.chequespjTableAdapter1 = new proyecto_acceso_datos.SCXPPJDataSetTableAdapters.CHEQUESPJTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SCXPPJDataSet6 = new proyecto_acceso_datos.SCXPPJDataSet6();
            this.CHEQUESPJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHEQUESPJTableAdapter = new proyecto_acceso_datos.SCXPPJDataSet6TableAdapters.CHEQUESPJTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ESTADODECUENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESPJBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ESTADODECUENTASBindingSource
            // 
            this.ESTADODECUENTASBindingSource.DataMember = "ESTADODECUENTAS";
            this.ESTADODECUENTASBindingSource.DataSource = this.SCXPPJDataSet5;
            // 
            // SCXPPJDataSet5
            // 
            this.SCXPPJDataSet5.DataSetName = "SCXPPJDataSet5";
            this.SCXPPJDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ESTADODECUENTASTableAdapter
            // 
            this.ESTADODECUENTASTableAdapter.ClearBeforeFill = true;
            // 
            // chequespjTableAdapter1
            // 
            this.chequespjTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHEQUESPJBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_acceso_datos.restadocuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1779, 935);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SCXPPJDataSet6
            // 
            this.SCXPPJDataSet6.DataSetName = "SCXPPJDataSet6";
            this.SCXPPJDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHEQUESPJBindingSource
            // 
            this.CHEQUESPJBindingSource.DataMember = "CHEQUESPJ";
            this.CHEQUESPJBindingSource.DataSource = this.SCXPPJDataSet6;
            // 
            // CHEQUESPJTableAdapter
            // 
            this.CHEQUESPJTableAdapter.ClearBeforeFill = true;
            // 
            // FRESTADOCUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 935);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRESTADOCUENTAS";
            this.Text = "REPORTE ESTADOCUENTAS";
            this.Load += new System.EventHandler(this.FRESTADOCUENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ESTADODECUENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESPJBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ESTADODECUENTASBindingSource;
        private SCXPPJDataSet5 SCXPPJDataSet5;
        private SCXPPJDataSet5TableAdapters.ESTADODECUENTASTableAdapter ESTADODECUENTASTableAdapter;
        private SCXPPJDataSetTableAdapters.CHEQUESPJTableAdapter chequespjTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHEQUESPJBindingSource;
        private SCXPPJDataSet6 SCXPPJDataSet6;
        private SCXPPJDataSet6TableAdapters.CHEQUESPJTableAdapter CHEQUESPJTableAdapter;
    }
}