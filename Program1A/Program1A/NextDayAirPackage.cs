using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NextDayAirPackage : AirPackage
{

    public NextDayAirPackage(Address originAddress, Address destAddress
        , double lenght, double width, double height, double weight
        , decimal fee)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
        ExpressFee = fee;
    }
    private decimal ExpressFee
    {
        get;
        set;
    }

    public override decimal CalcCost()
    {
        const decimal OVER_WEIGHT_UPCHARGE = .25M;
        const decimal OVER_SIZE_UPCHARGE = .25M;
        const decimal DIM_FACTOR = .40m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .30m; // Weight coefficient in cost equation
        decimal baseCost;
        decimal totalCost;
        decimal weightUpChargeTotal;
        decimal sizeUpChargeTotal;

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
    public override string ToString()
    {
        return String.Format("Next Day Air Package {0}{2}Express Fee: {1}", base.ToString(), ExpressFee, Environment.NewLine);
    }

}