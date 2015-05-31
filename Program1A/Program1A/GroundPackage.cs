using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GroundPackage : Package
{

    public GroundPackage(Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {

    }
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

    public override decimal CalcCost()
    {
        const decimal DIM_FACTOR = .20m;    // Dimension coefficient in cost equation
        const decimal WEIGHT_FACTOR = .5m; // Weight coefficient in cost equation

        return DIM_FACTOR * (Convert.ToDecimal(PackageLenght) + Convert.ToDecimal(PackageWidth) + Convert.ToDecimal(PackageHeight)) + WEIGHT_FACTOR * (ZoneDistance + 1) * (Convert.ToDecimal(PackageWeight));
    }

    public override string ToString()
    {
        return String.Format("Ground Package{1}{0}", base.ToString(), /*ZoneDistance,*/ Environment.NewLine);
    }
}