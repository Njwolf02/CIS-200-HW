namespace Prog2
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCancel;
            this.AdrNamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddressOne = new System.Windows.Forms.TextBox();
            this.txtAddressTwo = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(108, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(69, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // AdrNamelbl
            // 
            this.AdrNamelbl.AutoSize = true;
            this.AdrNamelbl.Location = new System.Drawing.Point(33, 9);
            this.AdrNamelbl.Name = "AdrNamelbl";
            this.AdrNamelbl.Size = new System.Drawing.Size(38, 13);
            this.AdrNamelbl.TabIndex = 0;
            this.AdrNamelbl.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // txtAddressOne
            // 
            this.txtAddressOne.Location = new System.Drawing.Point(77, 32);
            this.txtAddressOne.Name = "txtAddressOne";
            this.txtAddressOne.Size = new System.Drawing.Size(100, 20);
            this.txtAddressOne.TabIndex = 6;
            this.txtAddressOne.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            this.txtAddressOne.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // txtAddressTwo
            // 
            this.txtAddressTwo.Location = new System.Drawing.Point(77, 58);
            this.txtAddressTwo.Name = "txtAddressTwo";
            this.txtAddressTwo.Size = new System.Drawing.Size(100, 20);
            this.txtAddressTwo.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(77, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            this.txtCity.Validated += new System.EventHandler(this.txtCity_Validated);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(77, 136);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 9;
            this.txtZip.Validating += new System.ComponentModel.CancelEventHandler(this.txtZip_Validating);
            this.txtZip.Validated += new System.EventHandler(this.txtZip_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(36, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbState
            // 
            this.cbState.AllowDrop = true;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "KY",
            "NY",
            "TX",
            "IN",
            "WA",
            "CA"});
            this.cbState.Location = new System.Drawing.Point(77, 110);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(100, 21);
            this.cbState.TabIndex = 13;
            this.cbState.Validating += new System.ComponentModel.CancelEventHandler(this.cbState_Validating);
            this.cbState.Validated += new System.EventHandler(this.cbState_Validated);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 208);
            this.Controls.Add(this.cbState);
            this.Controls.Add(btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressTwo);
            this.Controls.Add(this.txtAddressOne);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdrNamelbl);
            this.Name = "AddressForm";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdrNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddressOne;
        private System.Windows.Forms.TextBox txtAddressTwo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbState;
    }
}