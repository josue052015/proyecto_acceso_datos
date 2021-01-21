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
    public partial class F_ELIMINARPROVEEDOR : Form
    {
        public F_ELIMINARPROVEEDOR()
        {
            InitializeComponent();
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            if (CBBUSCAR.Text == "SELECCIONE UN DATO DE BUSQUEDA")
            {
                MessageBox.Show("SELECCIONE UN METODO DE BUSQUEDA");
            }
            else
            {
                try
                {
                    if (TINFO.Text == string.Empty)
                    {
                        MessageBox.Show("INGRESE UN DATO DE BUSQUEDA");
                    }
                    else
                    {
                        if (CBBUSCAR.Text == "CODIGO")
                        {

                            DGVM.DataSource = DATOSPROVEEDORES.BUSCARPORCODIGO(Convert.ToInt32(TINFO.Text));
                        }
                        if (CBBUSCAR.Text == "NOMBRES")
                        {

                            DGVM.DataSource = DATOSPROVEEDORES.BUSCARNOMBRES(TINFO.Text);
                        }
                        if (CBBUSCAR.Text == "APELLIDOS")
                        {

                            DGVM.DataSource = DATOSPROVEEDORES.BUSCARPORAPELLIDOS(TINFO.Text);
                        }
                        if (CBBUSCAR.Text == "DIRECCION")
                        {

                            DGVM.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TINFO.Text);
                        }
                        if (CBBUSCAR.Text == "CIUDAD")
                        {

                            DGVM.DataSource = DATOSPROVEEDORES.BUSCARPORCIUDAD(TINFO.Text);
                        }
                    }

                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }

            }
        }

        private void F_ELIMINARPROVEEDOR_Load(object sender, EventArgs e)
        {
            DGVM.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            DGVM.Columns["FACTURASPJs"].Visible = false;
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult RESPUESTA = MessageBox.Show("¿DESEA ELIMINAR EL PROVEEDOR?", "BORRAR PROVEEDOR", MessageBoxButtons.YesNo);
                if (RESPUESTA == DialogResult.Yes)
                { 
                CODIGOO.Text = DGVM.CurrentRow.Cells[5].Value.ToString();
            DATOSPROVEEDORES OK = new DATOSPROVEEDORES();
                OK.ELIMINARPROVEEDOR(Convert.ToInt16(CODIGOO.Text));
                MessageBox.Show("PROVEEDOR ELIMINADO CORRECTAMENTE");

                this.Close();
                     }

                }
            catch(Exception X)
            {
                MessageBox.Show(X.Message);
            }
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
