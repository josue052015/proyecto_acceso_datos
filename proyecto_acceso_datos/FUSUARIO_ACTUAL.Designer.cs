namespace proyecto_acceso_datos
{
    partial class FUSUARIO_ACTUAL
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
            this.DGVUA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUA)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUA
            // 
            this.DGVUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUA.Location = new System.Drawing.Point(92, 205);
            this.DGVUA.Name = "DGVUA";
            this.DGVUA.Size = new System.Drawing.Size(594, 150);
            this.DGVUA.TabIndex = 1;
            // 
            // FUSUARIO_ACTUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVUA);
            this.Name = "FUSUARIO_ACTUAL";
            this.Text = "FUSUARIO_ACTUAL";
        
            ((System.ComponentModel.ISupportInitialize)(this.DGVUA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUA;
    }
}