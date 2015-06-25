using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class OrderByDesZip : IComparer<Parcel>
{
    public int Compare(Parcel p1, Parcel p2)
    {
        if (p1 == null && p2 == null)
            return 0;
        if (p2 == null)
            return -1;

        return p2.DestinationAddress.Zip.CompareTo(p1.DestinationAddress.Zip);
    }
}