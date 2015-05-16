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

            //display all invoices
            Console.WriteLine("Original array:");
            foreach (var item in invoices)
                Console.WriteLine(item);

            //a) Use LINQ to sort the Invoice objects by PartDescription.
            var partDescriptionSorted =
                from i in invoices
                orderby i.PartDescription
                select i;

            //header
            Console.WriteLine("\nInvoices when sorted by part description");

            // attempt to display the results of the above LINQ query
            if (partDescriptionSorted.Any())
                foreach( var item in partDescriptionSorted )
                Console.WriteLine(item); 
            else
                Console.WriteLine("not found");

            
            
            //b) Use LINQ to sort the Invoice objects by Price.
            var priceSort =
                from i in invoices
                orderby i.Price
                select i;
            
            //header
            Console.WriteLine("\nInvoices when sorted by price");

            // attempt to display the results of the above LINQ query
            if (priceSort.Any())
                foreach( var item in priceSort )
                Console.WriteLine(item); 
            else
                Console.WriteLine("not found");

            
            
            //c) Use LINQ to select the PartDescription and Quantity and sort the results by Quantity.
            var sortQuantityandOnlyDescandQuantity =
                from i in invoices
                orderby i.Quantity
                select new { i.PartDescription, i.Quantity };

            //header
            Console.WriteLine("\nInvoices when sorted by Quantity and select the Part Description and Quantity");

            // attempt to display the results of the above LINQ query
            if (sortQuantityandOnlyDescandQuantity.Any())
                foreach (var item in sortQuantityandOnlyDescandQuantity)
                    Console.WriteLine(item);
            else
                Console.WriteLine("not found");



            //d)Use LINQ to select from each Invoice the PartDescription and the value of the Invoice (i.e., Quantity * Price). Name the calculated column InvoiceTotal. Order the results by Invoice value. 
            var calInvoiceTotal =
                from i in invoices
                let InvoiceTotal = i.Price * i.Quantity
                orderby InvoiceTotal descending
                select new { i.PartDescription, InvoiceTotal };

            //header
            Console.WriteLine("\nCalculated the invoices value and sort it by the total, only selected the Part Description, Invoice Total");

            // attempt to display the results of the above LINQ query
            if (calInvoiceTotal.Any())
                foreach (var item in calInvoiceTotal)
                    Console.WriteLine(item);
            else
                Console.WriteLine("not found");


        }
    }
}
