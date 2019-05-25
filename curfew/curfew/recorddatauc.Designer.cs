namespace curfew
{
    partial class recorddatauc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recorddatauc));
            this.recordData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recbuttompanel = new System.Windows.Forms.Panel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.recordData)).BeginInit();
            this.SuspendLayout();
            // 
            // recordData
            // 
            this.recordData.AllowUserToAddRows = false;
            this.recordData.AllowUserToDeleteRows = false;
            this.recordData.AllowUserToResizeColumns = false;
            this.recordData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.recordData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recordData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recordData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.recordData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recordData.ColumnHeadersHeight = 44;
            this.recordData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Q,
            this.A,
            this.B,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordData.DefaultCellStyle = dataGridViewCellStyle3;
            this.recordData.DoubleBuffered = true;
            this.recordData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.recordData.EnableHeadersVisualStyles = false;
            this.recordData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.recordData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recordData.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.recordData.Location = new System.Drawing.Point(3, 121);
            this.recordData.Name = "recordData";
            this.recordData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.recordData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordData.Size = new System.Drawing.Size(801, 396);
            this.recordData.TabIndex = 1;
            this.recordData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordData_CellContentClick);
            // 
            // Q
            // 
            this.Q.DataPropertyName = "Q";
            this.Q.HeaderText = "ID";
            this.Q.Name = "Q";
            this.Q.Visible = false;
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A.DataPropertyName = "A";
            this.A.HeaderText = "First Name";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "Last Name";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "Age";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D.DataPropertyName = "D";
            this.D.HeaderText = "Gender";
            this.D.Name = "D";
            // 
            // E
            // 
            this.E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.E.DataPropertyName = "E";
            this.E.HeaderText = "Address";
            this.E.Name = "E";
            // 
            // F
            // 
            this.F.DataPropertyName = "F";
            this.F.HeaderText = "Contact";
            this.F.Name = "F";
            // 
            // G
            // 
            this.G.DataPropertyName = "G";
            this.G.HeaderText = "Offence";
            this.G.Name = "G";
            // 
            // H
            // 
            this.H.DataPropertyName = "H";
            this.H.HeaderText = "Date";
            this.H.Name = "H";
            // 
            // recbuttompanel
            // 
            this.recbuttompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.recbuttompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recbuttompanel.Location = new System.Drawing.Point(0, 553);
            this.recbuttompanel.Name = "recbuttompanel";
            this.recbuttompanel.Size = new System.Drawing.Size(1137, 81);
            this.recbuttompanel.TabIndex = 16;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 5;
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchBtn.Iconimage")));
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 0;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 40D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(3, 77);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.searchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(200)))));
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(98, 37);
            this.searchBtn.TabIndex = 19;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchBox.BorderThickness = 1;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(108, 77);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(194, 37);
            this.searchBox.TabIndex = 20;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // removeBtn
            // 
            this.removeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.BorderRadius = 5;
            this.removeBtn.ButtonText = "   Delete";
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.removeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("removeBtn.Iconimage")));
            this.removeBtn.Iconimage_right = null;
            this.removeBtn.Iconimage_right_Selected = null;
            this.removeBtn.Iconimage_Selected = null;
            this.removeBtn.IconMarginLeft = 0;
            this.removeBtn.IconMarginRight = 0;
            this.removeBtn.IconRightVisible = true;
            this.removeBtn.IconRightZoom = 0D;
            this.removeBtn.IconVisible = true;
            this.removeBtn.IconZoom = 40D;
            this.removeBtn.IsTab = false;
            this.removeBtn.Location = new System.Drawing.Point(698, 18);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.removeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.removeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.removeBtn.selected = false;
            this.removeBtn.Size = new System.Drawing.Size(106, 37);
            this.removeBtn.TabIndex = 25;
            this.removeBtn.Text = "   Delete";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeBtn.Textcolor = System.Drawing.Color.White;
            this.removeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Visible = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(162)))));
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(162)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.ButtonText = "   Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 40D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(698, 77);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(162)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(76)))), ((int)(((byte)(162)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(106, 37);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "   Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 5;
            this.addBtn.ButtonText = "   Add";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addBtn.Iconimage")));
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 0;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 40D;
            this.addBtn.IsTab = false;
            this.addBtn.Location = new System.Drawing.Point(582, 18);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.addBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.addBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(106, 37);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "   Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Textcolor = System.Drawing.Color.White;
            this.addBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Visible = false;
            // 
            // recorddatauc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.recordData);
            this.Controls.Add(this.recbuttompanel);
            this.Name = "recorddatauc";
            this.Size = new System.Drawing.Size(1137, 634);
            this.Load += new System.EventHandler(this.recorddatauc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.recordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid recordData;
        private System.Windows.Forms.Panel recbuttompanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton removeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
    }
}
