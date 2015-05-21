using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        public Address OriginAddress { get; set; }
        public Address DestinationAddress { get; set; }

        public Parcel (Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        public override string ToString()
        {
            return string.Format("Origin Address:{0} \n\nDestination Address: {1}",
                OriginAddress, DestinationAddress);
        }

        public abstract decimal CalcCost();
    }
}
