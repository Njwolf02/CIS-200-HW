using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        public string OriginAddress { get; private set; }
        public string DestinationAddress { get; private set; }

        public Parcel (string originAddress, string destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        public override string ToString()
        {
            return string.Format("Origin Address:{0} \n Destination Address: {1}",
                OriginAddress, DestinationAddress);
        }

        public abstract decimal CalcCost();
    }
}
