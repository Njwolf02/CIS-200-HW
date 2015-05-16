using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*  Name: Nick Wolf
 *  Lab #: 1
 *  Due Date: May 18
 *  Descriptions: This is a console base program that does awesome things with LINQ that query agaist the array invoices 
 *                with things like filters using where cause and sorting using the orderby and then deplays the results 
 *                through a foreach on the query stored on in a variable.
*/

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
            Console.WriteLine("\nPart a)Invoices when sorted by part description");

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
            Console.WriteLine("\nPart b) Invoices when sorted by price");

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
            Console.WriteLine("\nPart c)Invoices when sorted by Quantity and select the Part Description and Quantity");

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
            Console.WriteLine("\nPart d) Calculated the invoices value and sort it by the total, only selected the Part Description and Invoice Total");

            // attempt to display the results of the above LINQ query
            if (calInvoiceTotal.Any())
                foreach (var item in calInvoiceTotal)
                    Console.WriteLine(item);
            else
                Console.WriteLine("not found");


            //e) Using the results of the LINQ query in Part d, select the InvoiceTotals in the range $200 to $500."
            var filerInvoiceTotals =
                from i in calInvoiceTotal
                where i.InvoiceTotal >= 200M && i.InvoiceTotal <= 500M
                select i.InvoiceTotal;

            //header
            Console.WriteLine(string.Format(
                "\nPart e) Calculated the invoices value and sort it by the total, only selected the Part Description, Invoice Total in the range {0:C}-{1:C} per month:",
                200, 500));

            // attempt to display the results of the above LINQ query
            if (filerInvoiceTotals.Any())
                foreach (var item in filerInvoiceTotals)
                    Console.WriteLine(item);
            else
                Console.WriteLine("not found");
        }
    }
}
