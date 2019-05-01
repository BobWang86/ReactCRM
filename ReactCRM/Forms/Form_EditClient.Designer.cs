namespace ReactCRM.Forms
{
    partial class Form_EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditClient));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.NumericUpDown();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbPipeline = new System.Windows.Forms.ComboBox();
            this.tbSource = new System.Windows.Forms.ComboBox();
            this.tbInstitute = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(237, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(411, 235);
            this.tbValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(160, 29);
            this.tbValue.TabIndex = 23;
            // 
            // tbDate
            // 
            this.tbDate.CustomFormat = "yyyy/MM/dd";
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDate.Location = new System.Drawing.Point(411, 293);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(160, 29);
            this.tbDate.TabIndex = 22;
            // 
            // tbPipeline
            // 
            this.tbPipeline.FormattingEnabled = true;
            this.tbPipeline.Location = new System.Drawing.Point(142, 293);
            this.tbPipeline.Name = "tbPipeline";
            this.tbPipeline.Size = new System.Drawing.Size(160, 29);
            this.tbPipeline.TabIndex = 21;
            // 
            // tbSource
            // 
            this.tbSource.FormattingEnabled = true;
            this.tbSource.Location = new System.Drawing.Point(142, 235);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(160, 29);
            this.tbSource.TabIndex = 20;
            // 
            // tbInstitute
            // 
            this.tbInstitute.Location = new System.Drawing.Point(411, 177);
            this.tbInstitute.Name = "tbInstitute";
            this.tbInstitute.Size = new System.Drawing.Size(160, 29);
            this.tbInstitute.TabIndex = 18;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(142, 177);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 29);
            this.tbPhone.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(411, 120);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 29);
            this.tbEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Institute:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(142, 119);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(160, 29);
            this.tbName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(221, 12);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 7;
            this.picLogp.TabStop = false;
            // 
            // Form_EditClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "Form_EditClient";
            this.Text = "Edit Client";
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown tbValue;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.ComboBox tbPipeline;
        private System.Windows.Forms.ComboBox tbSource;
        private System.Windows.Forms.TextBox tbInstitute;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogp;
    }
}