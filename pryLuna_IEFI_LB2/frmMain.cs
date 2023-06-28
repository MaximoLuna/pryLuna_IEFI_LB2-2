using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_IEFI_LB2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            ClsConectarBD objConn = new ClsConectarBD();
            objConn.cargarCombo(cmbPaises);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtApellido.Enabled = true;
            }
            else
            {
                txtApellido.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                cmbPaises.Enabled = true;
            }
            else
            {
                cmbPaises.Enabled = false;
            }
        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {
            if (nudEdad.Value != 0)
            {
                mrcSexo.Enabled = true;
            }
            else
            {
                mrcSexo.Enabled = false;
            }
        }
    }
}
