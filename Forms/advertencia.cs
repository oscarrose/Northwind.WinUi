using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventium
{
    public partial class advertencia : Form
    {
        public advertencia(string mensaje)
        {
            InitializeComponent();
            lbmensaje.Text = mensaje;
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void advertencia_Load(object sender, EventArgs e)
        {
            frmaclarecer.ShowAsyc(this);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lbmensaje_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
