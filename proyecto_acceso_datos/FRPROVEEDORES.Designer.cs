namespace proyecto_acceso_datos
{
    partial class FRPROVEEDORES
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pROVEEDORESPJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCXPPJDataSet = new proyecto_acceso_datos.SCXPPJDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sCXPPJDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEEDORESPJTableAdapter = new proyecto_acceso_datos.SCXPPJDataSetTableAdapters.PROVEEDORESPJTableAdapter();
            this.BREGRESAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESPJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXPPJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXPPJDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pROVEEDORESPJBindingSource
            // 
            this.pROVEEDORESPJBindingSource.DataMember = "PROVEEDORESPJ";
            this.pROVEEDORESPJBindingSource.DataSource = this.sCXPPJDataSet;
            // 
            // sCXPPJDataSet
            // 
            this.sCXPPJDataSet.DataSetName = "SCXPPJDataSet";
            this.sCXPPJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pROVEEDORESPJBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_acceso_datos.RPROVEEDORES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1570, 780);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sCXPPJDataSetBindingSource
            // 
            this.sCXPPJDataSetBindingSource.DataSource = this.sCXPPJDataSet;
            this.sCXPPJDataSetBindingSource.Position = 0;
            // 
            // pROVEEDORESPJTableAdapter
            // 
            this.pROVEEDORESPJTableAdapter.ClearBeforeFill = true;
            // 
            // BREGRESAR
            // 
            this.BREGRESAR.Location = new System.Drawing.Point(1365, 601);
            this.BREGRESAR.Name = "BREGRESAR";
            this.BREGRESAR.Size = new System.Drawing.Size(169, 142);
            this.BREGRESAR.TabIndex = 1;
            this.BREGRESAR.Text = "REGRESAR";
            this.BREGRESAR.UseVisualStyleBackColor = true;
            this.BREGRESAR.Click += new System.EventHandler(this.BREGRESAR_Click);
            // 
            // FRPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 780);
            this.Controls.Add(this.BREGRESAR);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRPROVEEDORES";
            this.Text = "REPORTE DE PROVEEDORES";
            this.Load += new System.EventHandler(this.FRPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESPJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXPPJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCXPPJDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SCXPPJDataSet sCXPPJDataSet;
        private System.Windows.Forms.BindingSource sCXPPJDataSetBindingSource;
        private System.Windows.Forms.BindingSource pROVEEDORESPJBindingSource;
        private SCXPPJDataSetTableAdapters.PROVEEDORESPJTableAdapter pROVEEDORESPJTableAdapter;
        private System.Windows.Forms.Button BREGRESAR;
    }
}