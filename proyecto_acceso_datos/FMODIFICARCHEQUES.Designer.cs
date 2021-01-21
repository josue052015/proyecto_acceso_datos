namespace proyecto_acceso_datos
{
    partial class FMODIFICARCHEQUES
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
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.DGVFA = new System.Windows.Forms.DataGridView();
            this.TFECHA = new System.Windows.Forms.TextBox();
            this.TVALOR = new System.Windows.Forms.TextBox();
            this.TNUMF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TNUMC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).BeginInit();
            this.SuspendLayout();
            // 
            // BBUSCAR
            // 
            this.BBUSCAR.Location = new System.Drawing.Point(1534, 243);
            this.BBUSCAR.Name = "BBUSCAR";
            this.BBUSCAR.Size = new System.Drawing.Size(200, 49);
            this.BBUSCAR.TabIndex = 12;
            this.BBUSCAR.Text = "BUSCAR";
            this.BBUSCAR.UseVisualStyleBackColor = true;
            this.BBUSCAR.Click += new System.EventHandler(this.BBUSCAR_Click);
            // 
            // TINFO
            // 
            this.TINFO.Location = new System.Drawing.Point(1417, 193);
            this.TINFO.Name = "TINFO";
            this.TINFO.Size = new System.Drawing.Size(317, 31);
            this.TINFO.TabIndex = 11;
            // 
            // CBBUSCAR
            // 
            this.CBBUSCAR.FormattingEnabled = true;
            this.CBBUSCAR.Items.AddRange(new object[] {
            "NUMERO CHEQUE",
            "NUMERO FACTURA"});
            this.CBBUSCAR.Location = new System.Drawing.Point(1411, 139);
            this.CBBUSCAR.Name = "CBBUSCAR";
            this.CBBUSCAR.Size = new System.Drawing.Size(323, 33);
            this.CBBUSCAR.TabIndex = 10;
            this.CBBUSCAR.Text = "BUSCAR CHEQUE POR:";
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(1467, 606);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(257, 196);
            this.BCANCELAR.TabIndex = 25;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.BackColor = System.Drawing.Color.Red;
            this.BMODIFICAR.Location = new System.Drawing.Point(1467, 404);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(257, 196);
            this.BMODIFICAR.TabIndex = 24;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = false;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // DGVFA
            // 
            this.DGVFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFA.Location = new System.Drawing.Point(116, 404);
            this.DGVFA.Name = "DGVFA";
            this.DGVFA.RowHeadersWidth = 82;
            this.DGVFA.RowTemplate.Height = 33;
            this.DGVFA.Size = new System.Drawing.Size(1299, 398);
            this.DGVFA.TabIndex = 23;
            this.DGVFA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFA_CellContentClick);
            // 
            // TFECHA
            // 
            this.TFECHA.Enabled = false;
            this.TFECHA.Location = new System.Drawing.Point(460, 329);
            this.TFECHA.Name = "TFECHA";
            this.TFECHA.Size = new System.Drawing.Size(358, 31);
            this.TFECHA.TabIndex = 31;
            // 
            // TVALOR
            // 
            this.TVALOR.Location = new System.Drawing.Point(460, 246);
            this.TVALOR.Name = "TVALOR";
            this.TVALOR.Size = new System.Drawing.Size(358, 31);
            this.TVALOR.TabIndex = 30;
            // 
            // TNUMF
            // 
            this.TNUMF.Location = new System.Drawing.Point(460, 159);
            this.TNUMF.Name = "TNUMF";
            this.TNUMF.Size = new System.Drawing.Size(358, 31);
            this.TNUMF.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "FECHA CHEQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "VALOR CHEQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "NUMERO DE FACTURA";
            // 
            // TNUMC
            // 
            this.TNUMC.Enabled = false;
            this.TNUMC.Location = new System.Drawing.Point(460, 78);
            this.TNUMC.Name = "TNUMC";
            this.TNUMC.Size = new System.Drawing.Size(358, 31);
            this.TNUMC.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "NUMERO DE CHEQUE";
            // 
            // FMODIFICARCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1831, 842);
            this.Controls.Add(this.TNUMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TFECHA);
            this.Controls.Add(this.TVALOR);
            this.Controls.Add(this.TNUMF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.DGVFA);
            this.Controls.Add(this.BBUSCAR);
            this.Controls.Add(this.TINFO);
            this.Controls.Add(this.CBBUSCAR);
            this.Name = "FMODIFICARCHEQUES";
            this.Text = "MODIFICAR DATOS DE CHEQUES";
            this.Load += new System.EventHandler(this.FMODIFICARCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBUSCAR;
        private System.Windows.Forms.TextBox TINFO;
        private System.Windows.Forms.ComboBox CBBUSCAR;
        private System.Windows.Forms.Button BCANCELAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.DataGridView DGVFA;
        private System.Windows.Forms.TextBox TFECHA;
        private System.Windows.Forms.TextBox TVALOR;
        private System.Windows.Forms.TextBox TNUMF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNUMC;
        private System.Windows.Forms.Label label4;
    }
}