using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        #region //////// Fields/Instance variables /////////
        private List<Participant> participants;
        #endregion

        #region //////// Constructor /////////
        public ParticipantManager()
        {
            // Initialize the list of participants
            participants = new List<Participant>();
        }
        #endregion

        #region //////// Methods /////////
        // Method to check that the index is valid
        private bool CheckIndex(int index)
        {
            // If the index is greater than or equal to 0 and less than the number of participants
            // it is valid and should return true, else it is invalid and should return false
            if (index >= 0 && index < participants.Count)
                return true;
            else
                return false;
        }

        // Method to get the number of participants
        public int Count
        {
            get { return participants.Count; }
        }

        // Method that takes the first and last name of an participant and an address object
        // and creates a new participant object, and then add it to the list of participants,
        // returns a bool value of the outcome
        public bool AddParticipant(string firstName, string lastName, Address address)
        {
            Participant participant = new Participant(address, firstName, lastName);
            participants.Add(participant);
            return true;
        }

        // Overloaded method that takes an participant object, add it to the list of participants
        // and returns a bool value of the outcome
        public bool AddParticipant(Participant participant)
        {
            // Check if the participant is not null
            if (participant != null)
            {
                // Add the participant to the list of participants
                participants.Add(participant);
                return true;
            }
            else
                return false;
        }

        // Method to change a participant and return a bool value of the outcome
        public bool ChangeParticipant(Participant participant, int index)
        {
            // Check if the index is valid and if the participant is not null
            if (CheckIndex(index) && (participant != null))
            {
                // Change the participant at the index to the participant passed in
                participants[index] = participant;
                return true;
            }
            else
                return false;
        }

        // Method to remove a participant and return a bool value of the outcome
        public bool RemoveParticipant(int index)
        {
            // Check if the index is valid
            if (CheckIndex(index))
            {
                // Remove the participant at the index
                participants.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        // Method to get a participant at a specific index
        // should return null if the index is invalid and a copy of the participant at the index if it is valid
        public Participant GetParticipant(int index)
        {
            // Check if the index is valid
            if (CheckIndex(index))
            {
                // Create and return a copy of the participant at the index
                return new Participant(participants[index]);
            }
            // If the index is invalid, return null
            else
                return null;
        }

        public string[] GetParticipantsInfo()
        {
            // A string array to hold the info of the participants,
            // and is created the same lenght as the number of participants
            string[] info = new string[participants.Count];

            // A for loop to go through all the participants
            int i = 0;
            foreach (Participant participant in participants)
            {
                // Add the participant to the string array
                info[i] = participant.ToString();
                // increment i
                i++;
            }
            return info;
        }

        #endregion
    }
}
