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

        public LetterForm(List<Address> aAddress)
        {
            addressListLetterForm = aAddress;
            InitializeComponent();
            addToCBList();
        }

        private void addToCBList()
        {
            foreach (Address address in addressListLetterForm)
            {
                cbOriginAddress.Items.Add(address);
                cbDesAddress.Items.Add(address);
            }
        }

        public int OriginAddressIndex
        {
            get
            {
                return cbOriginAddress.SelectedIndex;
            }
        }

        public int DesAddressIndex
        {
            get
            {
                return cbDesAddress.SelectedIndex;
            }
        }

        public decimal FixedCost
        {
            get
            {
                return Convert.ToDecimal(txtFixedCost.Text);
            }
            set
            {
                txtFixedCost.Text = value.ToString();
            }
        }

        ErrorProvider errorproviderOriginAddress = new ErrorProvider();//Error provider to validate the first combobox
        ErrorProvider errorproviderDestinationAddress = new ErrorProvider();//Error provider to validate the second combobox
        ErrorProvider errorproviderFixedCost = new ErrorProvider();//Error provider to validate the fixed cost box

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

        

    }
}
