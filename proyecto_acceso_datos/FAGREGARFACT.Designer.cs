namespace proyecto_acceso_datos
{
    partial class FAGREGARFACT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.TVALOR = new System.Windows.Forms.TextBox();
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TFFA = new System.Windows.Forms.TextBox();
            this.TFV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALOR FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA FACTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE VENCIMIENTO";
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(502, 149);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(429, 31);
            this.TCODIGO.TabIndex = 4;
            // 
            // TVALOR
            // 
            this.TVALOR.Location = new System.Drawing.Point(502, 245);
            this.TVALOR.Name = "TVALOR";
            this.TVALOR.Size = new System.Drawing.Size(429, 31);
            this.TVALOR.TabIndex = 5;
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(1592, 816);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(239, 105);
            this.BCANCELAR.TabIndex = 8;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.BackColor = System.Drawing.Color.Crimson;
            this.BAGREGAR.Location = new System.Drawing.Point(1592, 687);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(239, 105);
            this.BAGREGAR.TabIndex = 9;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = false;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TFFA
            // 
            this.TFFA.Location = new System.Drawing.Point(502, 349);
            this.TFFA.Name = "TFFA";
            this.TFFA.Size = new System.Drawing.Size(429, 31);
            this.TFFA.TabIndex = 10;
            // 
            // TFV
            // 
            this.TFV.Location = new System.Drawing.Point(502, 443);
            this.TFV.Name = "TFV";
            this.TFV.Size = new System.Drawing.Size(429, 31);
            this.TFV.TabIndex = 11;
            // 
            // FAGREGARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 957);
            this.Controls.Add(this.TFV);
            this.Controls.Add(this.TFFA);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.TVALOR);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARFACT";
            this.Text = "REGISTRAR DATOS DE FACTURAS POR PAGAR ";
            this.Load += new System.EventHandler(this.FAGREGARFACT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.TextBox TVALOR;
        private System.Windows.Forms.Button BCANCELAR;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TFFA;
        private System.Windows.Forms.TextBox TFV;
    }
}