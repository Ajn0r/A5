using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        #region //////// Fields/Instance variables ////////
        private string city;
        private string street;
        private string zipCode;
        private Countries country;

        #endregion

        #region //////// Properties ////////

        public string City
        {
            get { return city; }
            set { 
                if (value.Length > 0)
                    city = value; 
            }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        #endregion

        #region //////// Constructors ////////

        // Constructor with all parameters
        public Address(string city, string street, string zipCode, Countries country)
        {
            this.city = city;
            this.street = street;
            this.zipCode = zipCode;
            this.country = country;
        }
        
        // Chained constructor with 3 parameters, country is set to Unknown
        public Address(string city, string street, string zipCode) : this(city, street, zipCode, Countries.Unknown) { }
 
        // Chained constructor with 2 parameters, zipCode is set to empty string and country is set to Unknown
        public Address(string city, string street) : this(city, street, string.Empty) { }

        // Chained constructor with 1 parameter, street is set to empty string, zipCode is set to empty string and country is set to Unknown
        public Address(string city) : this(city, string.Empty) { }

        // Default constructor
        public Address() : this(string.Empty) { }

        // Copy constructor
        public Address(Address copyAddress)
        {
            city = copyAddress.city;
            street = copyAddress.street;
            zipCode = copyAddress.zipCode;
            country = copyAddress.country;
        }

        #endregion

        #region //////// Methods ////////

        // Method to get the country as a string, with spaces instead of underscores
        public string GetCountryString()
        {
            return country.ToString().Replace('_', ' ');
        }

        // Method to get the address as a string formated for better readability
        public override string ToString()
        {
            return string.Format("{0, -25}, {1, -8}, {2, -5}, {3}", street, city, zipCode, GetCountryString());
        }

        // Method to validate that atleast the city is not empty
        public bool Validate()
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }

        #endregion
    }
}
