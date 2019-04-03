namespace ReactCRM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageFlights = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnManageCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnManageCustomers.Location = new System.Drawing.Point(130, 127);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(103, 52);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnManageFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnManageFlights.Location = new System.Drawing.Point(264, 127);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Size = new System.Drawing.Size(94, 52);
            this.btnManageFlights.TabIndex = 1;
            this.btnManageFlights.Text = "Manage Flights";
            this.btnManageFlights.UseVisualStyleBackColor = true;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnManageBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnManageBookings.Location = new System.Drawing.Point(391, 127);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(102, 52);
            this.btnManageBookings.TabIndex = 2;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = true;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(83, 4);
            this.contextMenuStrip1.Text = "Main";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(623, 307);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnManageFlights);
            this.Controls.Add(this.btnManageCustomers);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageFlights;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

