// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Nick Wolf

// File: GroundPackage.cs

// The GroundPackage class is a concrete derived class of Package. GroundPackage
// have method to calc zone distance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GroundPackage : Package
{

    // Precondition:  lenght >= 0, width >= 0, height >= 0, weight >= 0, 
    // Postcondition: The GroundPackage is created with the specified values for
    //                origin address, destination address, lenght, width, height, and weight
    public GroundPackage(Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {

    }

    // Precondition:  OriginAddress.Zip >= 0, DestinationAddress.Zip >= 0
    // Postcondition: The GroundPackage's ZoneDistance has been returned
    public int ZoneDistance
    {
        get
        {
            const int FIRST_DIGIT_FACTOR = 10000;
            int dist;

            dist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));

            return dist;
        }
    }

    // Precondition:  PackageLenght >= 0, PackageWidth >= 0, PackageHeight >= 0, PackageWeight >= 0, and ZoneDistance
    // Postcondition: The GroundPackage's cost has been returned
    public override decimal CalcCost()
    {
        const decimal DIM_FACTOR = .20m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .5m; // Weight coefficient in cost equation

        return DIM_FACTOR * (Convert.ToDecimal(PackageLenght) + Convert.ToDecimal(PackageWidth) + Convert.ToDecimal(PackageHeight)) + WEIGHT_FACTOR * (ZoneDistance + 1) * (Convert.ToDecimal(PackageWeight));
    }

    // Precondition:  None
    // Postcondition: A String with the GroundPackage's data has been returned
    public override string ToString()
    {
        return String.Format("Ground Package{2}{2}ZoneDistance: {1}{0}", base.ToString(), ZoneDistance, Environment.NewLine);
    }
}