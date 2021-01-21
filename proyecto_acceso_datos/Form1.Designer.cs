namespace proyecto_acceso_datos
{
    partial class FINICIO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TUSUARIO = new System.Windows.Forms.TextBox();
            this.TCLAVE = new System.Windows.Forms.TextBox();
            this.DAGVUSUARIOS = new System.Windows.Forms.DataGridView();
            this.BENTRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCRIBA EL NOMBRE DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESCRIBA LA CONTRASEÑA";
            // 
            // TUSUARIO
            // 
            this.TUSUARIO.Location = new System.Drawing.Point(704, 188);
            this.TUSUARIO.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TUSUARIO.Name = "TUSUARIO";
            this.TUSUARIO.Size = new System.Drawing.Size(320, 31);
            this.TUSUARIO.TabIndex = 2;
            this.TUSUARIO.TextChanged += new System.EventHandler(this.TUSUARIO_TextChanged);
            // 
            // TCLAVE
            // 
            this.TCLAVE.Location = new System.Drawing.Point(704, 281);
            this.TCLAVE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TCLAVE.Name = "TCLAVE";
            this.TCLAVE.Size = new System.Drawing.Size(320, 31);
            this.TCLAVE.TabIndex = 3;
            this.TCLAVE.TextChanged += new System.EventHandler(this.TCLAVE_TextChanged);
            // 
            // DAGVUSUARIOS
            // 
            this.DAGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGVUSUARIOS.Location = new System.Drawing.Point(230, 413);
            this.DAGVUSUARIOS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DAGVUSUARIOS.Name = "DAGVUSUARIOS";
            this.DAGVUSUARIOS.RowHeadersWidth = 82;
            this.DAGVUSUARIOS.Size = new System.Drawing.Size(1134, 288);
            this.DAGVUSUARIOS.TabIndex = 4;
            // 
            // BENTRAR
            // 
            this.BENTRAR.Location = new System.Drawing.Point(1134, 352);
            this.BENTRAR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BENTRAR.Name = "BENTRAR";
            this.BENTRAR.Size = new System.Drawing.Size(230, 50);
            this.BENTRAR.TabIndex = 5;
            this.BENTRAR.Text = "ENTRAR";
            this.BENTRAR.UseVisualStyleBackColor = true;
            this.BENTRAR.Click += new System.EventHandler(this.BENTRAR_Click);
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto_acceso_datos.Properties.Resources.photo_1477039181047_efb4357d01bd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.BENTRAR);
            this.Controls.Add(this.DAGVUSUARIOS);
            this.Controls.Add(this.TCLAVE);
            this.Controls.Add(this.TUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FINICIO";
            this.Text = "INICIO DE SESION";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TUSUARIO;
        private System.Windows.Forms.TextBox TCLAVE;
        private System.Windows.Forms.DataGridView DAGVUSUARIOS;
        private System.Windows.Forms.Button BENTRAR;
    }
}

