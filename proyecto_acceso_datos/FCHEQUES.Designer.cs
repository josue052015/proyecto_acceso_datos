namespace proyecto_acceso_datos
{
    partial class FCHEQUES
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
            this.DGVC = new System.Windows.Forms.DataGridView();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.TINFO = new System.Windows.Forms.TextBox();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BREFRESCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVC)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVC
            // 
            this.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVC.Location = new System.Drawing.Point(122, 132);
            this.DGVC.Name = "DGVC";
            this.DGVC.RowHeadersWidth = 82;
            this.DGVC.RowTemplate.Height = 33;
            this.DGVC.Size = new System.Drawing.Size(965, 601);
            this.DGVC.TabIndex = 0;
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(1591, 79);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(223, 56);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(1591, 165);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(223, 56);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(1591, 262);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(223, 56);
            this.BELIMINAR.TabIndex = 3;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(1614, 528);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(200, 49);
            this.BBUSCAR.TabIndex = 9;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(1497, 478);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(317, 31);
            this.TINFO.TabIndex = 8;
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "NUMERO DE CHEQUE",
            "NUMERO DE FACTURA"});
            this.CBBUSCAR.Location = new System.Drawing.Point(1491, 424);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(323, 33);
            this.CBBUSCAR.TabIndex = 7;
            this.CBBUSCAR.Text = "BUSCAR CHEQUE POR:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1640, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 91);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BREFRESCAR
            // 
            this.BREFRESCAR.Location = new System.Drawing.Point(861, 739);
            this.BREFRESCAR.Name = "BREFRESCAR";
            this.BREFRESCAR.Size = new System.Drawing.Size(226, 56);
            this.BREFRESCAR.TabIndex = 11;
            this.BREFRESCAR.Text = "REFRESCAR";
            this.BREFRESCAR.UseVisualStyleBackColor = true;
            this.BREFRESCAR.Click += new System.EventHandler(this.BREFRESCAR_Click);
            // 
            // FCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 858);
            this.Controls.Add(this.BREFRESCAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.CBBUSCAR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.DGVC);
            this.Name = "FCHEQUES";
            this.Text = "MANTENIMIENTO DE CHEQUES";
            this.Load += new System.EventHandler(this.FCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVC;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BREFRESCAR;
    }
}