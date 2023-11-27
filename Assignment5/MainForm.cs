namespace Assignment5
{
    public partial class MainForm : Form
    {
        // Declare an event manager object
        private EventManager eventManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        #region //////// Methods /////////

        // Method to initialize the GUI
        public void InitializeGUI()
        {
            // set the default title text of the window when the program starts
            this.Text = "Party organizer by Ronja Sjögren";
            // Disable the group box for adding participants
            grpBAddParticipant.Enabled = false;
            // Fill the combo box with the different types of countries from the enum
            comboBCountry.DataSource = Enum.GetValues(typeof(Countries));
            // Set the default selected index of the combo box to Sweden
            comboBCountry.SelectedIndex = (int)Countries.Sverige;
        }

        // Method to update the GUI
        private void UpdateGUI()
        {
            // Create a string array to hold the participants info
            string[] stringInfo = eventManager.Participants.GetParticipantsInfo();

            // check if the string array is not null
            if (stringInfo != null)
            {
                // Clear the list box
                lBoxParticipants.Items.Clear();
                // Add the participants info to the list box
                lBoxParticipants.Items.AddRange(stringInfo);
                // Set the label for the total number of participants
                lblResultNumOfParticipants.Text = eventManager.Participants.Count.ToString();
            }

            // Calculate and set the total cost, fee and surplus/decifit labels
            double totalCost = eventManager.CalculateTotalCost();
            lblResultTotalCost.Text = totalCost.ToString("0.00");

            double totalFee = eventManager.CalculateTotalFee();
            lblResultTotalFees.Text = totalFee.ToString("0.00");

            lblResultSurDef.Text = (totalFee - totalCost).ToString("0.00");

            // Set the label for the total number of participants
            lblResultNumOfParticipants.Text = eventManager.Participants.Count.ToString();

            // Clear the text boxes
            ClearTextBoxes();
        }

        // Method to read the cost per person
        private bool ReadCostPerPerson()
        {
            // Declare a variable to hold the cost per person
            double costPerPerson;

            // Try to parse the text in the cost per person text box
            if (double.TryParse(txtCostPerPart.Text, out costPerPerson) && (costPerPerson >= 0))
            {
                // If the parsing was successful, set the cost per person property
                eventManager.CostPerPerson = costPerPerson;
                return true;
            }
            else
            {
                // If the parsing failed, display an error message
                MessageBox.Show("Invalid cost per person, please try again", "Error");
                return false;
            }
        }

        // Method to read the fee per person
        private bool ReadFeePerPerson()
        {
            // Declare a variable to hold the fee per person
            double feePerPerson;

            // Try to parse the text in the fee per person text box
            if (double.TryParse(txtFeePerPart.Text, out feePerPerson) && (feePerPerson >= 0))
            {
                // If the parsing was successful, set the fee per person property
                eventManager.FeePerPerson = feePerPerson;
                return true;
            }
            else
            {
                // If the parsing failed, display an error message
                MessageBox.Show("Invalid fee per person, please try again", "Error");
                return false;
            }
        }

        // Method to create a new event
        private void CreateEvent()
        {
            // Create an event manager object
            eventManager = new EventManager();

            // Read the title
            eventManager.Title = txtEventTitle.Text;
            if (string.IsNullOrEmpty(eventManager.Title))
            {
                // if the title is empty, set a default title
                txtEventTitle.Text = "Untitled Event";
            }
            // Set the title of the event manager object
            eventManager.Title = txtEventTitle.Text + " by Ronja Sjögren";
            // Set the title of the window
            this.Text = eventManager.Title;

            // Read the cost per person and the fee per person and check if they are valid
            bool costOk = ReadCostPerPerson();
            bool feeOk = ReadFeePerPerson();

            // If valid, enable the group box for adding participants, display a success message and update the GUI
            if (costOk && feeOk)
            {
                grpBAddParticipant.Enabled = true;
                MessageBox.Show("Event created successfully", "Success");
                UpdateGUI();
            }
        }

        // Method to trim the text of any white spaces
        private string TrimText(string text)
        {
            // check if the text is not empty
            if (!string.IsNullOrEmpty(text))
            {
                // trim the text to remove any white spaces
                text = text.Trim();
            }
            return text;

        }
        // Method to read the input and add a participant
        private bool AddParticipant(ref Participant participant)
        {
            // Call the method to read the participant data and save the result in a bool variable
            bool ok = ReadParticipantData(ref participant);
            if (ok)
            {
                // Add the participant to the participant manager
                eventManager.Participants.AddParticipant(participant);
                // Display a success message
                MessageBox.Show("Participant added successfully", "Success");
                // Update the GUI
                UpdateGUI();
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid input, please try again", "Error");
            }
            return ok;

        }
        // Method to read the participant data
        private bool ReadParticipantData(ref Participant participant)
        {
            // Read name and address
            participant.FirstName = TrimText(txtFirstName.Text);
            participant.LastName = TrimText(txtLastName.Text);

            // Read the address
            Address adress = ReadAddress();
            // Save the address object to the participant object
            participant.Address = adress;
            // Return the result of the validation of the participant object
            return participant.Validate();
        }
        // Method to read the address and create an address object
        private Address ReadAddress()
        {
            // Create a new address object
            Address adress = new Address();

            // Read the address
            adress.City = txtCity.Text;
            adress.Street = txtStreet.Text;
            adress.ZipCode = txtZipCode.Text;
            adress.Country = (Countries)comboBCountry.SelectedIndex;

            if (adress.Validate())
            {
                // If the address is valid, return the address object
                return adress;
            }
            else
            {
                // Else, display an error message and return null
                MessageBox.Show("Invalid address, please try again", "Error");
                return null;
            }
        }

        // Method to double check if the user wants to create a new party
        private bool CheckNewParty()
        {
            // Check if the user wants to create a new party, informing them that the current party will be deleted
            DialogResult result = MessageBox.Show("Do you want to create a new party? The current party will be deleted", "New party", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // If the user wants to create a new party, clear the text boxes and return true
                ClearTextBoxes();
                return true;
            }
            else
            {
                // If the user doesn't want to create a new party, return false
                return false;
            }
        }

        // Method to delete a participant
        private void DeleteParticipant()
        {
            // Check if there is a participant selected
            if (lBoxParticipants.SelectedIndex >= 0)
            {
                // If there is, check if the user wants to delete the participant
                DialogResult result = MessageBox.Show("Do you want to delete the selected participant?", "Delete participant", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // If the user wants to delete the participant, remove the participant from the participant manager
                    eventManager.Participants.RemoveParticipant(lBoxParticipants.SelectedIndex);
                    // Update the GUI
                    UpdateGUI();
                }
            }
            else
            {
                // If there is no participant selected, display an error message
                MessageBox.Show("No participant selected, please select a participant", "Error");
            }
        }

        // Method to change a participant
        private void ChangeParticipant()
        {
            // check that therE is a participant selected
            if (lBoxParticipants.SelectedIndex >= 0)
            {
                // If there is, get all the data from the selected participant
                Participant participant = eventManager.Participants.GetParticipant(lBoxParticipants.SelectedIndex);

                // Read the input and save the result in a bool variable
                bool ok = ReadParticipantData(ref participant);

                // if the new values are valid, call the change participant method and update the GUI
                if (ok)
                {
                    // If the input was valid, change the participant at the selected index to the new participant
                    eventManager.Participants.ChangeParticipant(participant, lBoxParticipants.SelectedIndex);
                    // Display a success message
                    MessageBox.Show("Participant changed successfully", "Success");
                    // Update the GUI
                    UpdateGUI();
                }
            }
            else
            {
                // If there is no participant selected, display an error message
                MessageBox.Show("No participant selected, please select a participant", "Error");
            }
        }

        // Method to set the text boxes to the data from the participant
        private void SetParticipant(ref Participant participant)
        {
            if (participant != null)
            {
                // Set the text boxes to the data from the participant
                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtCity.Text = participant.Address.City;
                txtStreet.Text = participant.Address.Street;
                txtZipCode.Text = participant.Address.ZipCode;
                comboBCountry.SelectedIndex = (int)participant.Address.Country;
            }
        }

        // Method to clear the participant text boxes
        private void ClearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtStreet.Clear();
            txtZipCode.Clear();
        }

        #endregion

        #region //////// Event handlers /////////

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // Check if there is an party already created
            if (eventManager != null)
            {
                // If there is, check if the user wants to create a new party
                bool newParty = CheckNewParty();
                if (newParty)
                {
                    // If the user wants to create a new party, create a new event
                    CreateEvent();
                }
            }
            else
            {
                // If there is no party created, create a new event
                CreateEvent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new participant object
            Participant participant = new Participant();
            AddParticipant(ref participant);
            UpdateGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteParticipant();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeParticipant();
        }

        private void lBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check that there is a participant selected
            if (lBoxParticipants.SelectedIndex >= 0)
            {
                // If there is, get all the data from the selected participant
                Participant participant = eventManager.Participants.GetParticipant(lBoxParticipants.SelectedIndex);
                SetParticipant(ref participant);
            }
        }

        #endregion
    }
}