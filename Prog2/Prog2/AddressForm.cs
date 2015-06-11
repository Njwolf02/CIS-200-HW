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
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProviderName.SetError(txtName, "Error");
                txtName.SelectAll();
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "Error");
            errorProviderName.Clear();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAddressOne.Text))
            {
                e.Cancel = true;
                errorProviderAddressOne.SetError(txtAddressOne, "Error");
                txtAddressOne.SelectAll();
            }   
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errorProviderAddressOne.SetError(txtAddressOne, "Error");
            errorProviderAddressOne.Clear();
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCity.Text))
            {
                e.Cancel = true;
                errorProviderCity.SetError(txtCity, "Error");
                txtCity.SelectAll();
            }
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            errorProviderCity.SetError(txtCity, "Error");
            errorProviderCity.Clear();
        }

        private void cbState_Validating(object sender, CancelEventArgs e)
        {
            if (cbState.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProviderState.SetError(cbState,"Error");
                cbState.Focus();
            }
        }

        private void cbState_Validated(object sender, EventArgs e)
        {
            errorProviderState.SetError(cbState, "Error");
            errorProviderState.Clear();
        }

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

        private void txtZip_Validated(object sender, EventArgs e)
        {
            errorProviderZipCode.SetError(txtZip, "");
            errorProviderState.Clear();
        }



    }
}
