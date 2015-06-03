// Program 1B
// CIS 200-10
// Summer 2015
// Due: 6/3/2015
// By: Nick Wolf and Andrew L. Wright

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1B
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Gonzo", "123 Music Lane", "Apt 1 or 2",
                "New York", "New York", 95124); // Test Address 5
            Address a6 = new Address("Kermit the Frog", "456 Muppet Lane", "Pond around back",
                "Bird-in-Hand", "Pennsylvania", 62754); // Test Address 6
            Address a7 = new Address("Count Von Count", "789 Counting St", "Coffin 3",
                "Chicken", "Alaska", 99991); // Test Address 7
            Address a8 = new Address("Cookie Monster", "1011 Cookie St", "Ap1 2",
                "George", "Washingon", 02321); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                           // Letter test object
            Letter l2 = new Letter(a3, a6, 4.23M);                           // Letter test object
            Letter l3 = new Letter(a7, a3, 3);                           // Letter test object

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a4, a5, 48, 2, 1, 10);        // Ground test object
            GroundPackage gp3 = new GroundPackage(a3, a2, 34, 12, 83, 30);        // Ground test object

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a2, 34, 34, 34, 10, 10.1M);// Next Day test object
            NextDayAirPackage ndap3 = new NextDayAirPackage(a8, a1, 10, 3, 2, 84, .99M);// Next Day test object

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a1, 23.1, 23, 42, 30, TwoDayAirPackage.Delivery.Early); // Two Day test object
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a3, a6, 5, 5.1, 5.2, 5.3, TwoDayAirPackage.Delivery.Saver); // Two Day test object

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Original List End");
            Pause();

            // Holds results of LINQ to Select all Parcels and order by destination zip
            var parcelOrderByDesZip =
                from p in parcels                                   //Set range from list parcels
                orderby p.DestinationAddress.Zip descending         //order by the Zip of the Destination Address 
                select p;                                           //Select to show all

            //Displays Result from LINQ parcelOrderByDesZip
            Console.WriteLine("Select all Parcels and order by destination zip (descending):");
            Console.WriteLine("====================");
            foreach (var a in parcelOrderByDesZip)
            {
                Console.WriteLine(a);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Select all Parcels and order by destination zip END");
            Pause();

            // Holds results of LINQ to Select all Parcels and order by cost
            var pacelOderByCost =
                from p in parcels                       //Set range from list parcels
                orderby p.CalcCost() ascending          //Order by the cost
                select p;                               //Select to show all

            //Display result from LINQ pacelOderByCost
            Console.WriteLine("Select all Parcels and order by cost (ascending):");
            Console.WriteLine("====================");
            foreach (var a in pacelOderByCost)
            {
                Console.WriteLine(a);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Select all Parcels and order by cost END");
            Pause();

            // Holds results of LINQ to select all Parcels and order by Parcel type and then cost
            var pacelOderByParceltype =
                from p in parcels                                                       //Set range from list parcels
                orderby p.GetType().ToString() ascending, p.CalcCost() descending       //Order by the type then by Cost
                select p;                                                               //Select to show all

            //Display result from LINQ pacelOderByParceltype
            Console.WriteLine("Select all Parcels and order by Parcel type (ascending) and then cost (descending):");
            Console.WriteLine("====================");
            foreach (var a in pacelOderByParceltype)
            {
                Console.WriteLine(a);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Select all Parcels and order by Parcel type and then cost END");
            Pause();

            // Holds results of LINQ to Select all AirPackage objects that are heavy and order by weight
            var airPackageIsHeavyOrderByWeight =
                from p in parcels                               //Set range from list parcels
                let ap = p as AirPackage                        //assign ap to store AirPackage by down casting and if not AirPackage then Null
                where ap != null && ap.IsHeavy() == true        //Filter out the not null and filters to show the IsHeavy 
                orderby ap.Weight descending                    //Order AirPackage by Wieght
                select ap;                                      //Show all AirPackages
            
            //Display result from LINQ airPackageIsHeavyOrderByWeight
            Console.WriteLine("Select all AirPackage objects that are heavy and order by weight (descending):");
            Console.WriteLine("====================");
            foreach (var a in airPackageIsHeavyOrderByWeight)
            {
                Console.WriteLine(a);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Select all AirPackage objects that are heavy and order by weight END");
            Pause();

       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}