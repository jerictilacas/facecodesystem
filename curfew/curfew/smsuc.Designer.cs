namespace curfew
{
    partial class smsuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smsuc));
            this.recbuttompanel = new System.Windows.Forms.Panel();
            this.contactnum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.messagebox = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sendbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recbuttompanel
            // 
            this.recbuttompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recbuttompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recbuttompanel.Location = new System.Drawing.Point(0, 553);
            this.recbuttompanel.Name = "recbuttompanel";
            this.recbuttompanel.Size = new System.Drawing.Size(1137, 81);
            this.recbuttompanel.TabIndex = 15;
            // 
            // contactnum
            // 
            this.contactnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactnum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactnum.HintForeColor = System.Drawing.Color.Empty;
            this.contactnum.HintText = "";
            this.contactnum.isPassword = false;
            this.contactnum.LineFocusedColor = System.Drawing.Color.Blue;
            this.contactnum.LineIdleColor = System.Drawing.Color.Gray;
            this.contactnum.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.contactnum.LineThickness = 3;
            this.contactnum.Location = new System.Drawing.Point(111, 125);
            this.contactnum.Margin = new System.Windows.Forms.Padding(4);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(287, 44);
            this.contactnum.TabIndex = 18;
            this.contactnum.Text = "+63 ";
            this.contactnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactnum.OnValueChanged += new System.EventHandler(this.contactnum_OnValueChanged);
            // 
            // messagebox
            // 
            this.messagebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.messagebox.CustomButton.Image = null;
            this.messagebox.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.messagebox.CustomButton.Name = "";
            this.messagebox.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.messagebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messagebox.CustomButton.TabIndex = 1;
            this.messagebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messagebox.CustomButton.UseSelectable = true;
            this.messagebox.CustomButton.Visible = false;
            this.messagebox.Lines = new string[0];
            this.messagebox.Location = new System.Drawing.Point(111, 216);
            this.messagebox.MaxLength = 32767;
            this.messagebox.Multiline = true;
            this.messagebox.Name = "messagebox";
            this.messagebox.PasswordChar = '\0';
            this.messagebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messagebox.SelectedText = "";
            this.messagebox.SelectionLength = 0;
            this.messagebox.SelectionStart = 0;
            this.messagebox.ShortcutsEnabled = true;
            this.messagebox.Size = new System.Drawing.Size(287, 130);
            this.messagebox.TabIndex = 19;
            this.messagebox.UseSelectable = true;
            this.messagebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messagebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.messagebox.Click += new System.EventHandler(this.message_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 216);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "MESSAGE";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(34, 142);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel4.TabIndex = 25;
            this.bunifuCustomLabel4.Text = "NUMBER";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.sendbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.sendbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendbtn.BorderRadius = 0;
            this.sendbtn.ButtonText = "SEND";
            this.sendbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sendbtn.Iconimage = null;
            this.sendbtn.Iconimage_right = null;
            this.sendbtn.Iconimage_right_Selected = null;
            this.sendbtn.Iconimage_Selected = null;
            this.sendbtn.IconMarginLeft = 0;
            this.sendbtn.IconMarginRight = 0;
            this.sendbtn.IconRightVisible = true;
            this.sendbtn.IconRightZoom = 0D;
            this.sendbtn.IconVisible = true;
            this.sendbtn.IconZoom = 90D;
            this.sendbtn.IsTab = false;
            this.sendbtn.Location = new System.Drawing.Point(326, 352);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.sendbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.sendbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendbtn.selected = false;
            this.sendbtn.Size = new System.Drawing.Size(72, 36);
            this.sendbtn.TabIndex = 26;
            this.sendbtn.Text = "SEND";
            this.sendbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.sendbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "First Offense";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(404, 216);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(118, 29);
            this.bunifuFlatButton2.TabIndex = 28;
            this.bunifuFlatButton2.Text = "First Offense";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Second Offense";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(404, 251);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(118, 29);
            this.bunifuFlatButton3.TabIndex = 29;
            this.bunifuFlatButton3.Text = "Second Offense";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Visible = false;
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Third Offense";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(404, 286);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(118, 29);
            this.bunifuFlatButton4.TabIndex = 30;
            this.bunifuFlatButton4.Text = "Third Offense";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Visible = false;
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.recbuttompanel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 634);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(831, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Notify Parent Manually";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(906, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.messagebox);
            this.groupBox1.Controls.Add(this.bunifuFlatButton4);
            this.groupBox1.Controls.Add(this.contactnum);
            this.groupBox1.Controls.Add(this.bunifuFlatButton3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuFlatButton2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.sendbtn);
            this.groupBox1.Location = new System.Drawing.Point(106, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 500);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "SMS Notification";
            // 
            // smsuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "smsuc";
            this.Size = new System.Drawing.Size(1137, 634);
            this.Load += new System.EventHandler(this.UseraccUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recbuttompanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactnum;
        private MetroFramework.Controls.MetroTextBox messagebox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton sendbtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
