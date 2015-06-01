// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Nick Wolf

// File: AirPackage.cs

// The AirPackage class is a abstract derived class of Package. AirPackage
// have a OVER WEIGHT cost and OVER_SIZE_LIMIT cost.
// Also have method to decide if over weight and over size limit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AirPackage : Package
{
    const int OVER_WEIGHT = 75; //Max WEIGHT
    const int OVER_SIZE_LIMIT = 100; //MAX SIZE 

    // Precondition:  lenght >= 0, width >= 0, height >= 0, weight >= 0, 
    // Postcondition: The AirPackage is created with the specified values for
    //                origin address, destination address, lenght, width, height, and weight
    public AirPackage(Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
    }

    // Precondition:  PackageWeight >= 0
    // Postcondition: The AirPackage's is overwieght : true or false has been returned
    public bool IsHeavy()
    {
      return PackageWeight >= OVER_WEIGHT;
    }

    // Precondition:  PackageLenght >= 0, PackageWidth >= 0, PackageHeight >= 0
    // Postcondition: The AirPackage's is Is over size : true or false has been returned
    public bool IsLarge()
    {
        return (PackageLenght + PackageWidth + PackageHeight) >= OVER_SIZE_LIMIT;
    }

    // Precondition:  None
    // Postcondition: A String with the AirPackage's data has been returned
    public override string ToString()
    {
        return String.Format("{3}IsHeavy: {2}{3}IsLarge: {1}{3}{0}", base.ToString(), IsHeavy(), IsLarge(), Environment.NewLine);
    }
}
