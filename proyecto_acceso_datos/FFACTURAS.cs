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
    public partial class FFACTURAS : Form
    {
        public FFACTURAS()
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
                    if (CBBUSCAR.Text == "NUMERO DE FACTURA")
                    {
                        DGVFA.DataSource = DATOSFACTURAS.BUSCARELNUMERO (Convert.ToInt32(TINFO.Text));
                    }
                    if (CBBUSCAR.Text == "CODIGO DE PROVEEDOR")
                    {
                        DGVFA.DataSource = DATOSFACTURAS.BUSCARECODIGO(Convert.ToInt32(TINFO.Text));
                    }
                }
                catch(Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            }
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARFACT J = new FAGREGARFACT();
            J.Show();
            this.Hide();
        }

        private void FFACTURAS_Load(object sender, EventArgs e)
        {
            DGVFA.DataSource = DATOSFACTURAS.BUSCARTODOS();
            DGVFA.Columns["PROVEEDORESPJ"].Visible = false;
            DGVFA.Columns["CHEQUESPJs"].Visible = false;
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            FMODIFICARFACT J = new FMODIFICARFACT();
            J.Show();
            this.Hide();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            F_ELIMINARFACTURA J = new F_ELIMINARFACTURA();
            J.Show();
            this.Hide();
        }

        private void BREFRESCAR_Click(object sender, EventArgs e)
        {
            DGVFA.DataSource = DATOSFACTURAS.BUSCARTODOS();
        }

        private void BREGRESAR_Click(object sender, EventArgs e)
        {
            FMENUPRI J = new FMENUPRI();
            J.Show();
            this.Hide();
        }

        private void TINFO_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBBUSCAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
