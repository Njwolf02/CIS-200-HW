using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Program 0
 * CIS 200-10
 * Due: 5/21/2015
 * By: Nick Wolf
 * 
 * This is a console app that shows a class hierarchy through a package-delivery. 
 * This test the classes Addess, Parcel, and Letter. It place data into the class 
 * address and letters. Then they are place that inside of a list with the object Parcel.
 */
namespace Program0
{
    class testProgram
    {
        static void Main(string[] args)
        {
            //Location fix cost
            const decimal MOON_FC = 200;
            const decimal BOSTON_FC = 10;
            const decimal LOUISVILLE_FC = 8.26M; 

            //create derived class objects for Address
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 2", "Louisville", "KY", 40202);
            Address a2 = new Address("Nick Wolf", "Awesome St.", "Not so Awesome St.", "Louisville", "KY", 40205);
            Address a3 = new Address("Cookie Monster", "Sesame Street", "The Moon", "Boston", "MA", 87534);
            Address a4 = new Address("Big Bird", "The nest", "Sesame Street 2", "Boston", "MA", 12345);

            //create derived class objects for Address
            Letter letter1 = new Letter(a1, a2, LOUISVILLE_FC);
            Letter letter2 = new Letter(a3, a4, BOSTON_FC);
            Letter letter3 = new Letter(a4, a3, MOON_FC);

            // List of Parcel
            List<Parcel> parcel = new List<Parcel>();

            parcel.Add(letter1);
            parcel.Add(letter2);
            parcel.Add(letter3);
            
            //loop writes out Letters using tostring methods to format them.
            foreach ( Letter letter in parcel)
            {
                Console.WriteLine(letter);
            }
        }
    }
}