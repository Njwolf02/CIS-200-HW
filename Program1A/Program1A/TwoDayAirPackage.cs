using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoDayAirPackage : AirPackage
{
    public enum Delivery { Early, Saver };

    public TwoDayAirPackage(Address originAddress, Address destAddress
        , double lenght, double width, double height, double weight
        , Delivery type)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
        DeliveryType = type;
    }

    private Delivery DeliveryType
    {
        get;
        set;
    }

    public override decimal CalcCost()
    {
        const decimal DIM_FACTOR = .25m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .25m; // Weight coefficient in cost equation
        const decimal SAVER_DISCOUNT = .10m;

        decimal saverAmount;
        decimal baseCost;
        decimal totalCost;

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

    public override string ToString()
    {
        return String.Format("Two Day Air Package: {2}{0}{2}Delivery Type: {1}{2}", base.ToString(), DeliveryType, Environment.NewLine);
    }
}