namespace proyecto_acceso_datos
{
    partial class FFACTURAS
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
            this.DGVFA = new System.Windows.Forms.DataGridView();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            this.TINFO = new System.Windows.Forms.TextBox();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.BREGRESAR = new System.Windows.Forms.Button();
            this.BREFRESCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFA
            // 
            this.DGVFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFA.Location = new System.Drawing.Point(65, 59);
            this.DGVFA.Name = "DGVFA";
            this.DGVFA.RowHeadersWidth = 82;
            this.DGVFA.RowTemplate.Height = 33;
            this.DGVFA.Size = new System.Drawing.Size(992, 818);
            this.DGVFA.TabIndex = 0;
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(1587, 59);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(280, 80);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(1587, 177);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(280, 80);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(1587, 283);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(280, 80);
            this.BELIMINAR.TabIndex = 3;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "NUMERO DE FACTURA",
            "CODIGO DE PROVEEDOR"});
            this.CBBUSCAR.Location = new System.Drawing.Point(1544, 499);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(323, 33);
            this.CBBUSCAR.TabIndex = 4;
            this.CBBUSCAR.Text = "BUSCAR FACTURA POR:";
            this.CBBUSCAR.SelectedIndexChanged += new System.EventHandler(this.CBBUSCAR_SelectedIndexChanged);
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(1550, 553);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(317, 31);
            this.TINFO.TabIndex = 5;
            this.TINFO.TextChanged += new System.EventHandler(this.TINFO_TextChanged);
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(1667, 603);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(200, 49);
            this.BBUSCAR.TabIndex = 6;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // BREGRESAR
            // 
            this.BREGRESAR.BackColor = System.Drawing.Color.Red;
            this.BREGRESAR.Location = new System.Drawing.Point(1643, 922);
            this.BREGRESAR.Name = "BREGRESAR";
            this.BREGRESAR.Size = new System.Drawing.Size(224, 65);
            this.BREGRESAR.TabIndex = 7;
            this.BREGRESAR.Text = "REGRESAR";
            this.BREGRESAR.UseVisualStyleBackColor = false;
            this.BREGRESAR.Click += new System.EventHandler(this.BREGRESAR_Click);
            // 
            // BREFRESCAR
            // 
            this.BREFRESCAR.Location = new System.Drawing.Point(782, 894);
            this.BREFRESCAR.Name = "BREFRESCAR";
            this.BREFRESCAR.Size = new System.Drawing.Size(275, 59);
            this.BREFRESCAR.TabIndex = 8;
            this.BREFRESCAR.Text = "REFRESCAR";
            this.BREFRESCAR.UseVisualStyleBackColor = true;
            this.BREFRESCAR.Click += new System.EventHandler(this.BREFRESCAR_Click);
            // 
            // FFACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1028);
            this.Controls.Add(this.BREFRESCAR);
            this.Controls.Add(this.BREGRESAR);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.CBBUSCAR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.DGVFA);
            this.Name = "FFACTURAS";
            this.Text = "MANTENIMIENTO DE FACTURAS";
            this.Load += new System.EventHandler(this.FFACTURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFA;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.Button BREGRESAR;
        private System.Windows.Forms.Button BREFRESCAR;
    }
}