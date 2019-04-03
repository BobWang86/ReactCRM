namespace ReactCRM
{
    partial class BookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsForm));
            this.dgvSelectedFlight = new System.Windows.Forms.DataGridView();
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.lbSelectedFlight = new System.Windows.Forms.Label();
            this.lbSelectPassenger = new System.Windows.Forms.Label();
            this.linklbAddPassenger = new System.Windows.Forms.LinkLabel();
            this.lbDepartureCity = new System.Windows.Forms.Label();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.lbPassengerName = new System.Windows.Forms.Label();
            this.lbFlightDate = new System.Windows.Forms.Label();
            this.lbFlightPrice = new System.Windows.Forms.Label();
            this.lbFlightTime = new System.Windows.Forms.Label();
            this.lbArrivalCity = new System.Windows.Forms.Label();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedFlight
            // 
            this.dgvSelectedFlight.AllowUserToAddRows = false;
            this.dgvSelectedFlight.AllowUserToDeleteRows = false;
            this.dgvSelectedFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSelectedFlight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSelectedFlight.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvSelectedFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedFlight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dgvSelectedFlight.Location = new System.Drawing.Point(72, 116);
            this.dgvSelectedFlight.MultiSelect = false;
            this.dgvSelectedFlight.Name = "dgvSelectedFlight";
            this.dgvSelectedFlight.ReadOnly = true;
            this.dgvSelectedFlight.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSelectedFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedFlight.Size = new System.Drawing.Size(640, 60);
            this.dgvSelectedFlight.TabIndex = 24;
            this.dgvSelectedFlight.SelectionChanged += new System.EventHandler(this.dgvSelectedFlight_SelectionChanged);
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
            // dgvPassenger
            // 
            this.dgvPassenger.AllowUserToAddRows = false;
            this.dgvPassenger.AllowUserToDeleteRows = false;
            this.dgvPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassenger.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.dgvPassenger.Location = new System.Drawing.Point(72, 226);
            this.dgvPassenger.MultiSelect = false;
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.ReadOnly = true;
            this.dgvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassenger.Size = new System.Drawing.Size(640, 112);
            this.dgvPassenger.TabIndex = 41;
            this.dgvPassenger.SelectionChanged += new System.EventHandler(this.dgvPassenger_SelectionChanged);
            // 
            // lbSelectedFlight
            // 
            this.lbSelectedFlight.AutoSize = true;
            this.lbSelectedFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbSelectedFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbSelectedFlight.Location = new System.Drawing.Point(68, 90);
            this.lbSelectedFlight.Name = "lbSelectedFlight";
            this.lbSelectedFlight.Size = new System.Drawing.Size(126, 23);
            this.lbSelectedFlight.TabIndex = 46;
            this.lbSelectedFlight.Text = "Selected Flight:";
            // 
            // lbSelectPassenger
            // 
            this.lbSelectPassenger.AutoSize = true;
            this.lbSelectPassenger.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbSelectPassenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbSelectPassenger.Location = new System.Drawing.Point(68, 200);
            this.lbSelectPassenger.Name = "lbSelectPassenger";
            this.lbSelectPassenger.Size = new System.Drawing.Size(142, 23);
            this.lbSelectPassenger.TabIndex = 47;
            this.lbSelectPassenger.Text = "Select Passenger:";
            // 
            // linklbAddPassenger
            // 
            this.linklbAddPassenger.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.linklbAddPassenger.AutoSize = true;
            this.linklbAddPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linklbAddPassenger.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.linklbAddPassenger.Location = new System.Drawing.Point(551, 200);
            this.linklbAddPassenger.Name = "linklbAddPassenger";
            this.linklbAddPassenger.Size = new System.Drawing.Size(161, 20);
            this.linklbAddPassenger.TabIndex = 48;
            this.linklbAddPassenger.TabStop = true;
            this.linklbAddPassenger.Text = "Add New Passenger";
            this.linklbAddPassenger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbAddPassenger_LinkClicked);
            // 
            // lbDepartureCity
            // 
            this.lbDepartureCity.AutoSize = true;
            this.lbDepartureCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbDepartureCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbDepartureCity.Location = new System.Drawing.Point(68, 390);
            this.lbDepartureCity.Name = "lbDepartureCity";
            this.lbDepartureCity.Size = new System.Drawing.Size(126, 23);
            this.lbDepartureCity.TabIndex = 46;
            this.lbDepartureCity.Text = "Departure City:";
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnMakeBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnMakeBooking.Location = new System.Drawing.Point(312, 485);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(160, 40);
            this.btnMakeBooking.TabIndex = 49;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // lbPassengerName
            // 
            this.lbPassengerName.AutoSize = true;
            this.lbPassengerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbPassengerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbPassengerName.Location = new System.Drawing.Point(68, 350);
            this.lbPassengerName.Name = "lbPassengerName";
            this.lbPassengerName.Size = new System.Drawing.Size(142, 23);
            this.lbPassengerName.TabIndex = 46;
            this.lbPassengerName.Text = "Passenger Name:";
            // 
            // lbFlightDate
            // 
            this.lbFlightDate.AutoSize = true;
            this.lbFlightDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbFlightDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbFlightDate.Location = new System.Drawing.Point(500, 430);
            this.lbFlightDate.Name = "lbFlightDate";
            this.lbFlightDate.Size = new System.Drawing.Size(98, 23);
            this.lbFlightDate.TabIndex = 46;
            this.lbFlightDate.Text = "Flight Date:";
            // 
            // lbFlightPrice
            // 
            this.lbFlightPrice.AutoSize = true;
            this.lbFlightPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbFlightPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbFlightPrice.Location = new System.Drawing.Point(500, 350);
            this.lbFlightPrice.Name = "lbFlightPrice";
            this.lbFlightPrice.Size = new System.Drawing.Size(99, 23);
            this.lbFlightPrice.TabIndex = 46;
            this.lbFlightPrice.Text = "Flight Price:";
            // 
            // lbFlightTime
            // 
            this.lbFlightTime.AutoSize = true;
            this.lbFlightTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbFlightTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbFlightTime.Location = new System.Drawing.Point(500, 390);
            this.lbFlightTime.Name = "lbFlightTime";
            this.lbFlightTime.Size = new System.Drawing.Size(99, 23);
            this.lbFlightTime.TabIndex = 50;
            this.lbFlightTime.Text = "Flight Time:";
            // 
            // lbArrivalCity
            // 
            this.lbArrivalCity.AutoSize = true;
            this.lbArrivalCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbArrivalCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbArrivalCity.Location = new System.Drawing.Point(68, 430);
            this.lbArrivalCity.Name = "lbArrivalCity";
            this.lbArrivalCity.Size = new System.Drawing.Size(98, 23);
            this.lbArrivalCity.TabIndex = 51;
            this.lbArrivalCity.Text = "Arrival City:";
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnViewBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnViewBooking.Location = new System.Drawing.Point(72, 485);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(160, 40);
            this.btnViewBooking.TabIndex = 53;
            this.btnViewBooking.Text = "View Booking";
            this.btnViewBooking.UseVisualStyleBackColor = true;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnRefresh.Location = new System.Drawing.Point(552, 485);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 40);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.lbArrivalCity);
            this.Controls.Add(this.lbFlightTime);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.linklbAddPassenger);
            this.Controls.Add(this.lbSelectPassenger);
            this.Controls.Add(this.lbPassengerName);
            this.Controls.Add(this.lbFlightPrice);
            this.Controls.Add(this.lbFlightDate);
            this.Controls.Add(this.lbDepartureCity);
            this.Controls.Add(this.lbSelectedFlight);
            this.Controls.Add(this.dgvPassenger);
            this.Controls.Add(this.picBoxAzman);
            this.Controls.Add(this.dgvSelectedFlight);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingsForm";
            this.Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSelectedFlight;
        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.Label lbSelectedFlight;
        private System.Windows.Forms.Label lbSelectPassenger;
        private System.Windows.Forms.LinkLabel linklbAddPassenger;
        private System.Windows.Forms.Label lbDepartureCity;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lbPassengerName;
        private System.Windows.Forms.Label lbFlightDate;
        private System.Windows.Forms.Label lbFlightPrice;
        private System.Windows.Forms.Label lbFlightTime;
        private System.Windows.Forms.Label lbArrivalCity;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Button btnRefresh;
    }
}