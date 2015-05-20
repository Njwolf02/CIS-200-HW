using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Address
    {
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
        public Address(string addressOne, string addressTwo, string city, string state, uint zip)
        {
            AddressOne = addressOne;
            AddressTwo = addressTwo;
            City = city;
            State = state;

        }
        
    }
}
