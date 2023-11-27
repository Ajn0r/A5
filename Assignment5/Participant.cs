using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Participant
    {
        #region //////// Fields/Instance variables /////////
        private Address address;
        private string firstName;
        private string lastName;

        #endregion

        #region //////// Properties /////////

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set
            { lastName = value; }
        }
        public string FullName
        {
            get { return lastName.ToUpper() + ", " + firstName; }
        }

        #endregion

        #region //////// Constructors /////////

        // Constructor that creates an address object
        public Participant()
        {
            address = new Address();
        }

        // Constructor with all parameters
        public Participant(Address adr, string firstName, string lastName)
        {
            // Check if the address is null, if it is create a new address object
            if (adr == null)
                address = new Address();
            // else, set the address to the address passed in
            else
                address = adr;

            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Copy constructor
        public Participant(Participant copyParticipant)
        {
            // copy the address object by creating a new address object and passing in the address object from the copyParticipant
            address = new Address(copyParticipant.address);
            firstName = copyParticipant.firstName;
            lastName = copyParticipant.lastName;
        }

        #endregion

        #region //////// Methods /////////

        // ToString() method to return the participant as a string with the full name and address
        public override string ToString()
        {
            string strOut = string.Format("{0, -35} {1}", FullName, address.ToString());
            return strOut;
        }

        // Validate method to validate that the names are not empty and that the address is valid
        public bool Validate()
        {
            bool nameOk = !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);
            bool addressOk = false;
            // Check if the address is null, if it is not, call the validate method on the address object
            if (address != null)
                addressOk = address.Validate();
            return nameOk && addressOk;
        }

        #endregion
    }
}
