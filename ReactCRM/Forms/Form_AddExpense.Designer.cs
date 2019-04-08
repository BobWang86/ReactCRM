namespace ReactCRM.Forms
{
    partial class Form_AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddExpense));
            this.picLogp = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.NumericUpDown();
            this.tbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogp
            // 
            this.picLogp.Image = ((System.Drawing.Image)(resources.GetObject("picLogp.Image")));
            this.picLogp.Location = new System.Drawing.Point(101, 12);
            this.picLogp.Name = "picLogp";
            this.picLogp.Size = new System.Drawing.Size(182, 66);
            this.picLogp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogp.TabIndex = 30;
            this.picLogp.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(88)))), ((int)(((byte)(139)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(117, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbDate
            // 
            this.tbDate.CustomFormat = "yyyy/MM/dd";
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDate.Location = new System.Drawing.Point(120, 231);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(220, 29);
            this.tbDate.TabIndex = 40;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(120, 166);
            this.tbAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(220, 29);
            this.tbAmount.TabIndex = 39;
            // 
            // tbType
            // 
            this.tbType.FormattingEnabled = true;
            this.tbType.Location = new System.Drawing.Point(120, 101);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(220, 29);
            this.tbType.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Type:";
            // 
            // btnGen
            // 
            this.btnGen.FlatAppearance.BorderSize = 0;
            this.btnGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Image = ((System.Drawing.Image)(resources.GetObject("btnGen.Image")));
            this.btnGen.Location = new System.Drawing.Point(333, 0);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(50, 50);
            this.btnGen.TabIndex = 41;
            this.toolTip1.SetToolTip(this.btnGen, "Generate Expenses");
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // Form_AddExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picLogp);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)(this.picLogp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.NumericUpDown tbAmount;
        private System.Windows.Forms.ComboBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}