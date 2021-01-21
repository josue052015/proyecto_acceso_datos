namespace proyecto_acceso_datos
{
    partial class FMODIFICARPROV
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
            this.TTELEFONO = new System.Windows.Forms.TextBox();
            this.TCIUDAD = new System.Windows.Forms.TextBox();
            this.TDIRECCION = new System.Windows.Forms.TextBox();
            this.TAPELLIDOS = new System.Windows.Forms.TextBox();
            this.TNOMBRES = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.DGVM = new System.Windows.Forms.DataGridView();
            this.TINFO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).BeginInit();
            this.SuspendLayout();
            // 
            // TTELEFONO
            // 
            this.TTELEFONO.Location = new System.Drawing.Point(110, 229);
            this.TTELEFONO.MaxLength = 13;
            this.TTELEFONO.Name = "TTELEFONO";
            this.TTELEFONO.Size = new System.Drawing.Size(156, 20);
            this.TTELEFONO.TabIndex = 23;
            // 
            // TCIUDAD
            // 
            this.TCIUDAD.Location = new System.Drawing.Point(110, 192);
            this.TCIUDAD.MaxLength = 25;
            this.TCIUDAD.Name = "TCIUDAD";
            this.TCIUDAD.Size = new System.Drawing.Size(156, 20);
            this.TCIUDAD.TabIndex = 22;
            // 
            // TDIRECCION
            // 
            this.TDIRECCION.Location = new System.Drawing.Point(110, 152);
            this.TDIRECCION.MaxLength = 35;
            this.TDIRECCION.Name = "TDIRECCION";
            this.TDIRECCION.Size = new System.Drawing.Size(156, 20);
            this.TDIRECCION.TabIndex = 21;
            // 
            // TAPELLIDOS
            // 
            this.TAPELLIDOS.Location = new System.Drawing.Point(110, 118);
            this.TAPELLIDOS.MaxLength = 25;
            this.TAPELLIDOS.Name = "TAPELLIDOS";
            this.TAPELLIDOS.Size = new System.Drawing.Size(156, 20);
            this.TAPELLIDOS.TabIndex = 20;
            // 
            // TNOMBRES
            // 
            this.TNOMBRES.Location = new System.Drawing.Point(110, 80);
            this.TNOMBRES.MaxLength = 25;
            this.TNOMBRES.Name = "TNOMBRES";
            this.TNOMBRES.Size = new System.Drawing.Size(156, 20);
            this.TNOMBRES.TabIndex = 19;
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(110, 40);
            this.TCODIGO.MaxLength = 7;
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(156, 20);
            this.TCODIGO.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "CIUDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DIRECCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CODIGO";
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.BackColor = System.Drawing.Color.Red;
            this.BMODIFICAR.Location = new System.Drawing.Point(642, 308);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(106, 56);
            this.BMODIFICAR.TabIndex = 24;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = false;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
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
            this.CBBUSCAR.Location = new System.Drawing.Point(556, 86);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(232, 21);
            this.CBBUSCAR.TabIndex = 25;
            this.CBBUSCAR.Text = "SELECCIONE UN DATO DE BUSQUEDA";
            this.CBBUSCAR.SelectedIndexChanged += new System.EventHandler(this.CBBUSCAR_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "BUSCAR PROVEEDOR POR:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(682, 113);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(106, 29);
            this.BBUSCAR.TabIndex = 27;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(642, 383);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(106, 55);
            this.BCANCELAR.TabIndex = 28;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // DGVM
            // 
            this.DGVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVM.Location = new System.Drawing.Point(33, 308);
            this.DGVM.Name = "DGVM";
            this.DGVM.Size = new System.Drawing.Size(586, 130);
            this.DGVM.TabIndex = 29;
            this.DGVM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVM_CellContentClick);
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(570, 118);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(106, 20);
            this.TINFO.TabIndex = 30;
            this.TINFO.TextChanged += new System.EventHandler(this.TINFO_TextChanged);
            // 
            // FMODIFICARPROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.DGVM);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBBUSCAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.TTELEFONO);
            this.Controls.Add(this.TCIUDAD);
            this.Controls.Add(this.TDIRECCION);
            this.Controls.Add(this.TAPELLIDOS);
            this.Controls.Add(this.TNOMBRES);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMODIFICARPROV";
            this.Text = "MODIFICAR DATOS DE PROVEEDORES";
            this.Load += new System.EventHandler(this.FMODIFICARPROV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTELEFONO;
        private System.Windows.Forms.TextBox TCIUDAD;
        private System.Windows.Forms.TextBox TDIRECCION;
        private System.Windows.Forms.TextBox TAPELLIDOS;
        private System.Windows.Forms.TextBox TNOMBRES;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.Button BCANCELAR;
        private System.Windows.Forms.DataGridView DGVM;
        private System.Windows.Forms.TextBox TINFO;
    }
}