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
    public partial class FMODIFICARCHEQUES : Form
    {
        public FMODIFICARCHEQUES()
        {
            InitializeComponent();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            if (TNUMC.Text == String.Empty || TNUMF.Text == String.Empty || TVALOR.Text == String.Empty || TFECHA.Text == String.Empty )
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {
                try
                {
                    DialogResult RESPUESTA = MessageBox.Show("¿DESEA MODIFICAR EL CHEQUE?", "MODIFICAR CHEQUE", MessageBoxButtons.YesNo);
                    if (RESPUESTA == DialogResult.Yes)
                    {
                        DATOSCHEQUES P = new DATOSCHEQUES();
                        P.MODIFICARCHEQUE(Convert.ToInt32(TNUMC.Text),Convert.ToInt32(TNUMF.Text),Convert.ToDecimal(TVALOR.Text));
                        MessageBox.Show("DATOS MODIFICADOS CORRECTAMENTE");
                        FCHEQUES J = new FCHEQUES();
                        J.Show();
                        this.Hide();
                    }

                }
                catch (Exception K)
                {
                    MessageBox.Show(K.Message);
                }
            }
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            if (TINFO.Text == String.Empty || CBBUSCAR.Text == "BUSCAR CHEQUE POR:")
            {
                MessageBox.Show("FALTAN DATOS DE BUSQUEDA");
            }
            else
            {
                try
                {
                    if (CBBUSCAR.Text == "NUMERO CHEQUE")
                    {
                        DGVFA.DataSource = DATOSCHEQUES.BUSCARELNUMERO(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "NUMERO FACTURA")
                    {
                        DGVFA.DataSource = DATOSCHEQUES.BUSCARNUMERO_FACTURA(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "VALOR")
                    {
                        DGVFA.DataSource = DATOSCHEQUES.BUSCAR_VALOR(Convert.ToDecimal(TINFO.Text));
                    }
                   
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void DGVFA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNUMC.Text = DGVFA.CurrentRow.Cells[0].Value.ToString();
            TNUMF.Text = DGVFA.CurrentRow.Cells[1].Value.ToString();
            TVALOR.Text = DGVFA.CurrentRow.Cells[2].Value.ToString();
            TFECHA.Text = DGVFA.CurrentRow.Cells[3].Value.ToString();
        }

        private void FMODIFICARCHEQUES_Load(object sender, EventArgs e)
        {
            DGVFA.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            DGVFA.Columns["FACTURASPJ"].Visible = false;
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FCHEQUES J = new FCHEQUES();
            J.Show();
            this.Hide();
        }
    }
}
