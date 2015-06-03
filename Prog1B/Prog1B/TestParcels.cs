// Program 1A
// CIS 200-10
// Summer 2015
// Due: 5/31/2015
// By: Andrew L. Wright

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
                "New York", "New York", 95124);
            Address a6 = new Address("Kermit the Frog", "456 Muppet Lane", "Pond around back",
                "Bird-in-Hand", "Pennsylvania", 62754);
            Address a7 = new Address("Count Von Count", "789 Counting St", "Coffin 3",
                "Chicken", "Alaska", 99991);
            Address a8 = new Address("Cookie Monster", "1011 Cookie St", "Ap1 2",
                "George", "Washingon", 02321);

            Letter letter1 = new Letter(a1, a2, 3.95M);                           // Letter test object
            Letter l2 = new Letter(a3, a6, 4.23M);
            Letter l3 = new Letter(a7, a3, 3);

            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a4, a5, 48, 2, 1, 10);
            GroundPackage gp3 = new GroundPackage(a3, a2, 34, 12, 83, 30);

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a2, 34, 34, 34, 10, 10.1M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a8, a1, 10, 3, 2, 84, .99M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a1, 23.1, 23, 42, 30, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a3, a6, 5, 5.1, 5.2, 5.3, TwoDayAirPackage.Delivery.Saver);

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
            Pause();

            var parcelOrderByDesZip =
                from a in parcels
                select a;

            Console.WriteLine("Select all Parcels and order by destination zip:");
            Console.WriteLine("====================");
            foreach (var a in parcelOrderByDesZip)
            {
                Console.WriteLine(a);
                Console.WriteLine("====================");
            }
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
