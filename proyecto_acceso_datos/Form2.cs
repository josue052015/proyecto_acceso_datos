using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_acceso_datos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SCXPPJDataSet1.FACTURASPJ' Puede moverla o quitarla según sea necesario.
            this.FACTURASPJTableAdapter.Fill(this.SCXPPJDataSet1.FACTURASPJ);

            this.reportViewer1.RefreshReport();
           
        }

        private void FREGRESAR_Click(object sender, EventArgs e)
        {
            FMENUPRI J = new FMENUPRI();
            J.Show();
            this.Hide();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
