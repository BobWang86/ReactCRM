namespace ReactCRM
{
    partial class PassengersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersForm));
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.tbTelNum = new System.Windows.Forms.TextBox();
            this.tbNation = new System.Windows.Forms.TextBox();
            this.lbNationality = new System.Windows.Forms.Label();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.AllowUserToAddRows = false;
            this.dgvPassenger.AllowUserToDeleteRows = false;
            this.dgvPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassenger.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dgvPassenger.Location = new System.Drawing.Point(92, 270);
            this.dgvPassenger.MultiSelect = false;
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.ReadOnly = true;
            this.dgvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassenger.Size = new System.Drawing.Size(600, 200);
            this.dgvPassenger.TabIndex = 0;
            this.dgvPassenger.SelectionChanged += new System.EventHandler(this.dgvPassenger_SelectionChanged);
            // 
            // picBoxAzman
            // 
            this.picBoxAzman.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAzman.Image")));
            this.picBoxAzman.Location = new System.Drawing.Point(262, 12);
            this.picBoxAzman.Name = "picBoxAzman";
            this.picBoxAzman.Size = new System.Drawing.Size(260, 84);
            this.picBoxAzman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAzman.TabIndex = 40;
            this.picBoxAzman.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnDelete.Location = new System.Drawing.Point(533, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 35);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete Passenger";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnUpdate.Location = new System.Drawing.Point(313, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 35);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update Passenger";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnAdd.Location = new System.Drawing.Point(93, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 35);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add Passenger";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(519, 169);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(172, 22);
            this.dtpBirthDate.TabIndex = 54;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbBirthDate.Location = new System.Drawing.Point(415, 169);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(86, 23);
            this.lbBirthDate.TabIndex = 53;
            this.lbBirthDate.Text = "BirthDate:";
            // 
            // tbTelNum
            // 
            this.tbTelNum.Location = new System.Drawing.Point(201, 229);
            this.tbTelNum.Name = "tbTelNum";
            this.tbTelNum.Size = new System.Drawing.Size(172, 22);
            this.tbTelNum.TabIndex = 52;
            // 
            // tbNation
            // 
            this.tbNation.Location = new System.Drawing.Point(519, 229);
            this.tbNation.Name = "tbNation";
            this.tbNation.Size = new System.Drawing.Size(172, 22);
            this.tbNation.TabIndex = 51;
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbNationality.Location = new System.Drawing.Point(415, 229);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(98, 23);
            this.lbNationality.TabIndex = 50;
            this.lbNationality.Text = "Nationality:";
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbPhoneNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPhoneNum.Location = new System.Drawing.Point(89, 229);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(101, 23);
            this.lbPhoneNum.TabIndex = 49;
            this.lbPhoneNum.Text = "PhoneNum:";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(520, 109);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(172, 22);
            this.tbLName.TabIndex = 48;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbLName.Location = new System.Drawing.Point(415, 109);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(95, 23);
            this.lbLName.TabIndex = 47;
            this.lbLName.Text = "Last Name:";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(201, 109);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(172, 22);
            this.tbFName.TabIndex = 46;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbFName.Location = new System.Drawing.Point(89, 109);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(97, 23);
            this.lbFName.TabIndex = 45;
            this.lbFName.Text = "First Name:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGender.Location = new System.Drawing.Point(89, 169);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(71, 23);
            this.lbGender.TabIndex = 55;
            this.lbGender.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(201, 170);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(172, 21);
            this.cbGender.TabIndex = 56;
            // 
            // PassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.tbTelNum);
            this.Controls.Add(this.tbNation);
            this.Controls.Add(this.lbNationality);
            this.Controls.Add(this.lbPhoneNum);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.lbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picBoxAzman);
            this.Controls.Add(this.dgvPassenger);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassengersForm";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.TextBox tbTelNum;
        private System.Windows.Forms.TextBox tbNation;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;
    }
}