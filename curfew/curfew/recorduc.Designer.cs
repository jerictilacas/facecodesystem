namespace curfew
{
    partial class recorduc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recorduc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.notify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.information = new System.Windows.Forms.Label();
            this.information1 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.contact1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.Label();
            this.gender1 = new System.Windows.Forms.Label();
            this.age1 = new System.Windows.Forms.Label();
            this.fname1 = new System.Windows.Forms.Label();
            this.lname1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recognizebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.recbuttompanel = new System.Windows.Forms.Panel();
            this.dashline = new System.Windows.Forms.Label();
            this.image_PICBX = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.adduc1 = new curfew.adduc();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.recbuttompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.print);
            this.groupBox1.Controls.Add(this.notify);
            this.groupBox1.Controls.Add(this.information);
            this.groupBox1.Controls.Add(this.information1);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.contact1);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.address1);
            this.groupBox1.Controls.Add(this.gender1);
            this.groupBox1.Controls.Add(this.age1);
            this.groupBox1.Controls.Add(this.fname1);
            this.groupBox1.Controls.Add(this.lname1);
            this.groupBox1.Location = new System.Drawing.Point(531, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 404);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offender Information";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // print
            // 
            this.print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print.BorderRadius = 7;
            this.print.ButtonText = "Print";
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.DisabledColor = System.Drawing.Color.Gray;
            this.print.Iconcolor = System.Drawing.Color.Transparent;
            this.print.Iconimage = ((System.Drawing.Image)(resources.GetObject("print.Iconimage")));
            this.print.Iconimage_right = null;
            this.print.Iconimage_right_Selected = null;
            this.print.Iconimage_Selected = null;
            this.print.IconMarginLeft = 0;
            this.print.IconMarginRight = 0;
            this.print.IconRightVisible = true;
            this.print.IconRightZoom = 0D;
            this.print.IconVisible = true;
            this.print.IconZoom = 55D;
            this.print.IsTab = false;
            this.print.Location = new System.Drawing.Point(272, 339);
            this.print.Margin = new System.Windows.Forms.Padding(4);
            this.print.Name = "print";
            this.print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            this.print.OnHoverTextColor = System.Drawing.Color.White;
            this.print.selected = false;
            this.print.Size = new System.Drawing.Size(162, 41);
            this.print.TabIndex = 31;
            this.print.Text = "Print";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print.Textcolor = System.Drawing.Color.White;
            this.print.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // notify
            // 
            this.notify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.notify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.notify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notify.BorderRadius = 7;
            this.notify.ButtonText = "Notify Parents";
            this.notify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notify.DisabledColor = System.Drawing.Color.Gray;
            this.notify.Iconcolor = System.Drawing.Color.Transparent;
            this.notify.Iconimage = ((System.Drawing.Image)(resources.GetObject("notify.Iconimage")));
            this.notify.Iconimage_right = null;
            this.notify.Iconimage_right_Selected = null;
            this.notify.Iconimage_Selected = null;
            this.notify.IconMarginLeft = 0;
            this.notify.IconMarginRight = 0;
            this.notify.IconRightVisible = true;
            this.notify.IconRightZoom = 0D;
            this.notify.IconVisible = true;
            this.notify.IconZoom = 50D;
            this.notify.IsTab = false;
            this.notify.Location = new System.Drawing.Point(40, 339);
            this.notify.Margin = new System.Windows.Forms.Padding(4);
            this.notify.Name = "notify";
            this.notify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.notify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.notify.OnHoverTextColor = System.Drawing.Color.White;
            this.notify.selected = false;
            this.notify.Size = new System.Drawing.Size(190, 41);
            this.notify.TabIndex = 30;
            this.notify.Text = "Notify Parents";
            this.notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notify.Textcolor = System.Drawing.Color.White;
            this.notify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.notify.Click += new System.EventHandler(this.notify_Click_1);
            // 
            // information
            // 
            this.information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.information.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(36, 16);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(451, 58);
            this.information.TabIndex = 0;
            this.information.Text = "Unknown";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // information1
            // 
            this.information1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.information1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information1.Location = new System.Drawing.Point(24, 16);
            this.information1.Name = "information1";
            this.information1.Size = new System.Drawing.Size(451, 58);
            this.information1.TabIndex = 9;
            this.information1.Text = "label3";
            this.information1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.information1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(256, 288);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(81, 19);
            this.contact.TabIndex = 7;
            this.contact.Text = "Unknown";
            this.contact.Click += new System.EventHandler(this.label4_Click);
            // 
            // contact1
            // 
            this.contact1.AutoSize = true;
            this.contact1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact1.Location = new System.Drawing.Point(36, 288);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(214, 21);
            this.contact1.TabIndex = 6;
            this.contact1.Text = "Parent\'s Contact Number:";
            this.contact1.Click += new System.EventHandler(this.contact1_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(131, 249);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(81, 19);
            this.address.TabIndex = 1;
            this.address.Text = "Unknown";
            this.address.Click += new System.EventHandler(this.Address_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(130, 208);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(81, 19);
            this.gender.TabIndex = 2;
            this.gender.Text = "Unknown";
            this.gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(131, 175);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(81, 19);
            this.age.TabIndex = 3;
            this.age.Text = "Unknown";
            this.age.Click += new System.EventHandler(this.Age_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(131, 94);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(81, 19);
            this.fname.TabIndex = 4;
            this.fname.Text = "Unknown";
            this.fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // lname
            // 
            this.lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(133, 141);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(81, 19);
            this.lname.TabIndex = 5;
            this.lname.Text = "Unknown";
            this.lname.Click += new System.EventHandler(this.Lname_Click);
            // 
            // address1
            // 
            this.address1.AutoSize = true;
            this.address1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1.Location = new System.Drawing.Point(36, 249);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(76, 21);
            this.address1.TabIndex = 0;
            this.address1.Text = "Address:";
            this.address1.Click += new System.EventHandler(this.Address1_Click);
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender1.Location = new System.Drawing.Point(36, 208);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(74, 21);
            this.gender1.TabIndex = 0;
            this.gender1.Text = "Gender:";
            this.gender1.Click += new System.EventHandler(this.Gender1_Click);
            // 
            // age1
            // 
            this.age1.AutoSize = true;
            this.age1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age1.Location = new System.Drawing.Point(36, 173);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(48, 21);
            this.age1.TabIndex = 0;
            this.age1.Text = "Age:";
            this.age1.Click += new System.EventHandler(this.age1_Click);
            // 
            // fname1
            // 
            this.fname1.AutoSize = true;
            this.fname1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname1.Location = new System.Drawing.Point(36, 93);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(89, 21);
            this.fname1.TabIndex = 0;
            this.fname1.Text = "Firstname:";
            this.fname1.Click += new System.EventHandler(this.Fname1_Click);
            // 
            // lname1
            // 
            this.lname1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lname1.AutoSize = true;
            this.lname1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname1.Location = new System.Drawing.Point(36, 140);
            this.lname1.Name = "lname1";
            this.lname1.Size = new System.Drawing.Size(91, 21);
            this.lname1.TabIndex = 0;
            this.lname1.Text = "Lastname:";
            this.lname1.Click += new System.EventHandler(this.lname1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.adduc1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.recognizebtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.recbuttompanel);
            this.panel1.Controls.Add(this.image_PICBX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 627);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // recognizebtn
            // 
            this.recognizebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.recognizebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recognizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recognizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recognizebtn.BorderRadius = 7;
            this.recognizebtn.ButtonText = "Recognize";
            this.recognizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recognizebtn.DisabledColor = System.Drawing.Color.Gray;
            this.recognizebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.recognizebtn.Iconimage = null;
            this.recognizebtn.Iconimage_right = null;
            this.recognizebtn.Iconimage_right_Selected = null;
            this.recognizebtn.Iconimage_Selected = null;
            this.recognizebtn.IconMarginLeft = 0;
            this.recognizebtn.IconMarginRight = 0;
            this.recognizebtn.IconRightVisible = true;
            this.recognizebtn.IconRightZoom = 0D;
            this.recognizebtn.IconVisible = true;
            this.recognizebtn.IconZoom = 90D;
            this.recognizebtn.IsTab = false;
            this.recognizebtn.Location = new System.Drawing.Point(223, 439);
            this.recognizebtn.Name = "recognizebtn";
            this.recognizebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recognizebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.recognizebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.recognizebtn.selected = false;
            this.recognizebtn.Size = new System.Drawing.Size(102, 40);
            this.recognizebtn.TabIndex = 27;
            this.recognizebtn.Text = "Recognize";
            this.recognizebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recognizebtn.Textcolor = System.Drawing.Color.White;
            this.recognizebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizebtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(629, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "Recognize minor\'s face to know\r\nif they already had an offence.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // recbuttompanel
            // 
            this.recbuttompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recbuttompanel.Controls.Add(this.dashline);
            this.recbuttompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recbuttompanel.Location = new System.Drawing.Point(0, 546);
            this.recbuttompanel.Name = "recbuttompanel";
            this.recbuttompanel.Size = new System.Drawing.Size(1060, 81);
            this.recbuttompanel.TabIndex = 21;
            this.recbuttompanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Recbuttompanel_Paint);
            // 
            // dashline
            // 
            this.dashline.AutoSize = true;
            this.dashline.Location = new System.Drawing.Point(502, 22);
            this.dashline.Name = "dashline";
            this.dashline.Size = new System.Drawing.Size(427, 13);
            this.dashline.TabIndex = 28;
            this.dashline.Text = "======================================================================";
            this.dashline.Visible = false;
            // 
            // image_PICBX
            // 
            this.image_PICBX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.image_PICBX.BackColor = System.Drawing.Color.Transparent;
            this.image_PICBX.Location = new System.Drawing.Point(80, 61);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(378, 337);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 16;
            this.image_PICBX.TabStop = false;
            this.image_PICBX.Click += new System.EventHandler(this.Image_PICBX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // adduc1
            // 
            this.adduc1.BackColor = System.Drawing.SystemColors.Control;
            this.adduc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adduc1.Location = new System.Drawing.Point(0, 0);
            this.adduc1.Name = "adduc1";
            this.adduc1.Size = new System.Drawing.Size(1060, 546);
            this.adduc1.TabIndex = 19;
            this.adduc1.Visible = false;
            this.adduc1.Load += new System.EventHandler(this.adduc1_Load);
            // 
            // recorduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "recorduc";
            this.Size = new System.Drawing.Size(1060, 627);
            this.Load += new System.EventHandler(this.recorduc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.recbuttompanel.ResumeLayout(false);
            this.recbuttompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox image_PICBX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label address1;
        private System.Windows.Forms.Label gender1;
        private System.Windows.Forms.Label age1;
        private System.Windows.Forms.Label fname1;
        private System.Windows.Forms.Label lname1;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel recbuttompanel;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label contact1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton recognizebtn;
        private System.Windows.Forms.Label information1;
        private adduc adduc1;
        private Bunifu.Framework.UI.BunifuFlatButton notify;
        private Bunifu.Framework.UI.BunifuFlatButton print;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.Label dashline;
    }
}
