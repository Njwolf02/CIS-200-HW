// Program 3
// CIS 200
// Summer 2015
// Due: 6/22/2015
// By: Nick Wolf

// File: ChooseAddressForm.cs
// This class creates the Choose Address dialog box form GUI. It performs validation
// and have combo box that select which to be edit.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog3
{
    public partial class ChooseAddressForm : Form
    {
        List<Address> addressList; //used to import the addressList in the constructor
        ErrorProvider CboEP = new ErrorProvider(); //Errorprovidor to validate the listbox
        public int chosenIndex; //int to store the currentend selected index in the combo box

        // Precondition:  List addresses is populated with the available
        //                addresses (at least 1) to choose from
        // Postcondition: The form's GUI is prepared for display.
        public ChooseAddressForm(List<Address> addresses)
        {
            addressList = addresses; //the list of addresses are imported
            InitializeComponent();

            foreach (Address a in addressList)
            {
                AddressEditCbo.Items.Add(a.Name.ToString());
            }
        }

        //Comment provided by Dr. Wright
        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //Comment provided by Dr. Wright
        // Precondition:  Focus shifting from one of the address combo boxes
        //                sender is ComboBox
        // Postcondition: If no address selected, focus remains and error provider
        //                highlights the field
        private void AddressEditCbo_Validating(object sender, CancelEventArgs e)
        {
            if (AddressEditCbo.SelectedIndex == -1)
            {
                e.Cancel = true;
                CboEP.SetError(AddressEditCbo, "Please select an address to edit");
            }
        }

        //Comment provided by Dr. Wright
        // Precondition:  Validating of sender not cancelled, so data OK
        //                sender is Control
        // Postcondition: Error provider cleared and focus allowed to change
        private void AddressEditCbo_Validated(object sender, EventArgs e)
        {
            CboEP.SetError(AddressEditCbo, "");
        }

        //Comment provided by Dr. Wright
        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        //Precondition: The user selects an item in the combo box
        //Postcondition: The int variable from above changes value
        private void AddressEditCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenIndex = AddressEditCbo.SelectedIndex;
        }

            

    }
}
