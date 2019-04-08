namespace ReactCRM.Forms
{
    partial class Form_EditSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditSale));
            this.picLogp = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            this.tbProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(101, 12);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 8;
            this.picLogp.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(117, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbDate
            // 
            this.tbDate.CustomFormat = "yyyy/MM/dd";
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDate.Location = new System.Drawing.Point(120, 236);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(220, 29);
            this.tbDate.TabIndex = 31;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(120, 188);
            this.tbPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(220, 29);
            this.tbPrice.TabIndex = 30;
            // 
            // tbProduct
            // 
            this.tbProduct.FormattingEnabled = true;
            this.tbProduct.Location = new System.Drawing.Point(120, 140);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(220, 29);
            this.tbProduct.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "ClientID:";
            // 
            // tbClient
            // 
            this.tbClient.AutoSize = true;
            this.tbClient.Location = new System.Drawing.Point(120, 96);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(26, 21);
            this.tbClient.TabIndex = 32;
            this.tbClient.Text = "ID";
            // 
            // Form_EditSale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picLogp);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_EditSale";
            this.Text = "Edit Sale";
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.ComboBox tbProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbClient;
    }
}