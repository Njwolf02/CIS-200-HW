// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Nick Wolf

// File: TwoDayAirPackage.cs

// The TwoDayAirPackage class is a concrete derived class of AirPackage. TwoDayAirPackage
// have a Delivery type.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoDayAirPackage : AirPackage
{
    public enum Delivery { Early, Saver }; //enum delivery helper type

    // Precondition:  lenght >= 0, width >= 0, height >= 0, weight >= 0, fee >= 0
    // Postcondition: The NextDayAirPackage is created with the specified values for
    //                origin address, destination address, lenght, width, height, weight,  and type
    public TwoDayAirPackage(Address originAddress, Address destAddress
        , double lenght, double width, double height, double weight
        , Delivery type)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
        DeliveryType = type;
    }

    private Delivery DeliveryType
    {
        // Precondition:  None
        // Postcondition: The TwoDayAirPackage's DeliveryType has been returned
        get;

        // Precondition:  None
        // Postcondition: The TwoDayAirPackage's DeliveryType has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The TwoDayAirPackage's cost has been returned
    public override decimal CalcCost()
    {
        const decimal DIM_FACTOR = .25m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .25m; // Weight coefficient in cost equation
        const decimal SAVER_DISCOUNT = .10m; // Saver Discount precent about off

        decimal saverAmount; // The percent save
        decimal baseCost; // the cost before saver in
        decimal totalCost; // The total cost after saver

        baseCost = DIM_FACTOR * (Convert.ToDecimal(PackageLenght) + Convert.ToDecimal(PackageWidth) + Convert.ToDecimal(PackageHeight)) + WEIGHT_FACTOR * (Convert.ToDecimal(PackageWeight));

        if (DeliveryType < Delivery.Saver)
        {
            saverAmount = 0;
        }
        else
        {
            saverAmount = SAVER_DISCOUNT;
        }

        totalCost = baseCost * (1 - saverAmount);

        return totalCost;
    }

    // Precondition:  None
    // Postcondition: A String with the TwoDayAirPackage's data has been returned
    public override string ToString()
    {
        return String.Format("Two Day Air Package: {2}{0}{2}Delivery Type: {1}{2}", base.ToString(), DeliveryType, Environment.NewLine);
    }
}