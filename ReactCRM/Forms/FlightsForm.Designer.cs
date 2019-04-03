namespace ReactCRM
{
    partial class FlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.lbDeparCity = new System.Windows.Forms.Label();
            this.lbArrDT = new System.Windows.Forms.Label();
            this.lbDepatDT = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvFlight = new System.Windows.Forms.DataGridView();
            this.tbAdultPrice = new System.Windows.Forms.TextBox();
            this.lbAdultPrice = new System.Windows.Forms.Label();
            this.dtpArrDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbArrCity = new System.Windows.Forms.Label();
            this.picBoxAzman = new System.Windows.Forms.PictureBox();
            this.lbChildPrice = new System.Windows.Forms.Label();
            this.lbInfantPrice = new System.Windows.Forms.Label();
            this.tbChildPrice = new System.Windows.Forms.TextBox();
            this.tbInfantPrice = new System.Windows.Forms.TextBox();
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.lbFlightID = new System.Windows.Forms.Label();
            this.lbAircraft = new System.Windows.Forms.Label();
            this.cbDepartureCity = new System.Windows.Forms.ComboBox();
            this.cbArrivalCity = new System.Windows.Forms.ComboBox();
            this.cbAirCraft = new System.Windows.Forms.ComboBox();
            this.tbNewCity = new System.Windows.Forms.TextBox();
            this.tbNewModel = new System.Windows.Forms.TextBox();
            this.btnAddNewCity = new System.Windows.Forms.Button();
            this.btnGenerateFlight = new System.Windows.Forms.Button();
            this.dtpFlightGenerater = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDeparCity
            // 
            this.lbDeparCity.AutoSize = true;
            this.lbDeparCity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDeparCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbDeparCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbDeparCity.Location = new System.Drawing.Point(366, 150);
            this.lbDeparCity.Name = "lbDeparCity";
            this.lbDeparCity.Size = new System.Drawing.Size(126, 23);
            this.lbDeparCity.TabIndex = 19;
            this.lbDeparCity.Text = "Departure City:";
            // 
            // lbArrDT
            // 
            this.lbArrDT.AutoSize = true;
            this.lbArrDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbArrDT.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbArrDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbArrDT.Location = new System.Drawing.Point(68, 186);
            this.lbArrDT.Name = "lbArrDT";
            this.lbArrDT.Size = new System.Drawing.Size(148, 23);
            this.lbArrDT.TabIndex = 18;
            this.lbArrDT.Text = "Arrival Date/Time:";
            // 
            // lbDepatDT
            // 
            this.lbDepatDT.AutoSize = true;
            this.lbDepatDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDepatDT.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbDepatDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbDepatDT.Location = new System.Drawing.Point(68, 148);
            this.lbDepatDT.Name = "lbDepatDT";
            this.lbDepatDT.Size = new System.Drawing.Size(170, 23);
            this.lbDepatDT.TabIndex = 17;
            this.lbDepatDT.Text = "Depature Date/Time:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnDelete.Location = new System.Drawing.Point(787, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Flight";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnUpdate.Location = new System.Drawing.Point(430, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Flight";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnAdd.Location = new System.Drawing.Point(72, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Flight";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFlight
            // 
            this.dgvFlight.AllowUserToAddRows = false;
            this.dgvFlight.AllowUserToDeleteRows = false;
            this.dgvFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlight.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlight.Location = new System.Drawing.Point(72, 265);
            this.dgvFlight.MultiSelect = false;
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            this.dgvFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlight.Size = new System.Drawing.Size(840, 200);
            this.dgvFlight.TabIndex = 24;
            this.dgvFlight.SelectionChanged += new System.EventHandler(this.dgvFlight_SelectionChanged);
            // 
            // tbAdultPrice
            // 
            this.tbAdultPrice.Location = new System.Drawing.Point(244, 226);
            this.tbAdultPrice.Name = "tbAdultPrice";
            this.tbAdultPrice.Size = new System.Drawing.Size(120, 22);
            this.tbAdultPrice.TabIndex = 23;
            this.tbAdultPrice.TextChanged += new System.EventHandler(this.tbAdultPrice_TextChanged);
            this.tbAdultPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAdultPrice_KeyPress);
            // 
            // lbAdultPrice
            // 
            this.lbAdultPrice.AutoSize = true;
            this.lbAdultPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAdultPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbAdultPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbAdultPrice.Location = new System.Drawing.Point(68, 225);
            this.lbAdultPrice.Name = "lbAdultPrice";
            this.lbAdultPrice.Size = new System.Drawing.Size(97, 23);
            this.lbAdultPrice.TabIndex = 28;
            this.lbAdultPrice.Text = "Adult Price:";
            // 
            // dtpArrDateTime
            // 
            this.dtpArrDateTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpArrDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrDateTime.Location = new System.Drawing.Point(244, 187);
            this.dtpArrDateTime.Name = "dtpArrDateTime";
            this.dtpArrDateTime.Size = new System.Drawing.Size(120, 22);
            this.dtpArrDateTime.TabIndex = 22;
            // 
            // dtpDeparDateTime
            // 
            this.dtpDeparDateTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpDeparDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparDateTime.Location = new System.Drawing.Point(244, 149);
            this.dtpDeparDateTime.Name = "dtpDeparDateTime";
            this.dtpDeparDateTime.Size = new System.Drawing.Size(120, 22);
            this.dtpDeparDateTime.TabIndex = 21;
            // 
            // lbArrCity
            // 
            this.lbArrCity.AutoSize = true;
            this.lbArrCity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbArrCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbArrCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbArrCity.Location = new System.Drawing.Point(394, 186);
            this.lbArrCity.Name = "lbArrCity";
            this.lbArrCity.Size = new System.Drawing.Size(98, 23);
            this.lbArrCity.TabIndex = 32;
            this.lbArrCity.Text = "Arrival City:";
            // 
            // picBoxAzman
            // 
            this.picBoxAzman.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAzman.Image")));
            this.picBoxAzman.Location = new System.Drawing.Point(362, 12);
            this.picBoxAzman.Name = "picBoxAzman";
            this.picBoxAzman.Size = new System.Drawing.Size(260, 84);
            this.picBoxAzman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAzman.TabIndex = 39;
            this.picBoxAzman.TabStop = false;
            // 
            // lbChildPrice
            // 
            this.lbChildPrice.AutoSize = true;
            this.lbChildPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbChildPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbChildPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbChildPrice.Location = new System.Drawing.Point(397, 225);
            this.lbChildPrice.Name = "lbChildPrice";
            this.lbChildPrice.Size = new System.Drawing.Size(95, 23);
            this.lbChildPrice.TabIndex = 28;
            this.lbChildPrice.Text = "Child Price:";
            // 
            // lbInfantPrice
            // 
            this.lbInfantPrice.AutoSize = true;
            this.lbInfantPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbInfantPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbInfantPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbInfantPrice.Location = new System.Drawing.Point(684, 225);
            this.lbInfantPrice.Name = "lbInfantPrice";
            this.lbInfantPrice.Size = new System.Drawing.Size(102, 23);
            this.lbInfantPrice.TabIndex = 28;
            this.lbInfantPrice.Text = "Infant Price:";
            // 
            // tbChildPrice
            // 
            this.tbChildPrice.Enabled = false;
            this.tbChildPrice.Location = new System.Drawing.Point(498, 225);
            this.tbChildPrice.Name = "tbChildPrice";
            this.tbChildPrice.Size = new System.Drawing.Size(120, 22);
            this.tbChildPrice.TabIndex = 23;
            // 
            // tbInfantPrice
            // 
            this.tbInfantPrice.Enabled = false;
            this.tbInfantPrice.Location = new System.Drawing.Point(792, 225);
            this.tbInfantPrice.Name = "tbInfantPrice";
            this.tbInfantPrice.Size = new System.Drawing.Size(120, 22);
            this.tbInfantPrice.TabIndex = 23;
            // 
            // tbFlightID
            // 
            this.tbFlightID.Enabled = false;
            this.tbFlightID.Location = new System.Drawing.Point(244, 111);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.ReadOnly = true;
            this.tbFlightID.Size = new System.Drawing.Size(120, 22);
            this.tbFlightID.TabIndex = 20;
            // 
            // lbFlightID
            // 
            this.lbFlightID.AutoSize = true;
            this.lbFlightID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFlightID.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbFlightID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbFlightID.Location = new System.Drawing.Point(68, 110);
            this.lbFlightID.Name = "lbFlightID";
            this.lbFlightID.Size = new System.Drawing.Size(79, 23);
            this.lbFlightID.TabIndex = 16;
            this.lbFlightID.Text = "Flight ID:";
            // 
            // lbAircraft
            // 
            this.lbAircraft.AutoSize = true;
            this.lbAircraft.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAircraft.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbAircraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbAircraft.Location = new System.Drawing.Point(422, 111);
            this.lbAircraft.Name = "lbAircraft";
            this.lbAircraft.Size = new System.Drawing.Size(70, 23);
            this.lbAircraft.TabIndex = 40;
            this.lbAircraft.Text = "Aircraft:";
            // 
            // cbDepartureCity
            // 
            this.cbDepartureCity.FormattingEnabled = true;
            this.cbDepartureCity.Location = new System.Drawing.Point(498, 151);
            this.cbDepartureCity.Name = "cbDepartureCity";
            this.cbDepartureCity.Size = new System.Drawing.Size(120, 21);
            this.cbDepartureCity.TabIndex = 42;
            // 
            // cbArrivalCity
            // 
            this.cbArrivalCity.FormattingEnabled = true;
            this.cbArrivalCity.Location = new System.Drawing.Point(498, 189);
            this.cbArrivalCity.Name = "cbArrivalCity";
            this.cbArrivalCity.Size = new System.Drawing.Size(120, 21);
            this.cbArrivalCity.TabIndex = 42;
            // 
            // cbAirCraft
            // 
            this.cbAirCraft.FormattingEnabled = true;
            this.cbAirCraft.Location = new System.Drawing.Point(498, 113);
            this.cbAirCraft.Name = "cbAirCraft";
            this.cbAirCraft.Size = new System.Drawing.Size(120, 21);
            this.cbAirCraft.TabIndex = 42;
            // 
            // tbNewCity
            // 
            this.tbNewCity.Location = new System.Drawing.Point(792, 150);
            this.tbNewCity.Name = "tbNewCity";
            this.tbNewCity.Size = new System.Drawing.Size(120, 22);
            this.tbNewCity.TabIndex = 24;
            // 
            // tbNewModel
            // 
            this.tbNewModel.Location = new System.Drawing.Point(792, 111);
            this.tbNewModel.Name = "tbNewModel";
            this.tbNewModel.Size = new System.Drawing.Size(120, 22);
            this.tbNewModel.TabIndex = 41;
            // 
            // btnAddNewCity
            // 
            this.btnAddNewCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnAddNewCity.Location = new System.Drawing.Point(661, 149);
            this.btnAddNewCity.Name = "btnAddNewCity";
            this.btnAddNewCity.Size = new System.Drawing.Size(125, 25);
            this.btnAddNewCity.TabIndex = 43;
            this.btnAddNewCity.Text = "Add New City";
            this.btnAddNewCity.UseVisualStyleBackColor = true;
            this.btnAddNewCity.Click += new System.EventHandler(this.btnAddNewCity_Click);
            // 
            // btnGenerateFlight
            // 
            this.btnGenerateFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerateFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnGenerateFlight.Location = new System.Drawing.Point(661, 186);
            this.btnGenerateFlight.Name = "btnGenerateFlight";
            this.btnGenerateFlight.Size = new System.Drawing.Size(125, 25);
            this.btnGenerateFlight.TabIndex = 44;
            this.btnGenerateFlight.Text = "Generate Flight";
            this.btnGenerateFlight.UseVisualStyleBackColor = true;
            this.btnGenerateFlight.Click += new System.EventHandler(this.btnGenerateFlight_Click);
            // 
            // dtpFlightGenerater
            // 
            this.dtpFlightGenerater.CustomFormat = "yyyy/MM/dd";
            this.dtpFlightGenerater.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFlightGenerater.Location = new System.Drawing.Point(792, 187);
            this.dtpFlightGenerater.Name = "dtpFlightGenerater";
            this.dtpFlightGenerater.Size = new System.Drawing.Size(120, 22);
            this.dtpFlightGenerater.TabIndex = 45;
            // 
            // btnAddNewModel
            // 
            this.btnAddNewModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.btnAddNewModel.Location = new System.Drawing.Point(661, 110);
            this.btnAddNewModel.Name = "btnAddNewModel";
            this.btnAddNewModel.Size = new System.Drawing.Size(125, 25);
            this.btnAddNewModel.TabIndex = 46;
            this.btnAddNewModel.Text = "Add New Model";
            this.btnAddNewModel.UseVisualStyleBackColor = true;
            this.btnAddNewModel.Click += new System.EventHandler(this.btnAddNewModel_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnAddNewModel);
            this.Controls.Add(this.dtpFlightGenerater);
            this.Controls.Add(this.btnGenerateFlight);
            this.Controls.Add(this.btnAddNewCity);
            this.Controls.Add(this.cbArrivalCity);
            this.Controls.Add(this.cbAirCraft);
            this.Controls.Add(this.cbDepartureCity);
            this.Controls.Add(this.tbNewModel);
            this.Controls.Add(this.lbAircraft);
            this.Controls.Add(this.picBoxAzman);
            this.Controls.Add(this.lbArrCity);
            this.Controls.Add(this.dtpDeparDateTime);
            this.Controls.Add(this.dtpArrDateTime);
            this.Controls.Add(this.lbInfantPrice);
            this.Controls.Add(this.lbChildPrice);
            this.Controls.Add(this.lbAdultPrice);
            this.Controls.Add(this.tbInfantPrice);
            this.Controls.Add(this.tbChildPrice);
            this.Controls.Add(this.tbAdultPrice);
            this.Controls.Add(this.tbNewCity);
            this.Controls.Add(this.dgvFlight);
            this.Controls.Add(this.tbFlightID);
            this.Controls.Add(this.lbDeparCity);
            this.Controls.Add(this.lbArrDT);
            this.Controls.Add(this.lbDepatDT);
            this.Controls.Add(this.lbFlightID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightsForm";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAzman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDeparCity;
        private System.Windows.Forms.Label lbArrDT;
        private System.Windows.Forms.Label lbDepatDT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFlight;
        private System.Windows.Forms.TextBox tbAdultPrice;
        private System.Windows.Forms.Label lbAdultPrice;
        private System.Windows.Forms.DateTimePicker dtpArrDateTime;
        private System.Windows.Forms.DateTimePicker dtpDeparDateTime;
        private System.Windows.Forms.Label lbArrCity;
        private System.Windows.Forms.PictureBox picBoxAzman;
        private System.Windows.Forms.Label lbChildPrice;
        private System.Windows.Forms.Label lbInfantPrice;
        private System.Windows.Forms.TextBox tbChildPrice;
        private System.Windows.Forms.TextBox tbInfantPrice;
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.Label lbFlightID;
        private System.Windows.Forms.Label lbAircraft;
        private System.Windows.Forms.ComboBox cbDepartureCity;
        private System.Windows.Forms.ComboBox cbArrivalCity;
        private System.Windows.Forms.ComboBox cbAirCraft;
        private System.Windows.Forms.TextBox tbNewCity;
        private System.Windows.Forms.TextBox tbNewModel;
        private System.Windows.Forms.Button btnAddNewCity;
        private System.Windows.Forms.Button btnGenerateFlight;
        private System.Windows.Forms.DateTimePicker dtpFlightGenerater;
        private System.Windows.Forms.Button btnAddNewModel;
    }
}