using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Nick Wolf

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

        }
    }
}
