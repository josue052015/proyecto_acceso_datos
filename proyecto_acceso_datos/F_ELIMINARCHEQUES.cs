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
    public partial class F_ELIMINARCHEQUES : Form
    {
        public F_ELIMINARCHEQUES()
        {
            InitializeComponent();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            if (TINFO.Text == String.Empty || CBBUSCAR.Text == "")
            {
                MessageBox.Show("FALTAN DATOS DE BUSQUEDA");
            }
            else
            {
                try
                {
                    DialogResult RESPUESTA = MessageBox.Show("¿DESEA ELIMINAR EL CHEQUE?", "BORRAR CHEQUE", MessageBoxButtons.YesNo);
                    if (RESPUESTA == DialogResult.Yes)
                    {
                        CODIGOO.Text = DGVM.CurrentRow.Cells[0].Value.ToString();
                        DATOSCHEQUES P = new DATOSCHEQUES();
                        P.ELIMINARCHEQUE(Convert.ToInt32(CODIGOO.Text));
                        MessageBox.Show("CHEQUE ELIMINADO CORRECTAMENTE");

                        FCHEQUES J = new FCHEQUES();
                        J.Show();
                        this.Hide();
                    }

                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
            
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            if (TINFO.Text == String.Empty || CBBUSCAR.Text == "")
            {
                MessageBox.Show("FALTAN DATOS DE BUSQUEDA");
            }
            else
            {
                try
                {
                    if (CBBUSCAR.Text == "NUMERO CHEQUE")
                    {
                        DGVM.DataSource = DATOSCHEQUES.BUSCARELNUMERO(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "NUMERO FACTURA")
                    {
                        DGVM.DataSource = DATOSCHEQUES.BUSCARNUMERO_FACTURA(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "VALOR")
                    {
                        DGVM.DataSource = DATOSCHEQUES.BUSCAR_VALOR(Convert.ToDecimal(TINFO.Text));
                    }
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void F_ELIMINARCHEQUES_Load(object sender, EventArgs e)
        {
            DGVM.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            DGVM.Columns["FACTURASPJ"].Visible = false;
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FCHEQUES J = new FCHEQUES();
            J.Show();
            this.Hide();
        }
    }
}
