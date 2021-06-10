
namespace Northwind.WinUi
{
    partial class UserListerOrders
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListerOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DataGriewOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSearch.HintForeColor = System.Drawing.Color.Black;
            this.TxtSearch.HintText = "Search";
            this.TxtSearch.isPassword = false;
            this.TxtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtSearch.LineThickness = 5;
            this.TxtSearch.Location = new System.Drawing.Point(49, 33);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(257, 33);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(25, 37);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 29);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // DataGriewOrders
            // 
            this.DataGriewOrders.AllowUserToAddRows = false;
            this.DataGriewOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGriewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGriewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGriewOrders.BackgroundColor = System.Drawing.Color.White;
            this.DataGriewOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGriewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGriewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGriewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGriewOrders.ColumnHeadersHeight = 77;
            this.DataGriewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrderID,
            this.ColumnCustomerID,
            this.ColumnEmployeeID,
            this.ColumnOrderDate,
            this.ColumnRequiredDate,
            this.ColumnShippedDate,
            this.ColumnShipVia,
            this.ColumnFreight,
            this.ColumnShipName,
            this.ColumnShipAddress,
            this.ColumnShipCity,
            this.ColumnShipRegion,
            this.ColumnShipPostalCode,
            this.ColumnShipCountry});
            this.DataGriewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGriewOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGriewOrders.EnableHeadersVisualStyles = false;
            this.DataGriewOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGriewOrders.Location = new System.Drawing.Point(3, 91);
            this.DataGriewOrders.MultiSelect = false;
            this.DataGriewOrders.Name = "DataGriewOrders";
            this.DataGriewOrders.ReadOnly = true;
            this.DataGriewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGriewOrders.RowHeadersVisible = false;
            this.DataGriewOrders.RowHeadersWidth = 51;
            this.DataGriewOrders.RowTemplate.Height = 24;
            this.DataGriewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGriewOrders.Size = new System.Drawing.Size(1212, 727);
            this.DataGriewOrders.TabIndex = 18;
            this.DataGriewOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGriewOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGriewOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGriewOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGriewOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGriewOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGriewOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGriewOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGriewOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGriewOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGriewOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGriewOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGriewOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGriewOrders.ThemeStyle.HeaderStyle.Height = 77;
            this.DataGriewOrders.ThemeStyle.ReadOnly = true;
            this.DataGriewOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGriewOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGriewOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGriewOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGriewOrders.ThemeStyle.RowsStyle.Height = 24;
            this.DataGriewOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGriewOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGriewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewOrders_CellContentClick_2);
            // 
            // ColumnOrderID
            // 
            this.ColumnOrderID.HeaderText = "Order ID";
            this.ColumnOrderID.MinimumWidth = 6;
            this.ColumnOrderID.Name = "ColumnOrderID";
            this.ColumnOrderID.ReadOnly = true;
            // 
            // ColumnCustomerID
            // 
            this.ColumnCustomerID.HeaderText = "Customer ID";
            this.ColumnCustomerID.MinimumWidth = 6;
            this.ColumnCustomerID.Name = "ColumnCustomerID";
            this.ColumnCustomerID.ReadOnly = true;
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.HeaderText = "Employee ID";
            this.ColumnEmployeeID.MinimumWidth = 6;
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.ReadOnly = true;
            // 
            // ColumnOrderDate
            // 
            this.ColumnOrderDate.HeaderText = "Order Date";
            this.ColumnOrderDate.MinimumWidth = 6;
            this.ColumnOrderDate.Name = "ColumnOrderDate";
            this.ColumnOrderDate.ReadOnly = true;
            // 
            // ColumnRequiredDate
            // 
            this.ColumnRequiredDate.HeaderText = "Required Date";
            this.ColumnRequiredDate.MinimumWidth = 6;
            this.ColumnRequiredDate.Name = "ColumnRequiredDate";
            this.ColumnRequiredDate.ReadOnly = true;
            // 
            // ColumnShippedDate
            // 
            this.ColumnShippedDate.HeaderText = "Shipped Date";
            this.ColumnShippedDate.MinimumWidth = 6;
            this.ColumnShippedDate.Name = "ColumnShippedDate";
            this.ColumnShippedDate.ReadOnly = true;
            // 
            // ColumnShipVia
            // 
            this.ColumnShipVia.HeaderText = "Ship Via";
            this.ColumnShipVia.MinimumWidth = 6;
            this.ColumnShipVia.Name = "ColumnShipVia";
            this.ColumnShipVia.ReadOnly = true;
            // 
            // ColumnFreight
            // 
            this.ColumnFreight.HeaderText = "Freight";
            this.ColumnFreight.MinimumWidth = 6;
            this.ColumnFreight.Name = "ColumnFreight";
            this.ColumnFreight.ReadOnly = true;
            // 
            // ColumnShipName
            // 
            this.ColumnShipName.HeaderText = "Ship Name";
            this.ColumnShipName.MinimumWidth = 6;
            this.ColumnShipName.Name = "ColumnShipName";
            this.ColumnShipName.ReadOnly = true;
            // 
            // ColumnShipAddress
            // 
            this.ColumnShipAddress.HeaderText = "Ship Address";
            this.ColumnShipAddress.MinimumWidth = 6;
            this.ColumnShipAddress.Name = "ColumnShipAddress";
            this.ColumnShipAddress.ReadOnly = true;
            // 
            // ColumnShipCity
            // 
            this.ColumnShipCity.HeaderText = "Ship City";
            this.ColumnShipCity.MinimumWidth = 6;
            this.ColumnShipCity.Name = "ColumnShipCity";
            this.ColumnShipCity.ReadOnly = true;
            // 
            // ColumnShipRegion
            // 
            this.ColumnShipRegion.HeaderText = "Ship Region";
            this.ColumnShipRegion.MinimumWidth = 6;
            this.ColumnShipRegion.Name = "ColumnShipRegion";
            this.ColumnShipRegion.ReadOnly = true;
            // 
            // ColumnShipPostalCode
            // 
            this.ColumnShipPostalCode.HeaderText = "Ship Posta lCode";
            this.ColumnShipPostalCode.MinimumWidth = 6;
            this.ColumnShipPostalCode.Name = "ColumnShipPostalCode";
            this.ColumnShipPostalCode.ReadOnly = true;
            // 
            // ColumnShipCountry
            // 
            this.ColumnShipCountry.HeaderText = "Ship Country";
            this.ColumnShipCountry.MinimumWidth = 6;
            this.ColumnShipCountry.Name = "ColumnShipCountry";
            this.ColumnShipCountry.ReadOnly = true;
            // 
            // UserListerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DataGriewOrders);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.TxtSearch);
            this.Name = "UserListerOrders";
            this.Size = new System.Drawing.Size(1255, 841);
            this.Load += new System.EventHandler(this.UserListerOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGriewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShipCountry;
    }
}
