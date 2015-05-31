using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AirPackage : Package
{
    const int OVER_WEIGHT = 75;
    const int OVER_SIZE_LIMIT = 100;

    public AirPackage(Address originAddress, Address destAddress,
        double lenght, double width, double height, double weight)
        : base (originAddress, destAddress, lenght, width, height, weight)
    {
    }

    public bool IsHeavy()
    {
      return PackageWeight >= 75;
    }

    public bool IsLarge()
    {
        return (PackageLenght + PackageWidth + PackageHeight) >= 100;
    }

    public override string ToString()
    {
        return String.Format("{3}IsHeavy: {2}{3}IsLarge: {1}{3}{0}", base.ToString(), IsHeavy(), IsLarge(), Environment.NewLine);
    }
}
