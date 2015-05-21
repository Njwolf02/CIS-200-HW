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
 * This class has-a address for OriginAddress and a has-a address for DestinationAddress.
 * It allows user to assign origin address and destination address. It also have an abstract
 * method CalcCost.
 * 
 */
namespace Program0
{
    //Abstract class because method
    public abstract class Parcel
    {
        //Address object assign to Origin Address
        public Address OriginAddress { get; set; }
        //Address object assign to Destination Address
        public Address DestinationAddress { get; set; }
        // Precondition:  Have to have information inside Address
        // Postcondition: The origin Address and destination Address have to be return.
        public Parcel (Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }
        // Precondition:  None
        // Postcondition: A String with the Parcel's data has been returned and formatted
        public override string ToString()
        {
            return string.Format("Origin Address:{0} \n\nDestination Address: {1}",
                OriginAddress, DestinationAddress);
        }
        // Precondition:  None
        // Postcondition: None, for the next class problem
        public abstract decimal CalcCost();
    }
}
