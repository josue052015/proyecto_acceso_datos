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
    public partial class FMODIFICARPROV : Form
    {
        public FMODIFICARPROV()
        {
            InitializeComponent();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
           
            if (TNOMBRES.Text == String.Empty || TAPELLIDOS.Text == String.Empty || TCIUDAD.Text == String.Empty || TCIUDAD.Text == String.Empty || TTELEFONO.Text == String.Empty)
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {
                try
                {
                    DialogResult RESPUESTA = MessageBox.Show("¿DESEA MODIFICAR EL PROVEEDOR?", "MODIFICAR PROVEEDOR", MessageBoxButtons.YesNo);
                    if (RESPUESTA == DialogResult.Yes)
                    { 
                    DATOSPROVEEDORES P = new DATOSPROVEEDORES();
                    P.MODIFICAR(Convert.ToInt32(TCODIGO.Text), TNOMBRES.Text, TAPELLIDOS.Text, TDIRECCION.Text, TCIUDAD.Text, TTELEFONO.Text);
                    MessageBox.Show("DATOS MODIFICADOS CORRECTAMENTE");
                    this.Close();
                        }
                       
                    }
                catch(Exception K)
                {
                    MessageBox.Show(K.Message);
                }
            }
}
        private void DGVM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TCODIGO.Text = DGVM.CurrentRow.Cells[0].Value.ToString();
            TNOMBRES.Text = DGVM.CurrentRow.Cells[1].Value.ToString();
            TAPELLIDOS.Text = DGVM.CurrentRow.Cells[2].Value.ToString();
            TDIRECCION.Text = DGVM.CurrentRow.Cells[3].Value.ToString();
            TCIUDAD.Text = DGVM.CurrentRow.Cells[4].Value.ToString();
            TTELEFONO.Text = DGVM.CurrentRow.Cells[5].Value.ToString();
       
        }

        private void FMODIFICARPROV_Load(object sender, EventArgs e)
        {
            TCODIGO.Enabled = false;
            DGVM.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            DGVM.Columns["FACTURASPJs"].Visible = false;

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

     

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TINFO_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBBUSCAR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}