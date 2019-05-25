namespace curfew
{
    partial class recordFaceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recordFaceFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.face_PICBX = new System.Windows.Forms.PictureBox();
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 85);
            this.panel1.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLbl.Location = new System.Drawing.Point(252, 440);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 24);
            this.nameLbl.TabIndex = 20;
            this.nameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(158, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // face_PICBX
            // 
            this.face_PICBX.Location = new System.Drawing.Point(202, 132);
            this.face_PICBX.Name = "face_PICBX";
            this.face_PICBX.Size = new System.Drawing.Size(209, 196);
            this.face_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_PICBX.TabIndex = 21;
            this.face_PICBX.TabStop = false;
            this.face_PICBX.Visible = false;
            // 
            // image_PICBX
            // 
            this.image_PICBX.Location = new System.Drawing.Point(138, 71);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(336, 319);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 18;
            this.image_PICBX.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(265, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(82, 85);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // recordFaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(610, 587);
            this.Controls.Add(this.face_PICBX);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image_PICBX);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recordFaceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recordFaceFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.recordFaceFrm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image_PICBX;
        private System.Windows.Forms.PictureBox face_PICBX;
    }
}