namespace ReactCRM.Forms
{
    partial class AdminUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.dgvSystemUser = new System.Windows.Forms.DataGridView();
            this.lbSystemUser = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAzman
            // 
            this.picBoxAzman.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAzman.Image")));
            this.picBoxAzman.Location = new System.Drawing.Point(208, 12);
            this.picBoxAzman.Name = "picBoxAzman";
            this.picBoxAzman.Size = new System.Drawing.Size(208, 68);
            this.picBoxAzman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAzman.TabIndex = 43;
            this.picBoxAzman.TabStop = false;
            // 
            // dgvSystemUser
            // 
            this.dgvSystemUser.AllowUserToAddRows = false;
            this.dgvSystemUser.AllowUserToDeleteRows = false;
            this.dgvSystemUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystemUser.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvSystemUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSystemUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dgvSystemUser.Location = new System.Drawing.Point(62, 114);
            this.dgvSystemUser.MultiSelect = false;
            this.dgvSystemUser.Name = "dgvSystemUser";
            this.dgvSystemUser.ReadOnly = true;
            this.dgvSystemUser.RowHeadersWidth = 40;
            this.dgvSystemUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemUser.Size = new System.Drawing.Size(500, 240);
            this.dgvSystemUser.TabIndex = 50;
            this.dgvSystemUser.SelectionChanged += new System.EventHandler(this.dgvSystemUser_SelectionChanged);
            // 
            // lbSystemUser
            // 
            this.lbSystemUser.AutoSize = true;
            this.lbSystemUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbSystemUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbSystemUser.Location = new System.Drawing.Point(58, 88);
            this.lbSystemUser.Name = "lbSystemUser";
            this.lbSystemUser.Size = new System.Drawing.Size(115, 23);
            this.lbSystemUser.TabIndex = 51;
            this.lbSystemUser.Text = "System Users:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(232, 375);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteUser.TabIndex = 54;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lbSystemUser);
            this.Controls.Add(this.dgvSystemUser);
            this.Controls.Add(this.picBoxAzman);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUserForm";
            this.Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.DataGridView dgvSystemUser;
        private System.Windows.Forms.Label lbSystemUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}