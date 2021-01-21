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
    public partial class FINICIO : Form
    {
        
       public string USUARIO, CLAVE;
        public FINICIO()
        {
            InitializeComponent();
        }
        
      

        private void BENTRAR_Click(object sender, EventArgs e)
        {
            SCXPPJEntitiesPJ CONTEXT = new SCXPPJEntitiesPJ();
            if (TUSUARIO.Text == string.Empty)
            {
                MessageBox.Show("INGRESE EL USUARIO");
            }
            else
            {
                var USER = CONTEXT.USUARIOSPJs.Where(A => A.USUARIO.Equals(TUSUARIO.Text)).FirstOrDefault();
                if (USER == null)
                {
                    MessageBox.Show("EL USUARIO NO ES CORRECTO");
                }
                else
                {
                    if (USER.CLAVE.Equals(TCLAVE.Text))
                    {
                        FMENUPRI F = new FMENUPRI();
                        F.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("LA CONTRASEÑA NO ES CORRECTA");
                    }
                }
            }






        }



        private void TUSUARIO_TextChanged(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORUSUARIO(TUSUARIO.Text);
        }

        private void TCLAVE_TextChanged(object sender, EventArgs e)
        {
           DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORCLAVE(TCLAVE.Text);
        }

        private void FINICIO_Load(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();

            DAGVUSUARIOS.Columns[1].Visible = false;
        
            TCLAVE.PasswordChar = '*';
        }
       
    }
}

