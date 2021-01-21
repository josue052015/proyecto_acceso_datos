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
    public partial class FAGREGARPROV : Form
    {
        public FAGREGARPROV()
        {
            InitializeComponent();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            if (TNOMBRES.Text == String.Empty || TAPELLIDOS.Text == String.Empty || TCIUDAD.Text == String.Empty || TCIUDAD.Text == String.Empty || TTELEFONO.Text == String.Empty)
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            { 
            try
            {
               
                    DATOSPROVEEDORES k = new DATOSPROVEEDORES();
                    k.INSERTARPROVEEDOR(TNOMBRES.Text, TAPELLIDOS.Text,TDIRECCION.Text,TCIUDAD.Text, TTELEFONO.Text);
                    MessageBox.Show("DATOS AGREGADOS CORRECTAMENTE");
                    this.Close();

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
                 }

            }

        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAGREGARPROV_Load(object sender, EventArgs e)
        {

        }
    }
}