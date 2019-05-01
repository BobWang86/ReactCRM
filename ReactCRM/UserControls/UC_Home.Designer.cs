namespace ReactCRM.UserControls
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbRevenue = new System.Windows.Forms.CheckBox();
            this.cbExpense = new System.Windows.Forms.CheckBox();
            this.cbProfit = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 327);
            this.panel1.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(3, 62);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1053, 262);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.panel5.Controls.Add(this.cbProfit);
            this.panel5.Controls.Add(this.cbExpense);
            this.panel5.Controls.Add(this.cbRevenue);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1059, 56);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1016, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue/Expense:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.cartesianChart2);
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 327);
            this.panel3.TabIndex = 0;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(3, 62);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1053, 262);
            this.cartesianChart2.TabIndex = 0;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sales Funnel:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1059, 56);
            this.panel7.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1016, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // cbRevenue
            // 
            this.cbRevenue.AutoSize = true;
            this.cbRevenue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRevenue.Checked = true;
            this.cbRevenue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRevenue.ForeColor = System.Drawing.Color.White;
            this.cbRevenue.Location = new System.Drawing.Point(398, 19);
            this.cbRevenue.Name = "cbRevenue";
            this.cbRevenue.Size = new System.Drawing.Size(89, 25);
            this.cbRevenue.TabIndex = 2;
            this.cbRevenue.Text = "Revenue";
            this.cbRevenue.UseVisualStyleBackColor = true;
            this.cbRevenue.CheckedChanged += new System.EventHandler(this.cbRevenue_CheckedChanged);
            // 
            // cbExpense
            // 
            this.cbExpense.AutoSize = true;
            this.cbExpense.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbExpense.Checked = true;
            this.cbExpense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExpense.ForeColor = System.Drawing.Color.White;
            this.cbExpense.Location = new System.Drawing.Point(496, 19);
            this.cbExpense.Name = "cbExpense";
            this.cbExpense.Size = new System.Drawing.Size(86, 25);
            this.cbExpense.TabIndex = 2;
            this.cbExpense.Text = "Expense";
            this.cbExpense.UseVisualStyleBackColor = true;
            this.cbExpense.CheckedChanged += new System.EventHandler(this.cbExpense_CheckedChanged);
            // 
            // cbProfit
            // 
            this.cbProfit.AutoSize = true;
            this.cbProfit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbProfit.Checked = true;
            this.cbProfit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfit.ForeColor = System.Drawing.Color.White;
            this.cbProfit.Location = new System.Drawing.Point(591, 19);
            this.cbProfit.Name = "cbProfit";
            this.cbProfit.Size = new System.Drawing.Size(67, 25);
            this.cbProfit.TabIndex = 2;
            this.cbProfit.Text = "Profit";
            this.cbProfit.UseVisualStyleBackColor = true;
            this.cbProfit.CheckedChanged += new System.EventHandler(this.cbProfit_CheckedChanged);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1065, 660);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.CheckBox cbProfit;
        private System.Windows.Forms.CheckBox cbExpense;
        private System.Windows.Forms.CheckBox cbRevenue;
    }
}
