/*
 *Program 2
 *CIS 200-10
 *Due: 6/11/2015
 *By: Nick Wolf
 *
 *File: AddressForm.cs
 *This class create new Address with using a modal dialouge box.
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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        ErrorProvider errorProviderName = new ErrorProvider(); //Error provider for the Name text box 
        ErrorProvider errorProviderAddressOne = new ErrorProvider();//Error provider for Address One text box
        ErrorProvider errorProviderCity = new ErrorProvider();//Error provider for the City text box
        ErrorProvider errorProviderState = new ErrorProvider();//Error provider for the State text box
        ErrorProvider errorProviderZipCode = new ErrorProvider();//Error provider for the Zipcode text box
        
        public string txtInputName
        {
            //Precondition: None
            //Postcondition: The textbox content returned
            get
            {
                return txtName.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                txtName.Text = value;
            }
        }

        public string txtInputAddressOne
        {
            //Precondition: None
            //Postcondition: The textbox has its content returned
            get
            {
                return txtAddressOne.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                txtAddressOne.Text = value;
            }
        }

        public string txtInputAddressTwo
        {
            //Precondition: None
            //Postcondition: The textbox has its content returned
            get
            {
                return txtAddressTwo.Text;
            }           
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                txtAddressTwo.Text = value;
            }
        }

        public string txtInputCity
        {
            //Precondition: None
            //Postcondition: The textbox has its content returned
            get
            {
                return txtCity.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                txtCity.Text = value;
            }
        }

        public string txtInputState
        {
            //Precondition: None
            //Postcondition: The textbox has its content returned
            get
            {
                return cbState.Text;
            }
        }

        public string txtInputZip
        {
            //Precondition: None
            //Postcondition: The textbox has its content returned
            get
            {
                return txtZip.Text;
            }
            //Precondition: None
            //Postcondition: The textbox value has been set.
            set
            {
                txtZip.Text = value.ToString();
            }
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

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProviderName.SetError(txtName, "Error");
                txtName.SelectAll();
            }
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "Error");
            errorProviderName.Clear();
        }

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAddressOne.Text))
            {
                e.Cancel = true;
                errorProviderAddressOne.SetError(txtAddressOne, "Error");
                txtAddressOne.SelectAll();
            }   
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errorProviderAddressOne.SetError(txtAddressOne, "Error");
            errorProviderAddressOne.Clear();
        }

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCity.Text))
            {
                e.Cancel = true;
                errorProviderCity.SetError(txtCity, "Error");
                txtCity.SelectAll();
            }
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void txtCity_Validated(object sender, EventArgs e)
        {
            errorProviderCity.SetError(txtCity, "Error");
            errorProviderCity.Clear();
        }

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void cbState_Validating(object sender, CancelEventArgs e)
        {
            if (cbState.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderState.SetError(cbState,"Error");
                cbState.Focus();
            }
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void cbState_Validated(object sender, EventArgs e)
        {
            errorProviderState.SetError(cbState, "Error");
            errorProviderState.Clear();
        }

        //Precondition: An attempt to change focus from textbox
        //Postcondition: textbox is tested for validation
        private void txtZip_Validating(object sender, CancelEventArgs e)
        {
            const int MAX_ZIP = 99999;
            int zipCode;
            if (!int.TryParse(txtZip.Text, out zipCode) || zipCode < 0 || zipCode > MAX_ZIP)
            {
                e.Cancel = true;
                errorProviderZipCode.SetError(txtZip, "Error");
                txtZip.SelectAll();
            }
        }

        //Precondition: Something is entered
        //Postcondition: the control is validated and error is gone
        private void txtZip_Validated(object sender, EventArgs e)
        {
            errorProviderZipCode.SetError(txtZip, "");
            errorProviderState.Clear();
        }



    }
}
