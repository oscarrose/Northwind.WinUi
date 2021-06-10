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
    public partial class notificaciones : Form
    {
        public notificaciones(string mensaje)
        {
            InitializeComponent();
            lbmensaje.Text = mensaje;
        }

        private void notificaciones_Load(object sender, EventArgs e)
        {
            frmesclarecer.ShowAsyc(this);
            this.TopMost = true;
        }
        
        private static void notiConfirmar(string mensaje)
        {
            //metodo para recibir un mensaje de confirmacion desde otro formulario
            notificaciones frmnotificacion = new notificaciones(mensaje);
            frmnotificacion.ShowDialog();
        
        
        
        }
        private void closeSuccess_Click(object sender, EventArgs e)
        {

            closeSuccess.Enabled = false;
            this.Close();
        }

        private void lbmensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
