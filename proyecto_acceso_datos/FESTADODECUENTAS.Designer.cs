namespace proyecto_acceso_datos
{
    partial class FESTADODECUENTAS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.TNUMF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVESTADODECUENTA = new System.Windows.Forms.DataGridView();
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADODECUENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TNUMF);
            this.groupBox1.Controls.Add(this.TCODIGO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1729, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR POR ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO DEL PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE FACTURA";
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(360, 65);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(371, 31);
            this.TCODIGO.TabIndex = 2;
            this.TCODIGO.TextChanged += new System.EventHandler(this.TCODIGO_TextChanged);
            // 
            // TNUMF
            // 
            this.TNUMF.Location = new System.Drawing.Point(997, 65);
            this.TNUMF.Name = "TNUMF";
            this.TNUMF.Size = new System.Drawing.Size(371, 31);
            this.TNUMF.TabIndex = 3;
            this.TNUMF.TextChanged += new System.EventHandler(this.TNUMF_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1400, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR TODOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVESTADODECUENTA
            // 
            this.DGVESTADODECUENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVESTADODECUENTA.Location = new System.Drawing.Point(41, 362);
            this.DGVESTADODECUENTA.Name = "DGVESTADODECUENTA";
            this.DGVESTADODECUENTA.RowHeadersWidth = 82;
            this.DGVESTADODECUENTA.RowTemplate.Height = 33;
            this.DGVESTADODECUENTA.Size = new System.Drawing.Size(1631, 412);
            this.DGVESTADODECUENTA.TabIndex = 1;
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.Location = new System.Drawing.Point(1429, 791);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(243, 49);
            this.BCANCELAR.TabIndex = 2;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = true;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // FESTADODECUENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 868);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.DGVESTADODECUENTA);
            this.Controls.Add(this.groupBox1);
            this.Name = "FESTADODECUENTAS";
            this.Text = "ESTADO DE CUENTAS";
            this.Load += new System.EventHandler(this.FESTADODECUENTAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVESTADODECUENTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TNUMF;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVESTADODECUENTA;
        private System.Windows.Forms.Button BCANCELAR;
    }
}