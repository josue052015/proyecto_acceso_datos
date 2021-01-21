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
    public partial class FAGREGARFACT : Form
    {
        public FAGREGARFACT()
        {
            InitializeComponent();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            if (TVALOR.Text == String.Empty || TCODIGO .Text == String.Empty)
            {
                MessageBox.Show("FALTAN DATOS");
            }
            else
            {
                
                try
                {
                    

                    DATOSFACTURA2 J = new DATOSFACTURA2();
                    J.INSERTARFACTURA(Convert.ToInt32(TCODIGO.Text),Convert.ToDecimal(TVALOR.Text),Convert.ToDateTime(TFFA.Text),Convert.ToDateTime(TFV.Text));
                    MessageBox.Show("DATOS AGREGADOS CORRECTAMENTE");
                    FFACTURAS P = new FFACTURAS();
                    P.Show();
                    this.Hide();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void FAGREGARFACT_Load(object sender, EventArgs e)
        {
            String DIA;
            DIA = DateTime.Today.ToString();
            TFFA.Text = DIA;
            TFV.Text = DIA;
        }

        private void BCANCELAR_Click(object sender, EventArgs e)
        {
            FFACTURAS J = new FFACTURAS();
            J.Show();
            this.Hide();
        }
    }
}
