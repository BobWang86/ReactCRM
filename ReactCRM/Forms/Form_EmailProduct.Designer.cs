namespace ReactCRM.Forms
{
    partial class Form_EmailProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EmailProduct));
            this.picLogp = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.tbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(141, 20);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 40;
            this.picLogp.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(157, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 40);
            this.btnSend.TabIndex = 39;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(124, 200);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(300, 155);
            this.tbContent.TabIndex = 50;
            this.tbContent.Text = "";
            // 
            // tbType
            // 
            this.tbType.FormattingEnabled = true;
            this.tbType.Location = new System.Drawing.Point(124, 160);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(300, 29);
            this.tbType.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Type:";
            // 
            // tbClient
            // 
            this.tbClient.AutoSize = true;
            this.tbClient.Location = new System.Drawing.Point(120, 100);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(53, 21);
            this.tbClient.TabIndex = 44;
            this.tbClient.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Client:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Content:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.AutoSize = true;
            this.tbEmail.Location = new System.Drawing.Point(120, 130);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(112, 21);
            this.tbEmail.TabIndex = 44;
            this.tbEmail.Text = "Email Address";
            // 
            // Form_EmailProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picLogp);
            this.Controls.Add(this.btnSend);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_EmailProduct";
            this.Text = "Email Product";
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogp;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.ComboBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbEmail;
    }
}