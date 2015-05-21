using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        //read only
        public string Name { get; private set; }
        //read only
        public string AddressOne { get; private set; }
        //read only
        public string AddressTwo { get; private set; }
        //read only
        public string City { get; private set; }
        //ready only
        public string State { get; private set; }
        //32 bit 0 to 4,294,967,295, inclusive
        private uint zipCode;
        // five-parameter constructor
        public Address(string name, string addressOne, string addressTwo, string city, string state, uint zip)
        {
            Name = name;
            AddressOne = addressOne;
            AddressTwo = addressTwo;
            City = city;
            State = state;
            Zipcode = zip; // validate zipcode via property
        }// end five-parameter Address constructor

        // property that gets and sets the zip code on the address
        public uint Zipcode
        {
            get
            {
                return zipCode;
            }// end get
            set
            {
                if ( value >= 0 && value <= 99999)
                    zipCode = value;
                else
                    throw new ArgumentOutOfRangeException("Zipcode",
                        value, "Zipcode must be >= 0");
            }//end set
        }// end property Zipcode

        //Retuen string representation of Address object
        public override string ToString()
        {
            return string.Format(
                "\n{0}: {1} \n{2}: {3} \n{4}: {5} \n{6} {7} {8} {9:D5}",
                "Name", Name,
                "Address One", AddressOne, 
                "Addess Two", AddressTwo,
                "City and State and Zip", City, State, Zipcode);
        }// end method ToString
        
    }
}
