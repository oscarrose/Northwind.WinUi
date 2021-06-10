using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUi
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamada del metodo FullScreen
            FullScreen();

        }

        public void FullScreen()
        {
            //Metodo para poner pantalla completa solo cubra el area de trabajo
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

        }
        /// <summary>
        /// Metodo para agregar el UserControl al panel
        /// </summary>
        /// <param name="control">Recibe un controlador como parametro</param>
        public void ShowUser(Control control)
        { 
            BodyPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            BodyPanel.Controls.Add(control);



        }
       
       /// <summary>
       /// Metodo para mover la flecha a la posicion del button
       /// </summary>
       /// <param name="button">Recibe un button como parametro</param>
        public void Arrow(Button button)
        {
            
            SlidePanel.Height = button.Height;
            SlidePanel.Top = button.Top;
        }
        private void BtListorders_Click(object sender, EventArgs e)
        {
            Arrow(BtListorders);
            UserListerOrders formListerOrders = new UserListerOrders();
            ShowUser(formListerOrders);
            LbTitleForm.Text = "Lister Orders";

        }

        private void BtOrders_Click(object sender, EventArgs e)
        {
            Arrow(BtOrders);
            UserOrders frmOrder = new UserOrders();
            ShowUser(frmOrder);
            LbTitleForm.Text = "Orders";

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Arrow(btHome);
            UserOfHome poster = new UserOfHome();
            ShowUser(poster);
            LbTitleForm.Text = "Inicio";
        }

      

        private void BtnClose_Click(object sender, EventArgs e)
        {
            eventium.advertencia frmadvertencia = new eventium.advertencia("You want to close the application");
            DialogResult resultado = frmadvertencia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
               Application.Exit();


            }
        }

        private void BtnCloseSesion_Click_1(object sender, EventArgs e)
        {
            eventium.advertencia frmadvertencia = new eventium.advertencia("You want to close the session");
            DialogResult resultado = frmadvertencia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Close();


            }
        }
    }
}
