
namespace KeyAuth_Admin_Panel
{
    partial class ConnectKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectKey));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.addapppanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.appkey = new Guna.UI2.WinForms.Guna2TextBox();
            this.appname = new Guna.UI2.WinForms.Guna2TextBox();
            this.savenewapp = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeformsg = new System.Windows.Forms.Timer(this.components);
            this.msgpanel = new Guna.UI2.WinForms.Guna2Transition();
            this.newapp = new Guna.UI2.WinForms.Guna2Button();
            this.loadapp = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.social = new System.Windows.Forms.LinkLabel();
            this.messageboxx = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.animation = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.addapppanel.SuspendLayout();
            this.messageboxx.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.addapppanel;
            // 
            // addapppanel
            // 
            this.addapppanel.Controls.Add(this.label4);
            this.addapppanel.Controls.Add(this.back);
            this.addapppanel.Controls.Add(this.appkey);
            this.addapppanel.Controls.Add(this.appname);
            this.addapppanel.Controls.Add(this.savenewapp);
            this.addapppanel.Controls.Add(this.label3);
            this.animation.SetDecoration(this.addapppanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.addapppanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addapppanel.Location = new System.Drawing.Point(12, 50);
            this.addapppanel.Name = "addapppanel";
            this.addapppanel.Size = new System.Drawing.Size(345, 365);
            this.addapppanel.TabIndex = 18;
            this.addapppanel.Visible = false;
            this.addapppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addapppanel_Paint);
            // 
            // label4
            // 
            this.msgpanel.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Here make save your new app credentials";
            // 
            // back
            // 
            this.back.Animated = true;
            this.back.BorderColor = System.Drawing.Color.White;
            this.back.BorderRadius = 9;
            this.back.CheckedState.Parent = this.back;
            this.back.CustomImages.Parent = this.back;
            this.animation.SetDecoration(this.back, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.back, Guna.UI2.AnimatorNS.DecorationType.None);
            this.back.DisabledState.Parent = this.back;
            this.back.FillColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.HoverState.Parent = this.back;
            this.back.ImageSize = new System.Drawing.Size(25, 25);
            this.back.Location = new System.Drawing.Point(13, 311);
            this.back.Name = "back";
            this.back.ShadowDecoration.Parent = this.back;
            this.back.Size = new System.Drawing.Size(318, 35);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // appkey
            // 
            this.appkey.Animated = true;
            this.appkey.BorderRadius = 9;
            this.appkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.appkey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.appkey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.appkey.DefaultText = "";
            this.appkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.appkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.appkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appkey.DisabledState.Parent = this.appkey;
            this.appkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appkey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.appkey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appkey.FocusedState.Parent = this.appkey;
            this.appkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appkey.ForeColor = System.Drawing.Color.White;
            this.appkey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appkey.HoverState.Parent = this.appkey;
            this.appkey.Location = new System.Drawing.Point(13, 154);
            this.appkey.Name = "appkey";
            this.appkey.PasswordChar = '\0';
            this.appkey.PlaceholderText = "App Seller Key";
            this.appkey.SelectedText = "";
            this.appkey.ShadowDecoration.Parent = this.appkey;
            this.appkey.Size = new System.Drawing.Size(318, 41);
            this.appkey.TabIndex = 9;
            // 
            // appname
            // 
            this.appname.Animated = true;
            this.appname.BorderRadius = 9;
            this.appname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.appname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.appname, Guna.UI2.AnimatorNS.DecorationType.None);
            this.appname.DefaultText = "";
            this.appname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.appname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.appname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appname.DisabledState.Parent = this.appname;
            this.appname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.appname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appname.FocusedState.Parent = this.appname;
            this.appname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appname.ForeColor = System.Drawing.Color.White;
            this.appname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appname.HoverState.Parent = this.appname;
            this.appname.Location = new System.Drawing.Point(13, 94);
            this.appname.Name = "appname";
            this.appname.PasswordChar = '\0';
            this.appname.PlaceholderText = "App Name";
            this.appname.SelectedText = "";
            this.appname.ShadowDecoration.Parent = this.appname;
            this.appname.Size = new System.Drawing.Size(318, 41);
            this.appname.TabIndex = 8;
            // 
            // savenewapp
            // 
            this.savenewapp.Animated = true;
            this.savenewapp.BorderColor = System.Drawing.Color.White;
            this.savenewapp.BorderRadius = 9;
            this.savenewapp.CheckedState.Parent = this.savenewapp;
            this.savenewapp.CustomImages.Parent = this.savenewapp;
            this.animation.SetDecoration(this.savenewapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.savenewapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.savenewapp.DisabledState.Parent = this.savenewapp;
            this.savenewapp.FillColor = System.Drawing.Color.Red;
            this.savenewapp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.savenewapp.ForeColor = System.Drawing.Color.White;
            this.savenewapp.HoverState.Parent = this.savenewapp;
            this.savenewapp.ImageSize = new System.Drawing.Size(25, 25);
            this.savenewapp.Location = new System.Drawing.Point(13, 221);
            this.savenewapp.Name = "savenewapp";
            this.savenewapp.ShadowDecoration.Parent = this.savenewapp;
            this.savenewapp.Size = new System.Drawing.Size(318, 47);
            this.savenewapp.TabIndex = 7;
            this.savenewapp.Text = "Save Application";
            this.savenewapp.Click += new System.EventHandler(this.savenewapp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.msgpanel.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create And Save New App";
            // 
            // timeformsg
            // 
            this.timeformsg.Interval = 2700;
            this.timeformsg.Tick += new System.EventHandler(this.timeformsg_Tick);
            // 
            // msgpanel
            // 
            this.msgpanel.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.msgpanel.Cursor = null;
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
            this.msgpanel.DefaultAnimation = animation1;
            // 
            // newapp
            // 
            this.newapp.Animated = true;
            this.newapp.BorderColor = System.Drawing.Color.White;
            this.newapp.BorderRadius = 9;
            this.newapp.CheckedState.Parent = this.newapp;
            this.newapp.CustomImages.Parent = this.newapp;
            this.animation.SetDecoration(this.newapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.newapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.newapp.DisabledState.Parent = this.newapp;
            this.newapp.FillColor = System.Drawing.Color.Red;
            this.newapp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newapp.ForeColor = System.Drawing.Color.White;
            this.newapp.HoverState.Parent = this.newapp;
            this.newapp.Image = ((System.Drawing.Image)(resources.GetObject("newapp.Image")));
            this.newapp.ImageSize = new System.Drawing.Size(25, 25);
            this.newapp.Location = new System.Drawing.Point(17, 266);
            this.newapp.Name = "newapp";
            this.newapp.ShadowDecoration.Parent = this.newapp;
            this.newapp.Size = new System.Drawing.Size(333, 55);
            this.newapp.TabIndex = 16;
            this.newapp.Text = "New App";
            this.newapp.Click += new System.EventHandler(this.newapp_Click);
            // 
            // loadapp
            // 
            this.loadapp.Animated = true;
            this.loadapp.BorderColor = System.Drawing.Color.White;
            this.loadapp.BorderRadius = 9;
            this.loadapp.CheckedState.Parent = this.loadapp;
            this.loadapp.CustomImages.Parent = this.loadapp;
            this.animation.SetDecoration(this.loadapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.loadapp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadapp.DisabledState.Parent = this.loadapp;
            this.loadapp.FillColor = System.Drawing.Color.Red;
            this.loadapp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadapp.ForeColor = System.Drawing.Color.White;
            this.loadapp.HoverState.Parent = this.loadapp;
            this.loadapp.Image = ((System.Drawing.Image)(resources.GetObject("loadapp.Image")));
            this.loadapp.ImageSize = new System.Drawing.Size(25, 25);
            this.loadapp.Location = new System.Drawing.Point(20, 343);
            this.loadapp.Name = "loadapp";
            this.loadapp.ShadowDecoration.Parent = this.loadapp;
            this.loadapp.Size = new System.Drawing.Size(333, 55);
            this.loadapp.TabIndex = 14;
            this.loadapp.Text = "Load name";
            this.loadapp.Click += new System.EventHandler(this.loadapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.msgpanel.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome Back, Admin";
            // 
            // social
            // 
            this.social.AutoSize = true;
            this.msgpanel.SetDecoration(this.social, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation.SetDecoration(this.social, Guna.UI2.AnimatorNS.DecorationType.None);
            this.social.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.social.LinkColor = System.Drawing.Color.White;
            this.social.Location = new System.Drawing.Point(109, 419);
            this.social.Name = "social";
            this.social.Size = new System.Drawing.Size(155, 21);
            this.social.TabIndex = 13;
            this.social.TabStop = true;
            this.social.Text = "Made by MajorHax";
            this.social.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.social_LinkClicked);
            // 
            // messageboxx
            // 
            this.messageboxx.Controls.Add(this.label5);
            this.animation.SetDecoration(this.messageboxx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.messageboxx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.messageboxx.Location = new System.Drawing.Point(12, 518);
            this.messageboxx.Name = "messageboxx";
            this.messageboxx.Size = new System.Drawing.Size(64, 10);
            this.messageboxx.TabIndex = 19;
            // 
            // label5
            // 
            this.msgpanel.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 41);
            this.label5.TabIndex = 20;
            this.label5.Text = ".";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animation.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(315, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 20;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // animation
            // 
            this.animation.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animation.DefaultAnimation = animation2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // ConnectKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(372, 453);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.newapp);
            this.Controls.Add(this.messageboxx);
            this.Controls.Add(this.loadapp);
            this.Controls.Add(this.addapppanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.social);
            this.animation.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.msgpanel.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupAdminPanel";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.addapppanel.ResumeLayout(false);
            this.addapppanel.PerformLayout();
            this.messageboxx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Panel addapppanel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Transition msgpanel;
        private Guna.UI2.WinForms.Guna2Transition animation;
        private Guna.UI2.WinForms.Guna2Button back;
        private Guna.UI2.WinForms.Guna2TextBox appkey;
        private Guna.UI2.WinForms.Guna2TextBox appname;
        private Guna.UI2.WinForms.Guna2Button savenewapp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timeformsg;
        private Guna.UI2.WinForms.Guna2Button newapp;
        private Guna.UI2.WinForms.Guna2Button loadapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel social;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel messageboxx;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}