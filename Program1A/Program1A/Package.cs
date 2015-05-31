using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Package : Parcel
{
    private double packageLenght;
    private double packageWidth;
    private double packageHeight;
    private double packageWeight;

    public Package (Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress)
    {
        PackageLenght = lenght;
        PackageWidth = width;
        PackageHeight = height;
        PackageWeight = weight;
       
    }

    protected double PackageLenght
    {
        get
        {
            return packageLenght;
        }
        set
        {
            if (value >= 0)
                packageLenght = value;
            else
                throw new ArgumentOutOfRangeException("Package Lenght", value,
                    "Package lenght must be >= 0");
        }
    }

    protected double PackageWidth
    {
        get
        {
            return packageWidth;
        }
        set
        {
            if (value >= 0)
                packageWidth = value;
            else
                throw new ArgumentOutOfRangeException("Package Width", value,
                    "Package Width must be >= 0");
        }
    }

    protected double PackageHeight
    {
        get
        {
            return packageHeight;
        }
        set
        {
            if (value >= 0)
                packageHeight = value;
            else
                throw new ArgumentOutOfRangeException("Package Height", value,
                    "Package height must be >= 0");
        }
    }

    protected double PackageWeight
    {
        get
        {
            return packageWeight;
        }
        set
        {
            if (value >= 0)
                packageWeight = value;
            else
                throw new ArgumentOutOfRangeException("Package Height", value,
                    "Package height must be >= 0");
        }
    }

    public override string ToString()
    {;
    return String.Format("{5}Package Size:{5}PackageLenght: {1}{5}PackageHeight: {2}{5}PackageWidth: {3}{5}PackageWeight: {4}{5}{5}{0}"
            , base.ToString(), PackageLenght, PackageHeight, PackageWidth, PackageWeight, Environment.NewLine);
    }
}
