namespace ReactCRM.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.signUpGroupBox = new System.Windows.Forms.GroupBox();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.lbPassword2 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword1 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            this.signUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxAzman
            // 
            this.picBoxAzman.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAzman.Image")));
            this.picBoxAzman.Location = new System.Drawing.Point(162, 40);
            this.picBoxAzman.Name = "picBoxAzman";
            this.picBoxAzman.Size = new System.Drawing.Size(360, 154);
            this.picBoxAzman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAzman.TabIndex = 1;
            this.picBoxAzman.TabStop = false;
            // 
            // signUpGroupBox
            // 
            this.signUpGroupBox.Controls.Add(this.tbPassword2);
            this.signUpGroupBox.Controls.Add(this.lbPassword2);
            this.signUpGroupBox.Controls.Add(this.btnSignUp);
            this.signUpGroupBox.Controls.Add(this.tbPassword1);
            this.signUpGroupBox.Controls.Add(this.tbEmail);
            this.signUpGroupBox.Controls.Add(this.lbPassword1);
            this.signUpGroupBox.Controls.Add(this.lbEmail);
            this.signUpGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.signUpGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.signUpGroupBox.Location = new System.Drawing.Point(92, 220);
            this.signUpGroupBox.Name = "signUpGroupBox";
            this.signUpGroupBox.Size = new System.Drawing.Size(500, 400);
            this.signUpGroupBox.TabIndex = 2;
            this.signUpGroupBox.TabStop = false;
            this.signUpGroupBox.Text = "Sign Up";
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(203, 211);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '*';
            this.tbPassword2.Size = new System.Drawing.Size(211, 35);
            this.tbPassword2.TabIndex = 6;
            // 
            // lbPassword2
            // 
            this.lbPassword2.AutoSize = true;
            this.lbPassword2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.lbPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPassword2.Location = new System.Drawing.Point(65, 214);
            this.lbPassword2.Name = "lbPassword2";
            this.lbPassword2.Size = new System.Drawing.Size(129, 30);
            this.lbPassword2.TabIndex = 5;
            this.lbPassword2.Text = "Enter Again:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnSignUp.Location = new System.Drawing.Point(159, 299);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(183, 47);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sigh Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(203, 145);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(211, 35);
            this.tbPassword1.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(203, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(211, 35);
            this.tbEmail.TabIndex = 2;
            // 
            // lbPassword1
            // 
            this.lbPassword1.AutoSize = true;
            this.lbPassword1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.lbPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPassword1.Location = new System.Drawing.Point(65, 148);
            this.lbPassword1.Name = "lbPassword1";
            this.lbPassword1.Size = new System.Drawing.Size(108, 30);
            this.lbPassword1.TabIndex = 1;
            this.lbPassword1.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbEmail.Location = new System.Drawing.Point(65, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(69, 30);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.signUpGroupBox);
            this.Controls.Add(this.picBoxAzman);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            this.signUpGroupBox.ResumeLayout(false);
            this.signUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.GroupBox signUpGroupBox;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPassword1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label lbPassword2;
    }
}