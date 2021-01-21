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
    public partial class FRCHEQUES : Form
    {
        public FRCHEQUES()
        {
            InitializeComponent();
        }

        private void FRCHEQUES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SCXPPJDataSet4.CHEQUESPJ' Puede moverla o quitarla según sea necesario.
            this.CHEQUESPJTableAdapter.Fill(this.SCXPPJDataSet4.CHEQUESPJ);

            this.reportViewer1.RefreshReport();
        }

        private void BREGRESAR_Click(object sender, EventArgs e)
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
