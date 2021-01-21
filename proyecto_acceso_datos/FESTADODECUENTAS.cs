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
    public partial class FESTADODECUENTAS : Form
    {
        public FESTADODECUENTAS()
        {
            InitializeComponent();
        }

        private void FESTADODECUENTAS_Load(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADOSDECUENTA.MOSTRARESTADO();

        }

        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADOSDECUENTA.BUSCARPORCOIGO(Convert.ToInt32( TCODIGO.Text));
        }

        private void TNUMF_TextChanged(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADOSDECUENTA.BUSCARPORNUMEROFACTURA(Convert.ToInt32(TNUMF.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVESTADODECUENTA.DataSource = DATOSESTADOSDECUENTA.MOSTRARESTADO();
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FMENUPRI J = new FMENUPRI();
            J.Show();
            this.Hide();
        }
    }
}
