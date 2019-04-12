namespace ReactCRM.Forms
{
    partial class Form_EditTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditTicket));
            this.toolTipGen = new System.Windows.Forms.ToolTip(this.components);
            this.tbDetail = new System.Windows.Forms.RichTextBox();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.ComboBox();
            this.picLogp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDetail
            // 
            this.tbDetail.Location = new System.Drawing.Point(121, 140);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(300, 60);
            this.tbDetail.TabIndex = 37;
            this.tbDetail.Text = "";
            // 
            // tbDate
            // 
            this.tbDate.CustomFormat = "yyyy/MM/dd";
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDate.Location = new System.Drawing.Point(121, 316);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(300, 29);
            this.tbDate.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(157, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbType
            // 
            this.tbType.FormattingEnabled = true;
            this.tbType.Location = new System.Drawing.Point(121, 216);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(300, 29);
            this.tbType.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Details:";
            // 
            // tbStatus
            // 
            this.tbStatus.FormattingEnabled = true;
            this.tbStatus.Location = new System.Drawing.Point(121, 266);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(300, 29);
            this.tbStatus.TabIndex = 33;
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(141, 20);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 38;
            this.picLogp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Client:";
            // 
            // tbClient
            // 
            this.tbClient.AutoSize = true;
            this.tbClient.Location = new System.Drawing.Point(120, 100);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(26, 21);
            this.tbClient.TabIndex = 29;
            this.tbClient.Text = "ID";
            // 
            // Form_EditTicket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.picLogp);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStatus);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_EditTicket";
            this.Text = "Edit Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipGen;
        private System.Windows.Forms.RichTextBox tbDetail;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox tbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbStatus;
        private System.Windows.Forms.PictureBox picLogp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbClient;
    }
}