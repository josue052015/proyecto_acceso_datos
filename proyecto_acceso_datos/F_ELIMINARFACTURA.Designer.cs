namespace proyecto_acceso_datos
{
    partial class F_ELIMINARFACTURA
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
            this.TINFO = new System.Windows.Forms.TextBox();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVM = new System.Windows.Forms.DataGridView();
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.CODIGOO = new System.Windows.Forms.TextBox();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).BeginInit();
            this.SuspendLayout();
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(121, 233);
            this.TINFO.Margin = new System.Windows.Forms.Padding(6);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(208, 31);
            this.TINFO.TabIndex = 38;
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(373, 220);
            this.BBUSCAR.Margin = new System.Windows.Forms.Padding(6);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(212, 56);
            this.BBUSCAR.TabIndex = 37;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "BUSCAR FACTURA POR:";
            // 
            // DGVM
            // 
            this.DGVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVM.Location = new System.Drawing.Point(165, 532);
            this.DGVM.Margin = new System.Windows.Forms.Padding(6);
            this.DGVM.Name = "DGVM";
            this.DGVM.RowHeadersWidth = 82;
            this.DGVM.Size = new System.Drawing.Size(1316, 340);
            this.DGVM.TabIndex = 39;
            this.DGVM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVM_CellContentClick);
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(1570, 717);
            this.BCANCELAR.Margin = new System.Windows.Forms.Padding(6);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(150, 156);
            this.BCANCELAR.TabIndex = 41;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BELIMINAR.Location = new System.Drawing.Point(1570, 532);
            this.BELIMINAR.Margin = new System.Windows.Forms.Padding(6);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(150, 156);
            this.BELIMINAR.TabIndex = 40;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = false;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // CODIGOO
            // 
            this.CODIGOO.Enabled = false;
            this.CODIGOO.Location = new System.Drawing.Point(121, 233);
            this.CODIGOO.Margin = new System.Windows.Forms.Padding(6);
            this.CODIGOO.Name = "CODIGOO";
            this.CODIGOO.Size = new System.Drawing.Size(208, 31);
            this.CODIGOO.TabIndex = 42;
            this.CODIGOO.Visible = false;
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "NUMERO DE FACTURA",
            "CODIGO DE PROVEEDOR"});
            this.CBBUSCAR.Location = new System.Drawing.Point(121, 166);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(464, 33);
            this.CBBUSCAR.TabIndex = 43;
            // 
            // F_ELIMINARFACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 921);
            this.Controls.Add(this.CBBUSCAR);
            this.Controls.Add(this.CODIGOO);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.DGVM);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.label7);
            this.Name = "F_ELIMINARFACTURA";
            this.Text = "ELIMINAR FACTURA";
            this.Load += new System.EventHandler(this.F_ELIMINARFACTURA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVM;
        private System.Windows.Forms.Button BCANCELAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.TextBox CODIGOO;
        private System.Windows.Forms.ComboBox CBBUSCAR;
    }
}