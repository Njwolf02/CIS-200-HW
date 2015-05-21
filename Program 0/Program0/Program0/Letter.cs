using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    //letter is a Parcel
    public class Letter : Parcel
    {
        //Letter fix cost to send. 
        private decimal fixcost;
        
        // Precondition:  0 <= fixcost

        // Postcondition: The letter is created with the specified values for
        //                fix cost, its origin address, and destination address
        public Letter(Address originAddress, Address destinationAddress, decimal cost)
            :base (originAddress, destinationAddress)
        {
            Fixcost = cost;
        }

        public decimal Fixcost
        {
            // Precondition:  None
            // Postcondition: The letter fix cost has been returned
            get
            {
                return fixcost;
            }
            // Precondition:  0 <= value
            // Postcondition: The letter fix cost has been set to the
            //                specified value
            set
            {
                if (value >= 0)
                {
                    fixcost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Fixcost", value, "Fixcost must be >= 0");
                }
            }
        }
        // Precondition:  fixcost enter in test program
        // Postcondition: The letter fix cost has been returned
        public override decimal CalcCost()
        {
            return fixcost;
        }
        // Precondition:  None
        // Postcondition: A String with the letter's data has been returned
        public override string ToString()
        {
            return string.Format("\n-------------\nNew letter:\n-------------\n{0} \n\n{1}: {2:C}\n",
                base.ToString(), "Fix Cost", fixcost );
        }
    }
}
