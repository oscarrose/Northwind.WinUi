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
    public partial class UserListerOrders : UserControl
    {
        string[] data = { "1", "2", "1996-07-04", "1996-08-01", "1996-07-16", "2", "32.38", "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "Este", "51100", "France","Paris" };
        public UserListerOrders()
        {
            InitializeComponent();
        }

        private void UserListerOrders_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 100; i++)
            {
                DataGriewOrders.Rows.Add(data);


            }


        }

        private void DataGriewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGriewOrders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void DataGriewOrders_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
