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
    public partial class FRESTADOCUENTAS : Form
    {
        public FRESTADOCUENTAS()
        {
            InitializeComponent();
        }

        private void FRESTADOCUENTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SCXPPJDataSet6.CHEQUESPJ' Puede moverla o quitarla según sea necesario.
            this.CHEQUESPJTableAdapter.Fill(this.SCXPPJDataSet6.CHEQUESPJ);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
