namespace proyecto_acceso_datos
{
    partial class FPROVEEDORES
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
            this.DGVMP = new System.Windows.Forms.DataGridView();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TINFO = new System.Windows.Forms.TextBox();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.REFRESCAR = new System.Windows.Forms.Button();
            this.BVOLVER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMP)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMP
            // 
            this.DGVMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMP.Location = new System.Drawing.Point(43, 146);
            this.DGVMP.Name = "DGVMP";
            this.DGVMP.Size = new System.Drawing.Size(478, 222);
            this.DGVMP.TabIndex = 0;
            this.DGVMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(24, 12);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 1;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(24, 41);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BMODIFICAR.TabIndex = 2;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(24, 73);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BELIMINAR.TabIndex = 3;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR PROVEEDOR POR:";
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "CODIGO",
            "NOMBRES",
            "APELLIDOS",
            "DIRECCION",
            "CIUDAD",
            "TELEFONO"});
            this.CBBUSCAR.Location = new System.Drawing.Point(612, 75);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(121, 21);
            this.CBBUSCAR.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "INGRESE INFORMACION DE BUSQUEDA:";
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(553, 171);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(204, 20);
            this.TINFO.TabIndex = 7;
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(682, 197);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BBUSCAR.TabIndex = 8;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // REFRESCAR
            // 
            this.REFRESCAR.Location = new System.Drawing.Point(435, 374);
            this.REFRESCAR.Name = "REFRESCAR";
            this.REFRESCAR.Size = new System.Drawing.Size(86, 23);
            this.REFRESCAR.TabIndex = 9;
            this.REFRESCAR.Text = "REFRESCAR";
            this.REFRESCAR.UseVisualStyleBackColor = true;
            this.REFRESCAR.Click += new System.EventHandler(this.REFRESCAR_Click);
            // 
            // BVOLVER
            // 
            this.BVOLVER.BackColor = System.Drawing.Color.Yellow;
            this.BVOLVER.Location = new System.Drawing.Point(702, 386);
            this.BVOLVER.Name = "BVOLVER";
            this.BVOLVER.Size = new System.Drawing.Size(86, 52);
            this.BVOLVER.TabIndex = 10;
            this.BVOLVER.Text = "REGRESAR";
            this.BVOLVER.UseVisualStyleBackColor = false;
            this.BVOLVER.Click += new System.EventHandler(this.BVOLVER_Click);
            // 
            // FPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BVOLVER);
            this.Controls.Add(this.REFRESCAR);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBBUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.DGVMP);
            this.Name = "FPROVEEDORES";
            this.Text = "MANTENIMIENTO DE PROVEEDORES";
            this.Load += new System.EventHandler(this.FPROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMP;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.Button REFRESCAR;
        private System.Windows.Forms.Button BVOLVER;
    }
}