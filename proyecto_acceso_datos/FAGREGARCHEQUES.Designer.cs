namespace proyecto_acceso_datos
{
    partial class FAGREGARCHEQUES
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
            this.TNUM = new System.Windows.Forms.TextBox();
            this.TVALOR = new System.Windows.Forms.TextBox();
            this.TFECHA = new System.Windows.Forms.TextBox();
            this.BCANCELAR = new System.Windows.Forms.Button();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DE FACTURA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALOR CHEQUE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA CHEQUE";
            // 
            // TNUM
            // 
            this.TNUM.Location = new System.Drawing.Point(478, 132);
            this.TNUM.Name = "TNUM";
            this.TNUM.Size = new System.Drawing.Size(358, 31);
            this.TNUM.TabIndex = 3;
            // 
            // TVALOR
            // 
            this.TVALOR.Location = new System.Drawing.Point(478, 219);
            this.TVALOR.Name = "TVALOR";
            this.TVALOR.Size = new System.Drawing.Size(358, 31);
            this.TVALOR.TabIndex = 4;
            // 
            // TFECHA
            // 
            this.TFECHA.Location = new System.Drawing.Point(478, 302);
            this.TFECHA.Name = "TFECHA";
            this.TFECHA.Size = new System.Drawing.Size(358, 31);
            this.TFECHA.TabIndex = 5;
            // 
            // BCANCELAR
            // 
            this.BCANCELAR.BackColor = System.Drawing.Color.Teal;
            this.BCANCELAR.Location = new System.Drawing.Point(1393, 720);
            this.BCANCELAR.Name = "BCANCELAR";
            this.BCANCELAR.Size = new System.Drawing.Size(222, 127);
            this.BCANCELAR.TabIndex = 6;
            this.BCANCELAR.Text = "CANCELAR";
            this.BCANCELAR.UseVisualStyleBackColor = false;
            this.BCANCELAR.Click += new System.EventHandler(this.BCANCELAR_Click);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.BackColor = System.Drawing.Color.Crimson;
            this.BAGREGAR.Location = new System.Drawing.Point(1393, 587);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(222, 127);
            this.BAGREGAR.TabIndex = 7;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = false;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // FAGREGARCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 881);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.BCANCELAR);
            this.Controls.Add(this.TFECHA);
            this.Controls.Add(this.TVALOR);
            this.Controls.Add(this.TNUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARCHEQUES";
            this.Text = "REGISTRAR DATOS DE CHEQUES";
            this.Load += new System.EventHandler(this.FAGREGARCHEQUES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TNUM;
        private System.Windows.Forms.TextBox TVALOR;
        private System.Windows.Forms.TextBox TFECHA;
        private System.Windows.Forms.Button BCANCELAR;
        private System.Windows.Forms.Button BAGREGAR;
    }
}