/*
 *Program 2
 *CIS 200-10
 *Due: 6/11/2015
 *By: Nick Wolf
 *
 *File: LetterForm.cs
 *This class create new letter with using a modal dialouge box.
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
    public partial class LetterForm : Form
    {
        List<Address> addressListLetterForm; //used to store the list brought in through the constructor

        //Precondition: None
        //Postcondition: None
        public LetterForm(List<Address> aAddress)
        {
            addressListLetterForm = aAddress;
            InitializeComponent();
            addToCBList();
        }

        //Precondition: None (list created from constructor)
        //Postcondition: Comboboxes cbOriginAddress and cbDesAddress are populated
        private void addToCBList()
        {
            foreach (Address address in addressListLetterForm)
            {
                cbOriginAddress.Items.Add(address.Name);
                cbDesAddress.Items.Add(address.Name);
            }
        }

        //Precondition: Index is selected in combobox cbOriginAddress
        //Postcondition: Returns int of the index selected
        public int OriginAddressIndex
        {
            get
            {
                return cbOriginAddress.SelectedIndex;
            }
        }

        //Precondition: Index is selected in combobox DesAddressIndex
        //Postcondition: Returns int of the index selected
        public int DesAddressIndex
        {
            get
            {
                return cbDesAddress.SelectedIndex;
            }
        }


        public decimal FixedCost
        {
            //Precondition: None
            //Postcondition: None
            get
            {
                return Convert.ToDecimal(txtFixedCost.Text);
            }
            //Precondition: Must be able to convert value
            //Postcondition: Value (fixedCost) is string
            set
            {
                txtFixedCost.Text = Convert.ToString(value);
            }
        }

        ErrorProvider errorproviderOriginAddress = new ErrorProvider();//Error provider to validate the first combobox
        ErrorProvider errorproviderDestinationAddress = new ErrorProvider();//Error provider to validate the second combobox
        ErrorProvider errorproviderFixedCost = new ErrorProvider();//Error provider to validate the fixed cost box

        //Precondition: An attempt to change focus from combobox
        //Postcondition: Combobox is tested for validation
        private void cbOriginAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbOriginAddress.SelectedIndex == cbDesAddress.SelectedIndex)
            {
                e.Cancel = true;
                errorproviderOriginAddress.SetError(cbDesAddress, "The Origin and Destination Addresses cannot match.");
            }
            else if (cbOriginAddress.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorproviderOriginAddress.SetError(cbDesAddress, "Please select Address");
            }
        }

        //Precondition: An index is selected
        //Postcondition: the control is validated and error is gone
        private void cbOriginAddress_Validated(object sender, EventArgs e)
        {
            errorproviderOriginAddress.SetError(cbOriginAddress, "");
            errorproviderOriginAddress.Clear();
        }

        //Precondition: An attempt to change focus from combobox
        //Postcondition: Combobox is tested for validation
        private void cbDesAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbDesAddress.SelectedIndex == cbOriginAddress.SelectedIndex)
            {
                e.Cancel = true;
                errorproviderDestinationAddress.SetError(cbDesAddress, "The Origin and Destination Addresses cannot match.");
            }
            else if (cbDesAddress.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorproviderDestinationAddress.SetError(cbDesAddress, "Please select Address");
            }
        }

        //Precondition: An index is selected
        //Postcondition: the control is validated and error is gone
        private void cbDesAddress_Validated(object sender, EventArgs e)
        {
            errorproviderDestinationAddress.SetError(cbDesAddress, "");
            errorproviderDestinationAddress.Clear();
        }

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void txtFixedCost_Validating(object sender, CancelEventArgs e)
        {
            int fixCost;
            if(!int.TryParse(txtFixedCost.Text, out fixCost) || fixCost < 0)
            {
                e.Cancel = true;
                errorproviderFixedCost.SetError(txtFixedCost, "Please enter a fixed cost greater than 0");
            }
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void txtFixedCost_Validated(object sender, EventArgs e)
        {
            errorproviderDestinationAddress.SetError(cbDesAddress, "");
            errorproviderFixedCost.Clear();
        }

        //Precondition: The OK button must be click
        //Postcondition: All controls are validated
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //Precondition: The cancel button must be click
        //Postcondition: Form closes
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }                                

    }
}
