using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class testProgram
    {
        static void Main(string[] args)
        {
            //create derived class objects for Address
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 2", "Louisville", "KY", 40202);
            Address a2 = new Address("Nick Wolf", "Awesome St.", "Not so Awesome St.", "Louisville", "KY", 40205);
            Address a3 = new Address("Cookie Monster", "Sesame Street", "The Moon", "Boston", "MA", 72124);
            Address a4 = new Address("Big Bird", "The nest", "Sesame Street 2", "Boston", "MA", 12345);

            //create derived class objects for Address
            Letter letter1 = new Letter(a1, a2, 20);
            Letter letter2 = new Letter(a3, a4, 10);
            Letter letter3 = new Letter(a4, a3, 100);

            List<Parcel> letters = new List<Parcel>();

            letters.Add(letter1);

            foreach ( Letter l in letters)
            {
                Console.WriteLine(l);
            }
        }
    }
}