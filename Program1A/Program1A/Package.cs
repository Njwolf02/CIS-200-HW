// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Nick Wolf

// File: Package.cs

// The Package class is a abstract derived class of Parcel
// This classes stores a package size in inches that consisting of lenght,
// width, height, and weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Package : Parcel
{
    private double packageLenght; // package Lenght in inches
    private double packageWidth;  // package Width in inches
    private double packageHeight; // package Height in inches
    private double packageWeight; // package Height in inches

    // Precondition:  lenght >= 0, width >= 0, height >= 0, weight >= 0, fee >= 0
    // Postcondition: The NextDayAirPackage is created with the specified values for
    //                origin address, destination address, lenght, width, height, weight,  and fee
    public Package (Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress)
    {
        PackageLenght = lenght;
        PackageWidth = width;
        PackageHeight = height;
        PackageWeight = weight;
       
    }

    protected double PackageLenght // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's packageLenght has been returned
        get
        {
            return packageLenght;
        }

        // Precondition:  value >= 0
        // Postcondition: The Package's packageLenght has been set to the
        //                specified value
        set
        {
            if (value >= 0)
                packageLenght = value;
            else
                throw new ArgumentOutOfRangeException("Package Lenght", value,
                    "Package lenght must be >= 0");
        }
    }

    protected double PackageWidth // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's packageWidth has been returned
        get
        {
            return packageWidth;
        }
        // Precondition:  value >= 0
        // Postcondition: The Package's packageWidth has been set to the
        //                specified value
        set
        {
            if (value >= 0)
                packageWidth = value;
            else
                throw new ArgumentOutOfRangeException("Package Width", value,
                    "Package Width must be >= 0");
        }
    }

    protected double PackageHeight // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's packageHeight has been returned
        get
        {
            return packageHeight;
        }

        // Precondition:  value >= 0
        // Postcondition: The Package's packageHeight has been set to the
        //                specified value
        set
        {
            if (value >= 0)
                packageHeight = value;
            else
                throw new ArgumentOutOfRangeException("Package Height", value,
                    "Package height must be >= 0");
        }
    }

    protected double PackageWeight // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's packageWeight has been returned
        get
        {
            return packageWeight;
        }

        // Precondition:  value >= 0
        // Postcondition: The Package's packageWeight has been set to the
        //                specified value
        set
        {
            if (value >= 0)
                packageWeight = value;
            else
                throw new ArgumentOutOfRangeException("Package Height", value,
                    "Package height must be >= 0");
        }
    }

    // Precondition:  None
    // Postcondition: A String with the Package's data has been returned
    public override string ToString()
    {;
    return String.Format("{5}Package Size:{5}PackageLenght: {1}{5}PackageHeight: {2}{5}PackageWidth: {3}{5}PackageWeight: {4}{5}{5}{0}"
            , base.ToString(), PackageLenght, PackageHeight, PackageWidth, PackageWeight, Environment.NewLine);
    }
}
