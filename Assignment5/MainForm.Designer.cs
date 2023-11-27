namespace Assignment5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBNewEvent = new GroupBox();
            txtFeePerPart = new TextBox();
            txtCostPerPart = new TextBox();
            txtEventTitle = new TextBox();
            lblFeePerPart = new Label();
            lblCostPerPart = new Label();
            lblEventTitle = new Label();
            btnCreateEvent = new Button();
            grpBAddParticipant = new GroupBox();
            comboBCountry = new ComboBox();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnAdd = new Button();
            lblCountry = new Label();
            lblZipCode = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            grpBEventEconomy = new GroupBox();
            lblSurDef = new Label();
            lblTotalCost = new Label();
            lblResultNumOfParticipants = new Label();
            lblResultSurDef = new Label();
            lblNumOfParticipants = new Label();
            lblResultTotalCost = new Label();
            lblTotalFees = new Label();
            lblResultTotalFees = new Label();
            lBoxParticipants = new ListBox();
            lblParticipants = new Label();
            lblAddress = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            grpBNewEvent.SuspendLayout();
            grpBAddParticipant.SuspendLayout();
            grpBEventEconomy.SuspendLayout();
            SuspendLayout();
            // 
            // grpBNewEvent
            // 
            grpBNewEvent.Controls.Add(txtFeePerPart);
            grpBNewEvent.Controls.Add(txtCostPerPart);
            grpBNewEvent.Controls.Add(txtEventTitle);
            grpBNewEvent.Controls.Add(lblFeePerPart);
            grpBNewEvent.Controls.Add(lblCostPerPart);
            grpBNewEvent.Controls.Add(lblEventTitle);
            grpBNewEvent.Controls.Add(btnCreateEvent);
            grpBNewEvent.Location = new Point(12, 12);
            grpBNewEvent.Name = "grpBNewEvent";
            grpBNewEvent.Size = new Size(249, 174);
            grpBNewEvent.TabIndex = 0;
            grpBNewEvent.TabStop = false;
            grpBNewEvent.Text = "New Event";
            // 
            // txtFeePerPart
            // 
            txtFeePerPart.Location = new Point(141, 88);
            txtFeePerPart.Name = "txtFeePerPart";
            txtFeePerPart.Size = new Size(96, 23);
            txtFeePerPart.TabIndex = 6;
            // 
            // txtCostPerPart
            // 
            txtCostPerPart.Location = new Point(141, 58);
            txtCostPerPart.Name = "txtCostPerPart";
            txtCostPerPart.Size = new Size(96, 23);
            txtCostPerPart.TabIndex = 5;
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(83, 28);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(154, 23);
            txtEventTitle.TabIndex = 4;
            // 
            // lblFeePerPart
            // 
            lblFeePerPart.AutoSize = true;
            lblFeePerPart.Location = new Point(12, 92);
            lblFeePerPart.Name = "lblFeePerPart";
            lblFeePerPart.Size = new Size(105, 15);
            lblFeePerPart.TabIndex = 3;
            lblFeePerPart.Text = "Fee per participant";
            // 
            // lblCostPerPart
            // 
            lblCostPerPart.AutoSize = true;
            lblCostPerPart.Location = new Point(12, 62);
            lblCostPerPart.Name = "lblCostPerPart";
            lblCostPerPart.Size = new Size(111, 15);
            lblCostPerPart.TabIndex = 2;
            lblCostPerPart.Text = "Cost per participant";
            // 
            // lblEventTitle
            // 
            lblEventTitle.AutoSize = true;
            lblEventTitle.Location = new Point(12, 32);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new Size(59, 15);
            lblEventTitle.TabIndex = 1;
            lblEventTitle.Text = "Event title";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(77, 128);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(83, 27);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // grpBAddParticipant
            // 
            grpBAddParticipant.Controls.Add(comboBCountry);
            grpBAddParticipant.Controls.Add(txtZipCode);
            grpBAddParticipant.Controls.Add(txtCity);
            grpBAddParticipant.Controls.Add(txtStreet);
            grpBAddParticipant.Controls.Add(txtLastName);
            grpBAddParticipant.Controls.Add(txtFirstName);
            grpBAddParticipant.Controls.Add(btnAdd);
            grpBAddParticipant.Controls.Add(lblCountry);
            grpBAddParticipant.Controls.Add(lblZipCode);
            grpBAddParticipant.Controls.Add(lblCity);
            grpBAddParticipant.Controls.Add(lblStreet);
            grpBAddParticipant.Controls.Add(lblLastName);
            grpBAddParticipant.Controls.Add(lblFirstName);
            grpBAddParticipant.Location = new Point(12, 210);
            grpBAddParticipant.Name = "grpBAddParticipant";
            grpBAddParticipant.Size = new Size(249, 316);
            grpBAddParticipant.TabIndex = 1;
            grpBAddParticipant.TabStop = false;
            grpBAddParticipant.Text = "Add participant";
            // 
            // comboBCountry
            // 
            comboBCountry.FormattingEnabled = true;
            comboBCountry.Location = new Point(89, 202);
            comboBCountry.Name = "comboBCountry";
            comboBCountry.Size = new Size(148, 23);
            comboBCountry.TabIndex = 13;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(89, 168);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(148, 23);
            txtZipCode.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(89, 134);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(148, 23);
            txtCity.TabIndex = 11;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(89, 100);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(148, 23);
            txtStreet.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(89, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(89, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(74, 267);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(12, 206);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 7;
            lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(12, 172);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(55, 15);
            lblZipCode.TabIndex = 6;
            lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 138);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 5;
            lblCity.Text = "City";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(12, 104);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 4;
            lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 36);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // grpBEventEconomy
            // 
            grpBEventEconomy.Controls.Add(lblSurDef);
            grpBEventEconomy.Controls.Add(lblTotalCost);
            grpBEventEconomy.Controls.Add(lblResultNumOfParticipants);
            grpBEventEconomy.Controls.Add(lblResultSurDef);
            grpBEventEconomy.Controls.Add(lblNumOfParticipants);
            grpBEventEconomy.Controls.Add(lblResultTotalCost);
            grpBEventEconomy.Controls.Add(lblTotalFees);
            grpBEventEconomy.Controls.Add(lblResultTotalFees);
            grpBEventEconomy.Location = new Point(365, 324);
            grpBEventEconomy.Name = "grpBEventEconomy";
            grpBEventEconomy.Size = new Size(329, 180);
            grpBEventEconomy.TabIndex = 1;
            grpBEventEconomy.TabStop = false;
            grpBEventEconomy.Text = "Event economy";
            // 
            // lblSurDef
            // 
            lblSurDef.AutoSize = true;
            lblSurDef.Location = new Point(17, 130);
            lblSurDef.Name = "lblSurDef";
            lblSurDef.Size = new Size(85, 15);
            lblSurDef.TabIndex = 9;
            lblSurDef.Text = "Surplus/Deficit";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(17, 72);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(57, 15);
            lblTotalCost.TabIndex = 6;
            lblTotalCost.Text = "Total cost";
            // 
            // lblResultNumOfParticipants
            // 
            lblResultNumOfParticipants.AutoSize = true;
            lblResultNumOfParticipants.BorderStyle = BorderStyle.Fixed3D;
            lblResultNumOfParticipants.Location = new Point(196, 36);
            lblResultNumOfParticipants.MinimumSize = new Size(100, 28);
            lblResultNumOfParticipants.Name = "lblResultNumOfParticipants";
            lblResultNumOfParticipants.Size = new Size(100, 28);
            lblResultNumOfParticipants.TabIndex = 2;
            // 
            // lblResultSurDef
            // 
            lblResultSurDef.AutoSize = true;
            lblResultSurDef.BorderStyle = BorderStyle.Fixed3D;
            lblResultSurDef.Location = new Point(196, 123);
            lblResultSurDef.MinimumSize = new Size(100, 28);
            lblResultSurDef.Name = "lblResultSurDef";
            lblResultSurDef.Size = new Size(100, 28);
            lblResultSurDef.TabIndex = 8;
            // 
            // lblNumOfParticipants
            // 
            lblNumOfParticipants.AutoSize = true;
            lblNumOfParticipants.Location = new Point(17, 43);
            lblNumOfParticipants.Name = "lblNumOfParticipants";
            lblNumOfParticipants.Size = new Size(130, 15);
            lblNumOfParticipants.TabIndex = 3;
            lblNumOfParticipants.Text = "Number of participants";
            // 
            // lblResultTotalCost
            // 
            lblResultTotalCost.AutoSize = true;
            lblResultTotalCost.BorderStyle = BorderStyle.Fixed3D;
            lblResultTotalCost.Location = new Point(196, 65);
            lblResultTotalCost.MinimumSize = new Size(100, 28);
            lblResultTotalCost.Name = "lblResultTotalCost";
            lblResultTotalCost.Size = new Size(100, 28);
            lblResultTotalCost.TabIndex = 4;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(17, 101);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(56, 15);
            lblTotalFees.TabIndex = 7;
            lblTotalFees.Text = "Total fees";
            // 
            // lblResultTotalFees
            // 
            lblResultTotalFees.AutoSize = true;
            lblResultTotalFees.BorderStyle = BorderStyle.Fixed3D;
            lblResultTotalFees.Location = new Point(196, 94);
            lblResultTotalFees.MinimumSize = new Size(100, 28);
            lblResultTotalFees.Name = "lblResultTotalFees";
            lblResultTotalFees.Size = new Size(100, 28);
            lblResultTotalFees.TabIndex = 5;
            // 
            // lBoxParticipants
            // 
            lBoxParticipants.FormattingEnabled = true;
            lBoxParticipants.ItemHeight = 15;
            lBoxParticipants.Location = new Point(280, 43);
            lBoxParticipants.Name = "lBoxParticipants";
            lBoxParticipants.Size = new Size(473, 229);
            lBoxParticipants.TabIndex = 4;
            lBoxParticipants.SelectedIndexChanged += lBoxParticipants_SelectedIndexChanged;
            // 
            // lblParticipants
            // 
            lblParticipants.AutoSize = true;
            lblParticipants.Location = new Point(332, 20);
            lblParticipants.Name = "lblParticipants";
            lblParticipants.Size = new Size(69, 15);
            lblParticipants.TabIndex = 5;
            lblParticipants.Text = "Participants";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(569, 20);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(406, 278);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(83, 27);
            btnChange.TabIndex = 5;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(549, 278);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 27);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 537);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(lblAddress);
            Controls.Add(lblParticipants);
            Controls.Add(lBoxParticipants);
            Controls.Add(grpBAddParticipant);
            Controls.Add(grpBEventEconomy);
            Controls.Add(grpBNewEvent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            grpBNewEvent.ResumeLayout(false);
            grpBNewEvent.PerformLayout();
            grpBAddParticipant.ResumeLayout(false);
            grpBAddParticipant.PerformLayout();
            grpBEventEconomy.ResumeLayout(false);
            grpBEventEconomy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBNewEvent;
        private Label lblFeePerPart;
        private Label lblCostPerPart;
        private Label lblEventTitle;
        private Button btnCreateEvent;
        private GroupBox grpBAddParticipant;
        private Label lblCountry;
        private Label lblZipCode;
        private Label lblCity;
        private Label lblStreet;
        private Label lblLastName;
        private Label lblFirstName;
        private GroupBox grpBEventEconomy;
        private Label lblSurDef;
        private Label lblTotalCost;
        private Label lblResultNumOfParticipants;
        private Label lblResultSurDef;
        private Label lblNumOfParticipants;
        private Label lblResultTotalCost;
        private Label lblTotalFees;
        private Label lblResultTotalFees;
        private ListBox lBoxParticipants;
        private Label lblParticipants;
        private Label lblAddress;
        private Button btnAdd;
        private Button btnChange;
        private Button btnDelete;
        private TextBox txtFeePerPart;
        private TextBox txtCostPerPart;
        private TextBox txtEventTitle;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ComboBox comboBCountry;
    }
}