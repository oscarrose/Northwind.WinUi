
namespace Northwind.WinUi
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SlidePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PanelLateralSuperior = new System.Windows.Forms.Panel();
            this.LbNorthwindLogo = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCloseSesion = new System.Windows.Forms.Button();
            this.BtOrders = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.BtListorders = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.LbTitleForm = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SidePanel.SuspendLayout();
            this.PanelLateralSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.SidePanel.Controls.Add(this.SlidePanel);
            this.SidePanel.Controls.Add(this.PanelLateralSuperior);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.BtnCloseSesion);
            this.SidePanel.Controls.Add(this.BtOrders);
            this.SidePanel.Controls.Add(this.btHome);
            this.SidePanel.Controls.Add(this.BtListorders);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(190, 804);
            this.SidePanel.TabIndex = 0;
            // 
            // SlidePanel
            // 
            this.SlidePanel.AutoSize = true;
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(97)))), ((int)(((byte)(126)))));
            this.SlidePanel.BorderRadius = 10;
            this.SlidePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SlidePanel.BorderThickness = 10;
            this.SlidePanel.Location = new System.Drawing.Point(3, 318);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.ShadowDecoration.Parent = this.SlidePanel;
            this.SlidePanel.Size = new System.Drawing.Size(10, 110);
            this.SlidePanel.TabIndex = 0;
            // 
            // PanelLateralSuperior
            // 
            this.PanelLateralSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.PanelLateralSuperior.Controls.Add(this.LbNorthwindLogo);
            this.PanelLateralSuperior.Controls.Add(this.PbLogo);
            this.PanelLateralSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLateralSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelLateralSuperior.Name = "PanelLateralSuperior";
            this.PanelLateralSuperior.Size = new System.Drawing.Size(190, 57);
            this.PanelLateralSuperior.TabIndex = 2;
            // 
            // LbNorthwindLogo
            // 
            this.LbNorthwindLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbNorthwindLogo.AutoSize = true;
            this.LbNorthwindLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNorthwindLogo.ForeColor = System.Drawing.Color.White;
            this.LbNorthwindLogo.Location = new System.Drawing.Point(38, 9);
            this.LbNorthwindLogo.Name = "LbNorthwindLogo";
            this.LbNorthwindLogo.Size = new System.Drawing.Size(152, 36);
            this.LbNorthwindLogo.TabIndex = 1;
            this.LbNorthwindLogo.Text = "Northwind";
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(3, 3);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(42, 47);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCloseSesion
            // 
            this.BtnCloseSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSesion.FlatAppearance.BorderSize = 0;
            this.BtnCloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSesion.Image")));
            this.BtnCloseSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCloseSesion.Location = new System.Drawing.Point(0, 739);
            this.BtnCloseSesion.Name = "BtnCloseSesion";
            this.BtnCloseSesion.Size = new System.Drawing.Size(190, 65);
            this.BtnCloseSesion.TabIndex = 3;
            this.BtnCloseSesion.Text = "Log out";
            this.BtnCloseSesion.UseVisualStyleBackColor = true;
            this.BtnCloseSesion.Click += new System.EventHandler(this.BtnCloseSesion_Click_1);
            // 
            // BtOrders
            // 
            this.BtOrders.FlatAppearance.BorderSize = 0;
            this.BtOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOrders.ForeColor = System.Drawing.Color.White;
            this.BtOrders.Image = ((System.Drawing.Image)(resources.GetObject("BtOrders.Image")));
            this.BtOrders.Location = new System.Drawing.Point(0, 612);
            this.BtOrders.Name = "BtOrders";
            this.BtOrders.Size = new System.Drawing.Size(190, 110);
            this.BtOrders.TabIndex = 2;
            this.BtOrders.Text = "Orders";
            this.BtOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtOrders.UseVisualStyleBackColor = true;
            this.BtOrders.Click += new System.EventHandler(this.BtOrders_Click);
            // 
            // btHome
            // 
            this.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.Location = new System.Drawing.Point(3, 318);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(187, 110);
            this.btHome.TabIndex = 2;
            this.btHome.Text = "Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHome.UseCompatibleTextRendering = true;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // BtListorders
            // 
            this.BtListorders.FlatAppearance.BorderSize = 0;
            this.BtListorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtListorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListorders.ForeColor = System.Drawing.Color.White;
            this.BtListorders.Image = ((System.Drawing.Image)(resources.GetObject("BtListorders.Image")));
            this.BtListorders.Location = new System.Drawing.Point(3, 465);
            this.BtListorders.Name = "BtListorders";
            this.BtListorders.Size = new System.Drawing.Size(187, 110);
            this.BtListorders.TabIndex = 2;
            this.BtListorders.Text = "List orders";
            this.BtListorders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtListorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtListorders.UseVisualStyleBackColor = true;
            this.BtListorders.Click += new System.EventHandler(this.BtListorders_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.guna2Button3);
            this.TopPanel.Controls.Add(this.guna2Button2);
            this.TopPanel.Controls.Add(this.BtnClose);
            this.TopPanel.Controls.Add(this.LbTitleForm);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(190, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1140, 57);
            this.TopPanel.TabIndex = 1;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.Animated = true;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button3.Location = new System.Drawing.Point(911, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(55, 51);
            this.guna2Button3.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button2.Location = new System.Drawing.Point(1006, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(55, 51);
            this.guna2Button2.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Animated = true;
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FillColor = System.Drawing.Color.Transparent;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnClose.Location = new System.Drawing.Point(1085, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(55, 57);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LbTitleForm
            // 
            this.LbTitleForm.AutoSize = true;
            this.LbTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleForm.Location = new System.Drawing.Point(3, 14);
            this.LbTitleForm.Name = "LbTitleForm";
            this.LbTitleForm.Size = new System.Drawing.Size(76, 36);
            this.LbTitleForm.TabIndex = 1;
            this.LbTitleForm.Text = "Title";
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(190, 57);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1140, 747);
            this.BodyPanel.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1330, 804);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.PanelLateralSuperior.ResumeLayout(false);
            this.PanelLateralSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LbNorthwindLogo;
        private System.Windows.Forms.Label LbTitleForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button BtListorders;
        private System.Windows.Forms.Button BtOrders;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button BtnCloseSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel PanelLateralSuperior;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GradientPanel SlidePanel;
    }
}

