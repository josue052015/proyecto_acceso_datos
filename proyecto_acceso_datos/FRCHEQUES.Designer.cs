namespace proyecto_acceso_datos
{
    partial class FRCHEQUES
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
            this.CHEQUESPJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCXPPJDataSet4 = new proyecto_acceso_datos.SCXPPJDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHEQUESPJTableAdapter = new proyecto_acceso_datos.SCXPPJDataSet4TableAdapters.CHEQUESPJTableAdapter();
            this.BREGRESAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESPJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // CHEQUESPJBindingSource
            // 
            this.CHEQUESPJBindingSource.DataMember = "CHEQUESPJ";
            this.CHEQUESPJBindingSource.DataSource = this.SCXPPJDataSet4;
            // 
            // SCXPPJDataSet4
            // 
            this.SCXPPJDataSet4.DataSetName = "SCXPPJDataSet4";
            this.SCXPPJDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHEQUESPJBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_acceso_datos.RCHEQUES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1499, 757);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CHEQUESPJTableAdapter
            // 
            this.CHEQUESPJTableAdapter.ClearBeforeFill = true;
            // 
            // BREGRESAR
            // 
            this.BREGRESAR.Location = new System.Drawing.Point(1308, 642);
            this.BREGRESAR.Name = "BREGRESAR";
            this.BREGRESAR.Size = new System.Drawing.Size(179, 94);
            this.BREGRESAR.TabIndex = 1;
            this.BREGRESAR.Text = "REGRESAR";
            this.BREGRESAR.UseVisualStyleBackColor = true;
            this.BREGRESAR.Click += new System.EventHandler(this.BREGRESAR_Click);
            // 
            // FRCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 757);
            this.Controls.Add(this.BREGRESAR);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRCHEQUES";
            this.Text = "REPORTE DE CHEQUES";
            this.Load += new System.EventHandler(this.FRCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHEQUESPJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCXPPJDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHEQUESPJBindingSource;
        private SCXPPJDataSet4 SCXPPJDataSet4;
        private SCXPPJDataSet4TableAdapters.CHEQUESPJTableAdapter CHEQUESPJTableAdapter;
        private System.Windows.Forms.Button BREGRESAR;
    }
}