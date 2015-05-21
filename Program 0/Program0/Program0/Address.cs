using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Program 0
 * CIS 200-10
 * Due: 5/21/2015
 * By: Nick Wolf
 * 
 * The class Address allows users to create addresses and the owner of the address. It 
 * Also format the string output.
 */
namespace Program0
{
    public class Address
    {
        public const int MAX_ZIP = 99999; // Maximum ZipCode value
        //Name of the ower of Address
        public string Name { get; set; }
        //The ower first Address
        public string AddressOne { get; set; }
        //The ower second Address
        public string AddressTwo { get; set; }
        //The city of the address
        public string City { get; set; }
        //The state of the address
        public string State { get; set; }
        //32 bit 0 to 4,294,967,295, inclusive for zipcode
        private uint zipCode;

        //Precondtion:  0 <= oZip <= MAX_ZIP,
        // Postcondition: The address is created with the specified values for
        //                Name, addressOne, addressTwo, City, State, zip
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
            // Precondition:  None
            // Postcondition: The address's zip code
            get
            {
                return zipCode;
            }// end get
            
            // Precondition:  0 <= value <= MAX_ZIP
            // Postcondition: The address's zip code has been set to the
            //                specified value
            set
            {
                if ((value >= 0) && (value <= MAX_ZIP))
                {
                    zipCode = value;
                }
                else
                { 
                    throw new ArgumentOutOfRangeException("Zipcode",
                        value, "Zipcode must be >= 0");
                }
            }//end set
        }// end property Zipcode

        // Precondition:  None
        // Postcondition: A String with the address's data has been returned
        public override string ToString()
        {
            return string.Format(
                "\n{0}: {1} \n{2}: {3} \n{4}: {5} \n{6}: {7} {8} {9:D5}",
                "Name", Name,
                "Address One", AddressOne, 
                "Addess Two", AddressTwo,
                "City and State and Zip", City, State, Zipcode);
        }// end method ToString
        
    }
}
