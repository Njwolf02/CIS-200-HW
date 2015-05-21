using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel
    {
        private decimal fixcost;
        public Letter(string originAddress, string destinationAddress, decimal cost)
            : base(originAddress, destinationAddress)
        {
            Fixcost = cost;
        }

        public decimal Fixcost
        {
            get
            {
                return fixcost;
            }
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
        public override decimal CalcCost()
        {
            return fixcost;
        }
        public override string ToString()
        {
            return string.Format("Letter Cost: {0}\n{1}: {2:C}",
                base.ToString(), "Fix Cost", fixcost );
        }
    }
}
