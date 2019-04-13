namespace ReactCRM.Forms
{
    partial class Form_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignIn));
            this.signInGroupBox = new System.Windows.Forms.GroupBox();
            this.linklbSignUp = new System.Windows.Forms.LinkLabel();
            this.lbDivision = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInGroupBox
            // 
            this.signInGroupBox.Controls.Add(this.linklbSignUp);
            this.signInGroupBox.Controls.Add(this.lbDivision);
            this.signInGroupBox.Controls.Add(this.btnSignIn);
            this.signInGroupBox.Controls.Add(this.tbPassword);
            this.signInGroupBox.Controls.Add(this.tbEmail);
            this.signInGroupBox.Controls.Add(this.lbPassword);
            this.signInGroupBox.Controls.Add(this.lbEmail);
            this.signInGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.signInGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.signInGroupBox.Location = new System.Drawing.Point(92, 220);
            this.signInGroupBox.Name = "signInGroupBox";
            this.signInGroupBox.Size = new System.Drawing.Size(500, 400);
            this.signInGroupBox.TabIndex = 1;
            this.signInGroupBox.TabStop = false;
            this.signInGroupBox.Text = "Sign In";
            // 
            // linklbSignUp
            // 
            this.linklbSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.linklbSignUp.AutoSize = true;
            this.linklbSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linklbSignUp.Location = new System.Drawing.Point(206, 348);
            this.linklbSignUp.Name = "linklbSignUp";
            this.linklbSignUp.Size = new System.Drawing.Size(88, 30);
            this.linklbSignUp.TabIndex = 6;
            this.linklbSignUp.TabStop = true;
            this.linklbSignUp.Text = "Sign Up";
            this.linklbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbSignUp_LinkClicked);
            // 
            // lbDivision
            // 
            this.lbDivision.AutoSize = true;
            this.lbDivision.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbDivision.Location = new System.Drawing.Point(212, 296);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(76, 23);
            this.lbDivision.TabIndex = 5;
            this.lbDivision.Text = "---OR---";
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSignIn.Location = new System.Drawing.Point(159, 220);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(183, 47);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sigh In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(203, 145);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(211, 35);
            this.tbPassword.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(203, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(211, 35);
            this.tbEmail.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPassword.Location = new System.Drawing.Point(76, 147);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(108, 30);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbEmail.Location = new System.Drawing.Point(76, 81);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(69, 30);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signInGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.signInGroupBox.ResumeLayout(false);
            this.signInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox signInGroupBox;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.LinkLabel linklbSignUp;
        private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}