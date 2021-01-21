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
    public partial class FCHEQUES : Form
    {
        public FCHEQUES()
        {
            InitializeComponent();
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            if (TINFO.Text == String.Empty || CBBUSCAR.Text == "BUSCAR FACTURA POR:")
            {
                MessageBox.Show("FALTAN DATOS DE BUSQUEDA");
            }
            else
            {
                try
                {
                    if (CBBUSCAR.Text == "NUMERO DE CHEQUE")
                    {
                        DGVC.DataSource = DATOSCHEQUES.BUSCARELNUMERO(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "NUMERO DE FACTURA")
                    {
                        DGVC.DataSource = DATOSCHEQUES.BUSCARNUMERO_FACTURA(Convert.ToInt32(TINFO.Text));
                    }

                   
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void FCHEQUES_Load(object sender, EventArgs e)
        {
            DGVC.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            DGVC.Columns["FACTURASPJ"].Visible = false;
        }

        private void BREFRESCAR_Click(object sender, EventArgs e)
        {
            DGVC.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMENUPRI J = new FMENUPRI();
            J.Show();
            this.Hide();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARCHEQUES J = new FAGREGARCHEQUES();
            J.Show();
            this.Hide();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            FMODIFICARCHEQUES J = new FMODIFICARCHEQUES();
            J.Show();
            this.Hide();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            F_ELIMINARCHEQUES J = new F_ELIMINARCHEQUES();
            J.Show();
            this.Hide();
        }
    }
}
