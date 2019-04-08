namespace ReactCRM.Forms
{
    partial class Form_AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddClient));
            this.picLogp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInstitute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.ComboBox();
            this.tbPipeline = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbValue = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.toolTipGen = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(221, 12);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 0;
            this.picLogp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(142, 96);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(160, 29);
            this.tbName.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(411, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 29);
            this.tbEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(142, 154);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 29);
            this.tbPhone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Institute:";
            // 
            // tbInstitute
            // 
            this.tbInstitute.Location = new System.Drawing.Point(411, 154);
            this.tbInstitute.Name = "tbInstitute";
            this.tbInstitute.Size = new System.Drawing.Size(160, 29);
            this.tbInstitute.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Source:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Date:";
            // 
            // tbSource
            // 
            this.tbSource.FormattingEnabled = true;
            this.tbSource.Location = new System.Drawing.Point(142, 212);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(160, 29);
            this.tbSource.TabIndex = 3;
            // 
            // tbPipeline
            // 
            this.tbPipeline.FormattingEnabled = true;
            this.tbPipeline.Location = new System.Drawing.Point(142, 270);
            this.tbPipeline.Name = "tbPipeline";
            this.tbPipeline.Size = new System.Drawing.Size(160, 29);
            this.tbPipeline.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.CustomFormat = "yyyy/MM/dd";
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDate.Location = new System.Drawing.Point(411, 270);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(160, 29);
            this.tbDate.TabIndex = 4;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(411, 212);
            this.tbValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(160, 29);
            this.tbValue.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(237, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGen
            // 
            this.btnGen.FlatAppearance.BorderSize = 0;
            this.btnGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Image = ((System.Drawing.Image)(resources.GetObject("btnGen.Image")));
            this.btnGen.Location = new System.Drawing.Point(574, 0);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(50, 50);
            this.btnGen.TabIndex = 6;
            this.toolTipGen.SetToolTip(this.btnGen, "Generate Clients");
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form_AddClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbPipeline);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbInstitute);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogp);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddClient";
            this.Text = "Add Client";
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInstitute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tbSource;
        private System.Windows.Forms.ComboBox tbPipeline;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.NumericUpDown tbValue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ToolTip toolTipGen;
    }
}