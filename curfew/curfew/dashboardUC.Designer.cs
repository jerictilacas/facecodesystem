namespace curfew
{
    partial class dashboarduc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboarduc));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuProgressBar5 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar4 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCircleProgressbar5 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuProgressBar5);
            this.panel1.Controls.Add(this.bunifuProgressBar4);
            this.panel1.Controls.Add(this.bunifuCircleProgressbar5);
            this.panel1.Controls.Add(this.bunifuCircleProgressbar4);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 634);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(201, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Female:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(201, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Male:";
            // 
            // bunifuProgressBar5
            // 
            this.bunifuProgressBar5.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar5.BorderRadius = 5;
            this.bunifuProgressBar5.Location = new System.Drawing.Point(205, 551);
            this.bunifuProgressBar5.MaximumValue = 100;
            this.bunifuProgressBar5.Name = "bunifuProgressBar5";
            this.bunifuProgressBar5.ProgressColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuProgressBar5.Size = new System.Drawing.Size(321, 10);
            this.bunifuProgressBar5.TabIndex = 16;
            this.bunifuProgressBar5.Value = 35;
            // 
            // bunifuProgressBar4
            // 
            this.bunifuProgressBar4.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar4.BorderRadius = 5;
            this.bunifuProgressBar4.Location = new System.Drawing.Point(205, 486);
            this.bunifuProgressBar4.MaximumValue = 100;
            this.bunifuProgressBar4.Name = "bunifuProgressBar4";
            this.bunifuProgressBar4.ProgressColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuProgressBar4.Size = new System.Drawing.Size(321, 10);
            this.bunifuProgressBar4.TabIndex = 15;
            this.bunifuProgressBar4.Value = 35;
            // 
            // bunifuCircleProgressbar5
            // 
            this.bunifuCircleProgressbar5.animated = false;
            this.bunifuCircleProgressbar5.animationIterval = 5;
            this.bunifuCircleProgressbar5.animationSpeed = 300;
            this.bunifuCircleProgressbar5.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCircleProgressbar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar5.BackgroundImage")));
            this.bunifuCircleProgressbar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar5.LabelVisible = true;
            this.bunifuCircleProgressbar5.LineProgressThickness = 8;
            this.bunifuCircleProgressbar5.LineThickness = 5;
            this.bunifuCircleProgressbar5.Location = new System.Drawing.Point(823, 477);
            this.bunifuCircleProgressbar5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar5.MaxValue = 100;
            this.bunifuCircleProgressbar5.Name = "bunifuCircleProgressbar5";
            this.bunifuCircleProgressbar5.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar5.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar5.Size = new System.Drawing.Size(148, 148);
            this.bunifuCircleProgressbar5.TabIndex = 14;
            this.bunifuCircleProgressbar5.Value = 0;
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = false;
            this.bunifuCircleProgressbar4.animationIterval = 5;
            this.bunifuCircleProgressbar4.animationSpeed = 300;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 8;
            this.bunifuCircleProgressbar4.LineThickness = 5;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(598, 477);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(148, 148);
            this.bunifuCircleProgressbar4.TabIndex = 13;
            this.bunifuCircleProgressbar4.Value = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 75);
            this.chart1.Name = "chart1";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Orange;
            series1.Legend = "Legend1";
            series1.Name = "Last Year";
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Curent Year";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(766, 411);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // dashboarduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "dashboarduc";
            this.Size = new System.Drawing.Size(1137, 634);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar5;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar4;
    }
}
