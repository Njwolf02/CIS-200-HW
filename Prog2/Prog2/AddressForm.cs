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
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }

        public string txtInputAddressOne
        {
            get
            {
                return txtAddressOne.Text;
            }
            set
            {
                txtAddressOne.Text = value;
            }
        }

        public string txtInputAddressTwo
        {
            get
            {
                return txtAddressTwo.Text;
            }
            set
            {
                txtAddressTwo.Text = value;
            }
        }

        public string txtInputCity
        {
            get
            {
                return txtCity.Text;
            }
            set
            {
                txtCity.Text = value;
            }
        }

        public string txtInputState
        {
            get
            {
                return cbState.Text;
            }
        }

        public string txtInputZip
        {
            get
            {
                return txtZip.Text;
            }
            set
            {
                txtZip.Text = value.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProviderName.SetError(txtName, "Error");
                txtName.SelectAll();
            }

        }

        private void txtBox_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "Error");

        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errorProviderAddressOne.SetError(txtAddressOne, "Error");
        }

        private void txtAdress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddressOne.Text))
            {
                e.Cancel = true;
                errorProviderAddressOne.SetError(txtAddressOne, "Error");
                txtAddressOne.SelectAll();
            }
        }


    }
}
