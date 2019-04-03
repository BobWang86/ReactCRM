namespace ReactCRM.Forms
{
    partial class UserBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.dgvBookingHistory = new System.Windows.Forms.DataGridView();
            this.lbBookingHistory = new System.Windows.Forms.Label();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.btnPrintRecord = new System.Windows.Forms.Button();
            this.btnExportRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAzman
            // 
            this.picBoxAzman.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAzman.Image")));
            this.picBoxAzman.Location = new System.Drawing.Point(262, 12);
            this.picBoxAzman.Name = "picBoxAzman";
            this.picBoxAzman.Size = new System.Drawing.Size(260, 84);
            this.picBoxAzman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAzman.TabIndex = 41;
            this.picBoxAzman.TabStop = false;
            // 
            // dgvBookingHistory
            // 
            this.dgvBookingHistory.AllowUserToAddRows = false;
            this.dgvBookingHistory.AllowUserToDeleteRows = false;
            this.dgvBookingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookingHistory.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dgvBookingHistory.Location = new System.Drawing.Point(72, 146);
            this.dgvBookingHistory.MultiSelect = false;
            this.dgvBookingHistory.Name = "dgvBookingHistory";
            this.dgvBookingHistory.ReadOnly = true;
            this.dgvBookingHistory.RowHeadersWidth = 40;
            this.dgvBookingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingHistory.Size = new System.Drawing.Size(640, 300);
            this.dgvBookingHistory.TabIndex = 42;
            this.dgvBookingHistory.SelectionChanged += new System.EventHandler(this.dgvBookingHistory_SelectionChanged);
            // 
            // lbBookingHistory
            // 
            this.lbBookingHistory.AutoSize = true;
            this.lbBookingHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbBookingHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbBookingHistory.Location = new System.Drawing.Point(68, 120);
            this.lbBookingHistory.Name = "lbBookingHistory";
            this.lbBookingHistory.Size = new System.Drawing.Size(138, 23);
            this.lbBookingHistory.TabIndex = 47;
            this.lbBookingHistory.Text = "Booking History:";
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnDeleteEntry.Location = new System.Drawing.Point(307, 485);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteEntry.TabIndex = 50;
            this.btnDeleteEntry.Text = "Delete Booking";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // btnPrintRecord
            // 
            this.btnPrintRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrintRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnPrintRecord.Location = new System.Drawing.Point(72, 485);
            this.btnPrintRecord.Name = "btnPrintRecord";
            this.btnPrintRecord.Size = new System.Drawing.Size(160, 40);
            this.btnPrintRecord.TabIndex = 51;
            this.btnPrintRecord.Text = "Print Record";
            this.btnPrintRecord.UseVisualStyleBackColor = true;
            this.btnPrintRecord.Click += new System.EventHandler(this.btnPrintRecord_Click);
            // 
            // btnExportRecord
            // 
            this.btnExportRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExportRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnExportRecord.Location = new System.Drawing.Point(552, 485);
            this.btnExportRecord.Name = "btnExportRecord";
            this.btnExportRecord.Size = new System.Drawing.Size(160, 40);
            this.btnExportRecord.TabIndex = 52;
            this.btnExportRecord.Text = "Export Record";
            this.btnExportRecord.UseVisualStyleBackColor = true;
            this.btnExportRecord.Click += new System.EventHandler(this.btnExportRecord_Click);
            // 
            // UserBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExportRecord);
            this.Controls.Add(this.btnPrintRecord);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.lbBookingHistory);
            this.Controls.Add(this.dgvBookingHistory);
            this.Controls.Add(this.picBoxAzman);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserBookingForm";
            this.Text = "UserBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.DataGridView dgvBookingHistory;
        private System.Windows.Forms.Label lbBookingHistory;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnPrintRecord;
        private System.Windows.Forms.Button btnExportRecord;
    }
}