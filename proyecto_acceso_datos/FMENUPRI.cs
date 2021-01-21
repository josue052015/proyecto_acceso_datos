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
    public partial class FMENUPRI : Form
    {
        public FMENUPRI()
        {
            InitializeComponent();
        }

        private void FMENUPRI_Load(object sender, EventArgs e)
        {

        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPROVEEDORES J = new FPROVEEDORES();
            J.Show();
            this.Hide();
        }

        private void BOPCIONES_Click(object sender, EventArgs e)
        {
            
            if (BCERRARS.Visible == true)
            {
                BCERRARS.Visible = false;
            }
            else
            {
                BCERRARS.Visible = true;
            }

        }

        private void BCERRARS_Click(object sender, EventArgs e)
        {
            FINICIO J = new FINICIO();
            J.Show();
            this.Hide();
        }

       

        private void mANTENIMIENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FFACTURAS J = new FFACTURAS();
            J.Show();
            this.Hide();
        }

        private void mANTENIMIENTOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCHEQUES J = new FCHEQUES();
            J.Show();
            this.Hide();
        }

        private void eSTADODECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FESTADODECUENTAS J = new FESTADODECUENTAS();
            J.Show();
            this.Hide();
        }

        private void rEPORTEDEPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPROVEEDORES J = new FRPROVEEDORES();
            J.Show();
            this.Hide();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 J = new Form2();
            J.Show();
            this.Hide();
        }

        private void rEPORTEDEESTADODECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRESTADOCUENTAS J = new FRESTADOCUENTAS();
            J.Show();
            this.Hide();
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRCHEQUES J = new FRCHEQUES();
            J.Show();
            this.Hide();
        }

        private void rEPORTEESTADODECUETASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRESTADOCUENTAS J = new FRESTADOCUENTAS();
            J.Show();
            this.Hide();
        }
    }
}
