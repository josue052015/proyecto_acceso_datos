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
    public partial class FPROVEEDORES : Form
    {
        
        public FPROVEEDORES()
        {
            InitializeComponent();
        }
        

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARPROV J = new FAGREGARPROV();
            J.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            DGVMP.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            DGVMP.Columns["FACTURASPJs"].Visible = false;
        }

        private void BBUSCAR_Click(object sender, EventArgs e)
        {
            if (CBBUSCAR.Text == String.Empty)
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
                    
                   DGVMP.DataSource = DATOSPROVEEDORES.BUSCARPORCODIGO( Convert.ToInt32( TINFO.Text));
                }
                if (CBBUSCAR.Text == "NOMBRES")
                {

                    DGVMP.DataSource = DATOSPROVEEDORES.BUSCARNOMBRES(TINFO.Text);
                }
                if (CBBUSCAR.Text == "APELLIDOS")
                {

                    DGVMP.DataSource = DATOSPROVEEDORES.BUSCARPORAPELLIDOS(TINFO.Text);
                }
                        if (CBBUSCAR.Text == "DIRECCION")
                        {

                            DGVMP.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TINFO.Text);
                        }
                        if (CBBUSCAR.Text == "CIUDAD")
                        {

                            DGVMP.DataSource = DATOSPROVEEDORES.BUSCARPORCIUDAD(TINFO.Text);
                        }
                    }
                 }
            catch(Exception X)
            {
                MessageBox.Show(X.Message);
            }
                 }
            }

        private void REFRESCAR_Click(object sender, EventArgs e)
        {
            DGVMP.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void BVOLVER_Click(object sender, EventArgs e)
        {
            FMENUPRI J = new FMENUPRI();
            J.Show();
            this.Hide();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            FMODIFICARPROV J = new FMODIFICARPROV();
            J.Show();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            F_ELIMINARPROVEEDOR J = new F_ELIMINARPROVEEDOR();
            J.Show();
            this.Hide();

        }
        public void KLK(String A)
        {

        }
    }
}
