namespace proyecto_acceso_datos
{
    partial class FMODIFICARFACT
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
            this.BBUSCAR = new System.Windows.Forms.Button();
            this.TINFO = new System.Windows.Forms.TextBox();
            this.CBBUSCAR = new System.Windows.Forms.ComboBox();
            this.DGVFA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TNUM = new System.Windows.Forms.TextBox();
            this.TCODP = new System.Windows.Forms.TextBox();
            this.TVALOR = new System.Windows.Forms.TextBox();
            this.TFECHA = new System.Windows.Forms.TextBox();
            this.TFV = new System.Windows.Forms.TextBox();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).BeginInit();
            this.SuspendLayout();
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(1601, 200);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(200, 49);
            this.BBUSCAR.TabIndex = 9;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(1484, 150);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(317, 31);
            this.TINFO.TabIndex = 8;
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "NUMERO DE FACTURA",
            "CODIGO DE PROVEEDOR"});
            this.CBBUSCAR.Location = new System.Drawing.Point(1478, 96);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(323, 33);
            this.CBBUSCAR.TabIndex = 7;
            this.CBBUSCAR.Text = "BUSCAR FACTURA POR:";
            // 
            // DGVFA
            // 
            this.DGVFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFA.Location = new System.Drawing.Point(138, 526);
            this.DGVFA.Name = "DGVFA";
            this.DGVFA.RowHeadersWidth = 82;
            this.DGVFA.RowTemplate.Height = 33;
            this.DGVFA.Size = new System.Drawing.Size(1299, 398);
            this.DGVFA.TabIndex = 10;
            this.DGVFA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFA_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "NUMERO DE FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "CODIGO DEL PROVEEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "VALOR DE LA FACTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "FECHA DE LA FACTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "FECHA DE VENCIMIENTO";
            // 
            // TNUM
            // 
            this.TNUM.Enabled = false;
            this.TNUM.Location = new System.Drawing.Point(501, 78);
            this.TNUM.Name = "TNUM";
            this.TNUM.Size = new System.Drawing.Size(457, 31);
            this.TNUM.TabIndex = 16;
            // 
            // TCODP
            // 
            this.TCODP.Location = new System.Drawing.Point(501, 156);
            this.TCODP.Name = "TCODP";
            this.TCODP.Size = new System.Drawing.Size(457, 31);
            this.TCODP.TabIndex = 17;
            // 
            // TVALOR
            // 
            this.TVALOR.Location = new System.Drawing.Point(501, 233);
            this.TVALOR.Name = "TVALOR";
            this.TVALOR.Size = new System.Drawing.Size(457, 31);
            this.TVALOR.TabIndex = 18;
            // 
            // TFECHA
            // 
            this.TFECHA.Enabled = false;
            this.TFECHA.Location = new System.Drawing.Point(501, 313);
            this.TFECHA.Name = "TFECHA";
            this.TFECHA.Size = new System.Drawing.Size(457, 31);
            this.TFECHA.TabIndex = 19;
            // 
            // TFV
            // 
            this.TFV.Enabled = false;
            this.TFV.Location = new System.Drawing.Point(501, 391);
            this.TFV.Name = "TFV";
            this.TFV.Size = new System.Drawing.Size(457, 31);
            this.TFV.TabIndex = 20;
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.BackColor = System.Drawing.Color.Red;
            this.BMODIFICAR.Location = new System.Drawing.Point(1460, 526);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(257, 196);
            this.BMODIFICAR.TabIndex = 21;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = false;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(1460, 728);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(257, 196);
            this.BCANCELAR.TabIndex = 22;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // FMODIFICARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 993);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.TFV);
            this.Controls.Add(this.TFECHA);
            this.Controls.Add(this.TVALOR);
            this.Controls.Add(this.TCODP);
            this.Controls.Add(this.TNUM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVFA);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.CBBUSCAR);
            this.Name = "FMODIFICARFACT";
            this.Text = "MODIFICAR DATOS DE FACTURAS POR PAGAR";
            this.Load += new System.EventHandler(this.FMODIFICARFACT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.DataGridView DGVFA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TNUM;
        private System.Windows.Forms.TextBox TCODP;
        private System.Windows.Forms.TextBox TVALOR;
        private System.Windows.Forms.TextBox TFECHA;
        private System.Windows.Forms.TextBox TFV;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BCANCELAR;
    }
}