using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        #region //////// Fields/Instance variables /////////
        private double costPerPerson;
        private double feePerPerson;
        private string title;
        private ParticipantManager participantManager;
        #endregion

        #region //////// Properties /////////
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set { costPerPerson = value; }
        }
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set { feePerPerson = value; }
        }
        public string Title
        {
            get { return title; }
            set { 
                if (!string.IsNullOrEmpty(value))
                    title = value; 
            }
        }

        public ParticipantManager Participants
        {
            get { return participantManager; }
        }
        #endregion

        #region //////// Constructors /////////
        // Default constructor
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }
        #endregion

        #region //////// Methods /////////
        // Method to calculate the total cost of the event
        public double CalculateTotalCost()
        {
            return participantManager.Count * costPerPerson;
        }
        // Method to calculate the total fee of the event
        public double CalculateTotalFee()
        {
            return participantManager.Count * feePerPerson;
        }

        #endregion
    }
}
