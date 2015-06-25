using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortByTypeThenCost : IComparer<Parcel>
{
    public int Compare(Parcel p1, Parcel p2)
    {
        // Implements correct handling of null values (in .NET, null less than anything)
        //if (this.GetType(),ToString().CompareTo(p2.GetType())) // Both null?
        //    return 0;

        //if (this == null) // only this is null?
        //    return -1;

        //if (p1 == null) // only t2 is null?
        //    return 1;

        //int hourCompare = this.GetType().ToString() - p1.GetType().ToString(); // Hour difference?

        if (p1.GetType().ToString() != p2.GetType().ToString()) // Check for Type difference first
            return p1.GetType().ToString().CompareTo(p2.GetType().ToString());
        else
            return p2.CalcCost().CompareTo(p1.CalcCost());

        //int minuteCompare = this.Minute - p1.Minute; // Minute difference?

        //if (minuteCompare != 0) // Check for minute difference next
        //    return minuteCompare;

        ////int secondCompare = this.Second - p1.Second; // Second difference?

        //return secondCompare;
    }
}