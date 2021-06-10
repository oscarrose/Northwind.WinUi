
namespace eventium
{
    partial class notificaciones
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificaciones));
            this.frmesclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.closeSuccess = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmesclarecer
            // 
            this.frmesclarecer.Delay = 0;
            // 
            // closeSuccess
            // 
            this.closeSuccess.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeSuccess.BorderRadius = 4;
            this.closeSuccess.ButtonText = "Acept";
            this.closeSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.closeSuccess, Guna.UI2.AnimatorNS.DecorationType.None);
            this.closeSuccess.DisabledColor = System.Drawing.Color.Gray;
            this.closeSuccess.Iconcolor = System.Drawing.Color.Transparent;
            this.closeSuccess.Iconimage = null;
            this.closeSuccess.Iconimage_right = null;
            this.closeSuccess.Iconimage_right_Selected = null;
            this.closeSuccess.Iconimage_Selected = null;
            this.closeSuccess.IconMarginLeft = 0;
            this.closeSuccess.IconMarginRight = 0;
            this.closeSuccess.IconRightVisible = true;
            this.closeSuccess.IconRightZoom = 0D;
            this.closeSuccess.IconVisible = true;
            this.closeSuccess.IconZoom = 90D;
            this.closeSuccess.IsTab = false;
            this.closeSuccess.Location = new System.Drawing.Point(52, 368);
            this.closeSuccess.Margin = new System.Windows.Forms.Padding(5);
            this.closeSuccess.Name = "closeSuccess";
            this.closeSuccess.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.closeSuccess.OnHoverTextColor = System.Drawing.Color.White;
            this.closeSuccess.selected = false;
            this.closeSuccess.Size = new System.Drawing.Size(239, 52);
            this.closeSuccess.TabIndex = 5;
            this.closeSuccess.Text = "Acept";
            this.closeSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeSuccess.Textcolor = System.Drawing.Color.White;
            this.closeSuccess.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSuccess.Click += new System.EventHandler(this.closeSuccess_Click);
            // 
            // lbmensaje
            // 
            this.lbmensaje.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbmensaje, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensaje.ForeColor = System.Drawing.Color.Black;
            this.lbmensaje.Location = new System.Drawing.Point(0, 309);
            this.lbmensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(352, 28);
            this.lbmensaje.TabIndex = 4;
            this.lbmensaje.Text = "MENSAJE";
            this.lbmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbmensaje.Click += new System.EventHandler(this.lbmensaje_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 289);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 446);
            this.Controls.Add(this.closeSuccess);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.notificaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition frmesclarecer;
        private Bunifu.Framework.UI.BunifuFlatButton closeSuccess;
        private System.Windows.Forms.Label lbmensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}