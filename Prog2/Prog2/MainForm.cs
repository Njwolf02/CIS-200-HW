/*
 *Program 2
 *CIS 200-10
 *Due: 6/11/2015
 *By: Nick Wolf
 *
 *File: MainForm.cs
 *This is the main form to display all the addresses and parcels, it also have a menu bar
 *that can lead to other forms. Adds items from AddressForm and letterForm.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class MainForm : Form
    {
        //Dr. Wright Provided test data
        // Test Data - Magic Numbers OK
        Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
            "Louisville", "KY", 40202); // Test Address 1
        Address a2 = new Address("Jane Doe", "987 Main St.", "",
            "Beverly Hills", "CA", 90210); // Test Address 2
        Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
            "El Paso", "TX", 79901); // Test Address 3
        Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
            "Portland", "ME", 04101); // Test Address 4
        Address a5 = new Address("John Doe", "111 Market St.", "",
            "Jeffersonville", "IN", 47130); // Test Address 5
        Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
            "Los Angeles", "CA", 90212); // Test Address 6
        Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
            "Bethesda", "MD", 20810); // Test Address 7
        Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
            "Bloodsucker City", "TN", 37210); // Test Address 8

        public MainForm()
        {
            InitializeComponent();

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a4, 4.25M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);     // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, // Next Day test object
                5.25, 5.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, // Next Day test object
                15.5, 5.00M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5,   // Two Day test object
                75.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0,  // Two Day test object
                5.5, TwoDayAirPackage.Delivery.Saver);

            parcels.Add(letter1); // Populate parcel list
            parcels.Add(letter2);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);
            Addresseslist.Add(a1); //Populate Address List
            Addresseslist.Add(a2);
            Addresseslist.Add(a3);
            Addresseslist.Add(a4);
            Addresseslist.Add(a5);
            Addresseslist.Add(a6);
            Addresseslist.Add(a7);
            Addresseslist.Add(a8);
        }

        List<Address> Addresseslist = new List<Address>();    // List of test address
        
        List<Parcel> parcels = new List<Parcel>();            // List of test parcels

        //Method calculateTotalCost calculate the total cost of all Parcels in list.
        private decimal calculateTotalCost
        {
            //Precondition: parcel list must have data
            //Postcondition: Return cost of all parcels
            get
            {
                //Used LINQ because LINQ is awesome
                var GetTotalCost =
                    from p in parcels
                     select p.CalcCost();
                //.SUM() total LINQ Query
                return GetTotalCost.Sum();
            }

        }

        //Precondition: The about menu button must be click
        //Postcondition: A Message Box appear
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Nick Wolf" + Environment.NewLine + "Class: CIS 200-10" + Environment.NewLine + "Assignment: Program 2" + Environment.NewLine + "Due Date: 6/11/2015");
        }

        //Precondition: The exit menu button must be click
        //Postcondition: the program closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Precondition: The menu button list Parcels must be click
        //Postcondition: Display list of parcels into textbox
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Clear();
            foreach (Parcel parcel in parcels)
            {
                MainTextBox.AppendText("-----------------------");
                MainTextBox.AppendText(Environment.NewLine);
                MainTextBox.AppendText(parcel.ToString());
                MainTextBox.AppendText(Environment.NewLine);
            }

            MainTextBox.AppendText(Environment.NewLine);
            MainTextBox.AppendText("Total Cost: ");
            MainTextBox.AppendText(calculateTotalCost.ToString("C"));
        }

        //Precondition: The menu button list address must be click
        //Postcondition: Display list of addresses into text box
        private void listAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Clear();
            foreach (Address address in Addresseslist)
            {
                MainTextBox.AppendText(Environment.NewLine);
                MainTextBox.AppendText(address.ToString());
                MainTextBox.AppendText(Environment.NewLine);
            }
            
        }

        //Precondition: The Address button is clicked
        //Postcondition: A new Modal of AddressForm Appears
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult addressResult;
            addressResult = addressForm.ShowDialog();

            if (addressResult == DialogResult.OK)
            {
                Address addAddress;
                addAddress = new Address(addressForm.txtInputName, addressForm.txtInputAddressOne,
                    addressForm.txtInputAddressTwo, addressForm.txtInputCity, addressForm.txtInputState,
                    Convert.ToInt32(addressForm.txtInputZip));
                Addresseslist.Add(addAddress);
            }
        }

        //Precondition: The letter button must be click
        //Postcondition: A new modal of LetterForm appears
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(Addresseslist);
            DialogResult letterResult;
            letterResult = letterForm.ShowDialog();

            if (letterResult == DialogResult.OK)
            {
                Letter addletter;
                addletter = new Letter(Addresseslist[letterForm.OriginAddressIndex],
                    Addresseslist[letterForm.DesAddressIndex], letterForm.FixedCost);
                parcels.Add(addletter);
            }
        }
    }
}
