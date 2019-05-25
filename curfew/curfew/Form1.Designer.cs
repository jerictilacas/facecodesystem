namespace curfew
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slidepanelanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toppanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.resdownbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizer = new Bunifu.Framework.UI.BunifuImageButton();
            this.container = new System.Windows.Forms.PictureBox();
            this.ucpanel = new System.Windows.Forms.Panel();
            this.slidepanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.accbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.recordbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.resaddbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resdownbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.slidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidepanelanimator
            // 
            this.slidepanelanimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.slidepanelanimator.Cursor = null;
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
            this.slidepanelanimator.DefaultAnimation = animation1;
            this.slidepanelanimator.Interval = 15;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.toppanel.Controls.Add(this.bunifuCustomLabel2);
            this.toppanel.Controls.Add(this.bunifuCustomLabel1);
            this.toppanel.Controls.Add(this.exitbtn);
            this.toppanel.Controls.Add(this.resdownbtn);
            this.toppanel.Controls.Add(this.minimizer);
            this.toppanel.Controls.Add(this.container);
            this.slidepanelanimator.SetDecoration(this.toppanel, BunifuAnimatorNS.DecorationType.None);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1137, 87);
            this.toppanel.TabIndex = 13;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.slidepanelanimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(215, 29);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 29);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "®";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.slidepanelanimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Clear Sans Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(47, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(531, 52);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "faceCode    Offense Recognizer";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.slidepanelanimator.SetDecoration(this.exitbtn, BunifuAnimatorNS.DecorationType.None);
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageActive = null;
            this.exitbtn.Location = new System.Drawing.Point(1008, 3);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(25, 25);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtn.TabIndex = 2;
            this.exitbtn.TabStop = false;
            this.exitbtn.Zoom = 10;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // resdownbtn
            // 
            this.resdownbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resdownbtn.BackColor = System.Drawing.Color.Transparent;
            this.slidepanelanimator.SetDecoration(this.resdownbtn, BunifuAnimatorNS.DecorationType.None);
            this.resdownbtn.Image = ((System.Drawing.Image)(resources.GetObject("resdownbtn.Image")));
            this.resdownbtn.ImageActive = null;
            this.resdownbtn.Location = new System.Drawing.Point(957, 0);
            this.resdownbtn.Name = "resdownbtn";
            this.resdownbtn.Size = new System.Drawing.Size(32, 31);
            this.resdownbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resdownbtn.TabIndex = 3;
            this.resdownbtn.TabStop = false;
            this.resdownbtn.Zoom = 10;
            // 
            // minimizer
            // 
            this.minimizer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimizer.BackColor = System.Drawing.Color.Transparent;
            this.slidepanelanimator.SetDecoration(this.minimizer, BunifuAnimatorNS.DecorationType.None);
            this.minimizer.Image = ((System.Drawing.Image)(resources.GetObject("minimizer.Image")));
            this.minimizer.ImageActive = null;
            this.minimizer.Location = new System.Drawing.Point(908, 16);
            this.minimizer.Name = "minimizer";
            this.minimizer.Size = new System.Drawing.Size(36, 10);
            this.minimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizer.TabIndex = 4;
            this.minimizer.TabStop = false;
            this.minimizer.Zoom = 10;
            this.minimizer.Click += new System.EventHandler(this.minimizer_Click);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.slidepanelanimator.SetDecoration(this.container, BunifuAnimatorNS.DecorationType.None);
            this.container.Image = ((System.Drawing.Image)(resources.GetObject("container.Image")));
            this.container.Location = new System.Drawing.Point(820, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(318, 36);
            this.container.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.container.TabIndex = 0;
            this.container.TabStop = false;
            this.container.Click += new System.EventHandler(this.container_Click);
            // 
            // ucpanel
            // 
            this.slidepanelanimator.SetDecoration(this.ucpanel, BunifuAnimatorNS.DecorationType.None);
            this.ucpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucpanel.Location = new System.Drawing.Point(60, 87);
            this.ucpanel.Name = "ucpanel";
            this.ucpanel.Size = new System.Drawing.Size(1077, 547);
            this.ucpanel.TabIndex = 12;
            this.ucpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ucpanel_Paint_1);
            // 
            // slidepanel
            // 
            this.slidepanel.BackColor = System.Drawing.Color.Transparent;
            this.slidepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slidepanel.BackgroundImage")));
            this.slidepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidepanel.Controls.Add(this.bunifuFlatButton3);
            this.slidepanel.Controls.Add(this.bunifuFlatButton2);
            this.slidepanel.Controls.Add(this.bunifuiOSSwitch1);
            this.slidepanel.Controls.Add(this.bunifuFlatButton1);
            this.slidepanel.Controls.Add(this.accbtn);
            this.slidepanel.Controls.Add(this.recordbtn);
            this.slidepanel.Controls.Add(this.resaddbtn);
            this.slidepanelanimator.SetDecoration(this.slidepanel, BunifuAnimatorNS.DecorationType.None);
            this.slidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidepanel.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.slidepanel.GradientBottomRight = System.Drawing.Color.Transparent;
            this.slidepanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(200)))), ((int)(((byte)(218)))));
            this.slidepanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(200)))), ((int)(((byte)(218)))));
            this.slidepanel.Location = new System.Drawing.Point(0, 87);
            this.slidepanel.Name = "slidepanel";
            this.slidepanel.Quality = 10;
            this.slidepanel.Size = new System.Drawing.Size(60, 547);
            this.slidepanel.TabIndex = 11;
            this.slidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slidepanel_Paint);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 13;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 65D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 466);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(60, 81);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "  Logout";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 20;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 57D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 370);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(210, 54);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Text = "  Logout";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.bunifuiOSSwitch1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(8, 70);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 2;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  Records";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 16;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 258);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(210, 54);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "  Records";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // accbtn
            // 
            this.accbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.accbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.accbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accbtn.BorderRadius = 0;
            this.accbtn.ButtonText = "  SMS";
            this.accbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.accbtn, BunifuAnimatorNS.DecorationType.None);
            this.accbtn.DisabledColor = System.Drawing.Color.Gray;
            this.accbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.accbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("accbtn.Iconimage")));
            this.accbtn.Iconimage_right = null;
            this.accbtn.Iconimage_right_Selected = null;
            this.accbtn.Iconimage_Selected = null;
            this.accbtn.IconMarginLeft = 13;
            this.accbtn.IconMarginRight = 10;
            this.accbtn.IconRightVisible = false;
            this.accbtn.IconRightZoom = 0D;
            this.accbtn.IconVisible = true;
            this.accbtn.IconZoom = 65D;
            this.accbtn.IsTab = false;
            this.accbtn.Location = new System.Drawing.Point(0, 311);
            this.accbtn.Name = "accbtn";
            this.accbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.accbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.accbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.accbtn.selected = false;
            this.accbtn.Size = new System.Drawing.Size(210, 62);
            this.accbtn.TabIndex = 8;
            this.accbtn.Text = "  SMS";
            this.accbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.accbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.accbtn.Click += new System.EventHandler(this.accbtn_Click);
            // 
            // recordbtn
            // 
            this.recordbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.recordbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recordbtn.BorderRadius = 0;
            this.recordbtn.ButtonText = "  Recognize";
            this.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.recordbtn, BunifuAnimatorNS.DecorationType.None);
            this.recordbtn.DisabledColor = System.Drawing.Color.Gray;
            this.recordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.recordbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("recordbtn.Iconimage")));
            this.recordbtn.Iconimage_right = null;
            this.recordbtn.Iconimage_right_Selected = null;
            this.recordbtn.Iconimage_Selected = null;
            this.recordbtn.IconMarginLeft = 16;
            this.recordbtn.IconMarginRight = 0;
            this.recordbtn.IconRightVisible = false;
            this.recordbtn.IconRightZoom = 40D;
            this.recordbtn.IconVisible = true;
            this.recordbtn.IconZoom = 67D;
            this.recordbtn.IsTab = false;
            this.recordbtn.Location = new System.Drawing.Point(0, 205);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.recordbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recordbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.recordbtn.selected = false;
            this.recordbtn.Size = new System.Drawing.Size(210, 54);
            this.recordbtn.TabIndex = 9;
            this.recordbtn.Text = "  Recognize";
            this.recordbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recordbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // resaddbtn
            // 
            this.resaddbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.resaddbtn.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.resaddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.resaddbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resaddbtn.BorderRadius = 0;
            this.resaddbtn.ButtonText = "  Add Offender";
            this.resaddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidepanelanimator.SetDecoration(this.resaddbtn, BunifuAnimatorNS.DecorationType.None);
            this.resaddbtn.DisabledColor = System.Drawing.Color.Gray;
            this.resaddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resaddbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resaddbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.resaddbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("resaddbtn.Iconimage")));
            this.resaddbtn.Iconimage_right = null;
            this.resaddbtn.Iconimage_right_Selected = null;
            this.resaddbtn.Iconimage_Selected = null;
            this.resaddbtn.IconMarginLeft = 16;
            this.resaddbtn.IconMarginRight = 0;
            this.resaddbtn.IconRightVisible = false;
            this.resaddbtn.IconRightZoom = 0D;
            this.resaddbtn.IconVisible = true;
            this.resaddbtn.IconZoom = 71D;
            this.resaddbtn.IsTab = false;
            this.resaddbtn.Location = new System.Drawing.Point(0, 152);
            this.resaddbtn.Name = "resaddbtn";
            this.resaddbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.resaddbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.resaddbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.resaddbtn.selected = false;
            this.resaddbtn.Size = new System.Drawing.Size(210, 54);
            this.resaddbtn.TabIndex = 9;
            this.resaddbtn.Text = "  Add Offender";
            this.resaddbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resaddbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.resaddbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.resaddbtn.Click += new System.EventHandler(this.resaddbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 634);
            this.Controls.Add(this.ucpanel);
            this.Controls.Add(this.slidepanel);
            this.Controls.Add(this.toppanel);
            this.slidepanelanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resdownbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.slidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox container;
        private Bunifu.Framework.UI.BunifuImageButton minimizer;
        private Bunifu.Framework.UI.BunifuImageButton resdownbtn;
        private Bunifu.Framework.UI.BunifuImageButton exitbtn;
        private BunifuAnimatorNS.BunifuTransition slidepanelanimator;
        private System.Windows.Forms.Panel toppanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton accbtn;
        private Bunifu.Framework.UI.BunifuFlatButton recordbtn;
        private Bunifu.Framework.UI.BunifuFlatButton resaddbtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        public Bunifu.Framework.UI.BunifuGradientPanel slidepanel;
        public System.Windows.Forms.Panel ucpanel;
        
    }
}

