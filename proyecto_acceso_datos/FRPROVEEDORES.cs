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
    public partial class FRPROVEEDORES : Form
    {
        public FRPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FRPROVEEDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCXPPJDataSet.PROVEEDORESPJ' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESPJTableAdapter.Fill(this.sCXPPJDataSet.PROVEEDORESPJ);

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
