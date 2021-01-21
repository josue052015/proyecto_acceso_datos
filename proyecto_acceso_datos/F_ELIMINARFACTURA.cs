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
    public partial class F_ELIMINARFACTURA : Form
    {
        public F_ELIMINARFACTURA()
        {
            InitializeComponent();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RESPUESTA = MessageBox.Show("¿DESEA ELIMINAR LA FACTURA?", "BORRAR FACTURA", MessageBoxButtons.YesNo);
                if (RESPUESTA == DialogResult.Yes)
                {
                    CODIGOO.Text = DGVM.CurrentRow.Cells[0].Value.ToString();
                        DATOSFACTURA2 P = new DATOSFACTURA2();
                        P.ELIMINARFACTURA(Convert.ToInt32(CODIGOO.Text));
                   
                    MessageBox.Show("FACTURA ELIMINADA CORRECTAMENTE");

                    FFACTURAS J = new FFACTURAS();
                    J.Show();
                    this.Hide();
                }

            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
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
                    if (CBBUSCAR.Text == "NUMERO DE FACTURA")
                    {
                        DGVM.DataSource = DATOSFACTURAS.BUSCARELNUMERO(Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "CODIGO DE PROVEEDOR")
                    {
                        DGVM.DataSource = DATOSFACTURAS.BUSCARECODIGO(Convert.ToInt32(TINFO.Text));
                    }
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void F_ELIMINARFACTURA_Load(object sender, EventArgs e)
        {
            DGVM.DataSource = DATOSFACTURAS.BUSCARTODOS();
            DGVM.Columns["CHEQUESPJs"].Visible = false;
            DGVM.Columns["PROVEEDORESPJ"].Visible = false;
        }

        private void DGVM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FFACTURAS J = new FFACTURAS();
            J.Show();
            this.Hide();
        }
    }
}
