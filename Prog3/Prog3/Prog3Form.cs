﻿// Program 3
// CIS 200
// Summer 2015
// Due: 6/22/2015
// By: Andrew L. Wright & Nick Wolf

// File: Prog3Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        private List<Address> addressList; // The list of addresses
        private List<Parcel> parcelList;   // The list of parcels
        private IFormatter formattter = new BinaryFormatter(); //Used for outputing the list of addresses
        private FileStream stream; //Used for outputting the list of addresses
        private BinaryFormatter reader = new BinaryFormatter(); //Used for reading address list
        private FileStream input;// Used for reading a list of addresses

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog3Form()
        {
            InitializeComponent();

            addressList = new List<Address>();
            parcelList = new List<Parcel>();

            //Test data have been commented out and entered into Prog3Addresses.dat

            // Test Data - Magic Numbers OK
            //Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
            //    "Louisville", "KY", 40202); // Test Address 1
            //Address a2 = new Address("Jane Doe", "987 Main St.", "",
            //    "Beverly Hills", "CA", 90210); // Test Address 2
            //Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
            //    "El Paso", "TX", 79901); // Test Address 3
            //Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
            //    "Portland", "ME", 04101); // Test Address 4
            //Address a5 = new Address("John Doe", "111 Market St.", "",
            //    "Jeffersonville", "IN", 47130); // Test Address 5
            //Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
            //    "Los Angeles", "CA", 90212); // Test Address 6
            //Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
            //    "Bethesda", "MD", 20810); // Test Address 7
            //Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
            //    "Bloodsucker City", "TN", 37210); // Test Address 8

            //Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            //Letter letter2 = new Letter(a3, a4, 4.25M);                            // Letter test object
            //GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        // Ground test object
            //GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);     // Ground test object
            //NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
            //    85, 7.50M);
            //NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, // Next Day test object
            //    5.25, 5.25M);
            //NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, // Next Day test object
            //    15.5, 5.00M);
            //TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, // Two Day test object
            //    80.5, TwoDayAirPackage.Delivery.Saver);
            //TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5,   // Two Day test object
            //    75.5, TwoDayAirPackage.Delivery.Early);
            //TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0,  // Two Day test object
            //    5.5, TwoDayAirPackage.Delivery.Saver);


            //addressList.Add(a1); // Populate list
            //addressList.Add(a2);
            //addressList.Add(a3);
            //addressList.Add(a4);
            //addressList.Add(a5);
            //addressList.Add(a6);
            //addressList.Add(a7);
            //addressList.Add(a8);

            //parcelList.Add(letter1); // Populate list
            //parcelList.Add(letter2);
            //parcelList.Add(gp1);
            //parcelList.Add(gp2);
            //parcelList.Add(ndap1);
            //parcelList.Add(ndap2);
            //parcelList.Add(ndap3);
            //parcelList.Add(tdap1);
            //parcelList.Add(tdap2);
            //parcelList.Add(tdap3);
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 3{0}By: Andrew L. Wright" + " & "+ "Nick Wolf{0}" +
                "CIS 200{0}Summer 2015", Environment.NewLine), "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    Address newAddress = new Address(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        int.Parse(addressForm.ZipText)); // Use form's properties to create address
                    addressList.Add(newAddress);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String

            result.Append("Addresses:");
            result.Append(Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(Environment.NewLine);

            foreach (Address a in addressList)
            {
                result.Append(a.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog

            if (addressList.Count < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return;
            }

            letterForm = new LetterForm(addressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as addressList
                    Letter newLetter = new Letter(addressList[letterForm.OriginAddressIndex],
                        addressList[letterForm.DestinationAddressIndex],
                        decimal.Parse(letterForm.FixedCostText)); // Letter to be inserted
                    parcelList.Add(newLetter);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs

            result.Append("Parcels:");
            result.Append(Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(Environment.NewLine);

            foreach (Parcel p in parcelList)
            {
                result.Append(p.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
                totalCost += p.CalcCost();
            }

            result.Append("------------------------------");
            result.Append(Environment.NewLine);
            result.Append(String.Format("Total Cost: {0:C}", totalCost));

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        //Precondition: the user actiates the address under the edit tab in menu
        //Postcondition: Dialouge box choose address will appear
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseAddressForm chooseForm = new ChooseAddressForm(addressList);// Send list of addresses
            DialogResult result = chooseForm.ShowDialog(); // The result of showing form as dialog
            int chosenAddressIndex; //used to hold and inherit the index position of the address chosen in chooseForm

            if (result == DialogResult.OK)
            {
                chosenAddressIndex = chooseForm.chosenIndex; //inherit the selected address index
                AddressForm editAdress = new AddressForm(); //Create a new Address form

                //This section below fills in the text boxes for editing with the information from the previously selected address object
                editAdress.Address1 = addressList[chosenAddressIndex].Address1;
                editAdress.Address2 = addressList[chosenAddressIndex].Address2;
                editAdress.AddressName = addressList[chosenAddressIndex].Name;
                editAdress.City = addressList[chosenAddressIndex].City;
                editAdress.State = addressList[chosenAddressIndex].State;
                editAdress.ZipText = addressList[chosenAddressIndex].Zip.ToString();

                DialogResult editResult = editAdress.ShowDialog();//Stores the dialog result from editAddress

                if (editResult == DialogResult.OK)
                {
                    //This section below edits the properties of an existing address objects with any changes the user made in editAddress
                    addressList[chosenAddressIndex].Address1 = editAdress.Address1;
                    addressList[chosenAddressIndex].Address2 = editAdress.Address2;
                    addressList[chosenAddressIndex].Name = editAdress.Name;
                    addressList[chosenAddressIndex].City = editAdress.City;
                    addressList[chosenAddressIndex].State = editAdress.State;
                    addressList[chosenAddressIndex].Zip = Convert.ToInt32(editAdress.ZipText);

                }
            }
        }

        //Precondition: the user activates the save addresses button in the menu
        //Postcondition: the current addresses in the address list are exported to an outside file.
        private void saveAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                filename = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (filename == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        stream = new FileStream(filename, 
                            FileMode.Create, FileAccess.Write);

                        formattter.Serialize(stream, addressList);
                        stream.Close();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Saving file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        //Precondition: The user click on the open addresses button in the menu.
        //Postcondition: The user selected a file and imported data containing a list of Addresses objests.
        private void openAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileOpener = new OpenFileDialog())
            {
                result = fileOpener.ShowDialog();
                fileName = fileOpener.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addressList.Clear();
                    parcelList.Clear();
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    List<Address> inputAddressList = (List<Address>)formattter.Deserialize(input);
                    foreach (Address address in inputAddressList)
                    {
                        addressList.Add(address);
                    }
                }

            }
        }
    }
}