// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Nick Wolf

// File: NextDayAirPackage.cs

// The NextDayAirPackage class is a concrete derived class of AirPackage. NextDayAirPackage
// have a ExpressFee.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NextDayAirPackage : AirPackage
{

    // Precondition:  lenght >= 0, width >= 0, height >= 0, weight >= 0, fee >= 0
    // Postcondition: The NextDayAirPackage is created with the specified values for
    //                origin address, destination address, lenght, width, height, weight,  and fee
    public NextDayAirPackage(Address originAddress, Address destAddress
        , double lenght, double width, double height, double weight
        , decimal fee)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
        ExpressFee = fee;
    }
    private decimal ExpressFee // Helper property
    {
        // Precondition:  None
        // Postcondition: The NextDayAirPackage's ExpressFee has been returned
        get;

        // Precondition:  None
        // Postcondition: The NextDayAirPackage's ExpressFee cost has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The NextDayAirPackage's cost has been returned
    public override decimal CalcCost()
    {
        const decimal OVER_WEIGHT_UPCHARGE = .25M; //OVER WEIGHT UPCHARGE in cost equation
        const decimal OVER_SIZE_UPCHARGE = .25M; //OVER SIZE UPCHARGE in cost equation
        const decimal DIM_FACTOR = .40m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .30m; // Weight coefficient in cost equation
        decimal baseCost; //cost before additional charges
        decimal totalCost; //cost after additional charges
        decimal weightUpChargeTotal; //total upcharge based on wieght over
        decimal sizeUpChargeTotal; //total upcharge based on size over

        baseCost = DIM_FACTOR * (Convert.ToDecimal(PackageLenght) + Convert.ToDecimal(PackageWidth) + Convert.ToDecimal(PackageHeight)) + WEIGHT_FACTOR * (Convert.ToDecimal(PackageWeight)) + ExpressFee;
        
        if(IsHeavy())
            {
                weightUpChargeTotal = OVER_WEIGHT_UPCHARGE * baseCost;
            }
        else
            {
                weightUpChargeTotal = 0;
            }
        if(IsLarge())
            {
                sizeUpChargeTotal = OVER_SIZE_UPCHARGE * baseCost;
            }
        else
            {
                sizeUpChargeTotal = 0;
            }

            totalCost = baseCost + weightUpChargeTotal + sizeUpChargeTotal;

            return totalCost;
    }

    // Precondition:  None
    // Postcondition: A String with the NextDayAirPackage's data has been returned
    public override string ToString()
    {
        return String.Format("Next Day Air Package {0}{2}Express Fee: {1}", base.ToString(), ExpressFee, Environment.NewLine);
    }

}