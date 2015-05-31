using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCon
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal baseCost;
            decimal totalCost;
            decimal weightUpCharge;
            decimal sizeUpCharge;

            baseCost = 100;
            totalCost = 0;

            Console.WriteLine("totalCost:" + totalCost + Environment.NewLine
                + "BaseCost:" + baseCost + Environment.NewLine);

            if(true)
            {
                weightUpCharge = 10;
            }
            else
            {
                weightUpCharge = 0;
            }
            if(true)
            {
                sizeUpCharge = 25;
            }
            else
            {
                sizeUpCharge = 0;
            }

            totalCost = baseCost + weightUpCharge + sizeUpCharge;

            Console.WriteLine("After test total:"+ totalCost + Environment.NewLine);
        }
    }
}
