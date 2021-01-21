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
    public partial class FAGREGARCHEQUES : Form
    {
        public FAGREGARCHEQUES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            if (TVALOR.Text == String.Empty || TNUM.Text == String.Empty || TFECHA.Text == String.Empty)
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {

                try
                {
                    DATOSCHEQUES J = new DATOSCHEQUES();
                    J.AGREGARCHEQUE(Convert.ToInt32(TNUM.Text), Convert.ToDecimal(TVALOR.Text), Convert.ToDateTime(TFECHA.Text));
                    MessageBox.Show("DATOS AGREGADOS CORRECTAMENTE");

                    FCHEQUES P = new FCHEQUES();
                    P.Show();
                    this.Hide();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void FAGREGARCHEQUES_Load(object sender, EventArgs e)
        {
            String DIA;
            DIA = DateTime.Today.ToString();
            TFECHA.Text = DIA;
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FCHEQUES P = new FCHEQUES();
            P.Show();
            this.Hide();

        }
    }
}
