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
    public partial class FMODIFICARFACT : Form
    {
        public FMODIFICARFACT()
        {
            InitializeComponent();
        }

        private void FMODIFICARFACT_Load(object sender, EventArgs e)
        {
            DGVFA.DataSource = DATOSFACTURAS.BUSCARTODOS();
            DGVFA.Columns["CHEQUESPJs"].Visible = false;
            DGVFA.Columns["PROVEEDORESPJ"].Visible = false;
        }

        private void DGVFA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNUM .Text = DGVFA.CurrentRow.Cells[0].Value.ToString();
            TCODP.Text = DGVFA.CurrentRow.Cells[1].Value.ToString();
            TVALOR.Text = DGVFA.CurrentRow.Cells[2].Value.ToString();
            TFECHA.Text = DGVFA.CurrentRow.Cells[3].Value.ToString();
            TFV.Text = DGVFA.CurrentRow.Cells[4].Value.ToString();
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
             if(TINFO.Text == String.Empty || CBBUSCAR.Text == "BUSCAR FACTURA POR:")
            {
                MessageBox.Show("FALTAN DATOS DE BUSQUEDA");
            }
            else
            {
                try
                {
                    if (CBBUSCAR.Text == "NUMERO DE FACTURA")
                    {
                        DGVFA.DataSource = DATOSFACTURAS.BUSCARELNUMERO(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "CODIGO DE PROVEEDOR")
                    {
                        DGVFA.DataSource = DATOSFACTURAS.BUSCARECODIGO(Convert.ToInt32(TINFO.Text));
                    }
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FFACTURAS J = new FFACTURAS();
            J.Show();
            this.Hide();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            if (TNUM.Text == String.Empty || TCODP .Text == String.Empty || TVALOR.Text == String.Empty || TFECHA.Text == String.Empty || TFV.Text == String.Empty )
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {
                try
                {
                    DialogResult RESPUESTA = MessageBox.Show("¿DESEA MODIFICAR LA FACTURA?", "MODIFICAR FACTURA", MessageBoxButtons.YesNo);
                    if (RESPUESTA == DialogResult.Yes)
                    {
                        DATOSFACTURA2 P = new DATOSFACTURA2();
                        P.MODIFICARFACTURA(Convert.ToInt32(TNUM.Text),Convert.ToInt32(TCODP.Text),Convert.ToDecimal(TVALOR.Text), Convert.ToDateTime(TFECHA.Text),Convert.ToDateTime(TFV.Text));
                        MessageBox.Show("DATOS MODIFICADOS CORRECTAMENTE");
                        FFACTURAS J = new FFACTURAS();
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
    }
}
