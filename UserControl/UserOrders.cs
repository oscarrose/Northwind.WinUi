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
    public partial class UserOrders : UserControl
    {
        //Estabaleciendo lo que van asignar valores a los text
        public int CustomerID
        {

            get => Int32.Parse(BTextBoxCustomerID.Text);
            set => BTextBoxCustomerID.Text = value.ToString();
        }
        public int EmployeeID
        {
            get => Int32.Parse(BTextBoxEmployeeID.Text);

            set => BTextBoxEmployeeID.Text = value.ToString();
        }
        public int ShipVia
        {
            get => Int32.Parse(BTextShipVia.Text);
            set => BTextShipVia.Text = value.ToString();
        }
        public decimal Freight
        {
            get => decimal.Parse(BTextBoxFreight.Text);
            set => BTextBoxFreight.Text = value.ToString();
        }
        public string ShipName
        {
            get => BTextShipVia.Text;
            set => BTextShipVia.Text = value;
        }
        public string ShipAddress
        {
            get => BTextShipVia.Text;
            set => BTextShipVia.Text = value;
        }
        public string ShipCity
        {
            get => BTextBoxShipCity.Text;
            set => BTextBoxShipCity.Text = value;
        }
        public string ShipRegion
        {
            get => BTextBoxShipRegion.Text;
            set => BTextBoxShipRegion.Text = value;
        }
        public string ShipPostalCode { get => BTextBoxShipPostalCode.Text;
            set => BTextBoxShipPostalCode.Text = value;
        }




        public UserOrders()
        {
            InitializeComponent();
            BTextBoxCustomerID.TextChanged+= bunifuMaterialTextbox_TextChanged;



            string[] data = { "1", "59 rue de l'Abbaye", "Reims", "Este", "51100", "France", "829-898-2596" };
            for (int i = 0; i < 100; i++)
            {
                DtGridViewCustomer.Rows.Add(data);


            }


            string[] data1 = { "1", "Mr.", "Dr." };
            for (int i = 0; i < 100; i++)
            {
                DtGridViewEmployee.Rows.Add(data1);


            }
        }

        private void bunifuMaterialTextbox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((TextBox)sender, "");
        }


        private void UserOrders_Load(object sender, EventArgs e)
        {
                
        }


        private void BtnSaveOrders_Click(object sender, EventArgs e)
        {
            bool Isvalid = true;

            if (String.IsNullOrEmpty(BTextBoxCustomerID.Text))
            {
                errorProvider1.SetError(BTextBoxCustomerID,"The CustomerID is required");
                Isvalid = false;

            }


            if (String.IsNullOrEmpty(BTextBoxEmployeeID.Text))
            {
                errorProvider1.SetError(BTextBoxEmployeeID, "The EmployeeID is required");
                Isvalid = false;

            }


            if (String.IsNullOrEmpty(BTextShipVia.Text))
            {
                errorProvider1.SetError(BTextShipVia,"The Ship Via is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxFreight.Text))
            {
                errorProvider1.SetError(BTextBoxFreight, "The Freight is required");
                Isvalid = false;



            }
            if (String.IsNullOrEmpty(BTextBoxShipName.Text))
            {
                errorProvider1.SetError(BTextBoxShipName, "The Ship Name is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxShipAddress.Text))
            {
                errorProvider1.SetError(BTextBoxShipAddress, "The Ship Address is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxShipCity.Text))
            {
                errorProvider1.SetError(BTextBoxShipCity, "The Ship Ship City is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxShipRegion.Text))
            {
                errorProvider1.SetError(BTextBoxShipRegion, "The Ship Region is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxShipPostalCode.Text))
            {
                errorProvider1.SetError(BTextBoxShipPostalCode, "The Ship Postal Code is required");
                Isvalid = false;

            }
            if (String.IsNullOrEmpty(BTextBoxShipCountry.Text))
            {
                errorProvider1.SetError(BTextBoxShipCountry, "The  Ship Country is required");
                Isvalid = false;



            }

            if (Isvalid)
            {

                var Result = BtnSaveOrders.DialogResult;
                

                eventium.notificaciones frmnotificacion = new eventium.notificaciones("successfully saved");
                DialogResult resultado = frmnotificacion.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    frmnotificacion.Close();


                }




            }
        }


        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            var FormCustomer = new ModelCustomer();
            var result = FormCustomer.ShowDialog();
           
        }

    }


}
