namespace Prog3
{
    partial class ChooseAddressForm
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
            this.lblChooseAddress = new System.Windows.Forms.Label();
            this.AddressEditCbo = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseAddress
            // 
            this.lblChooseAddress.AutoSize = true;
            this.lblChooseAddress.Location = new System.Drawing.Point(12, 22);
            this.lblChooseAddress.Name = "lblChooseAddress";
            this.lblChooseAddress.Size = new System.Drawing.Size(120, 13);
            this.lblChooseAddress.TabIndex = 0;
            this.lblChooseAddress.Text = "Choose Address to Edit:";
            // 
            // AddressEditCbo
            // 
            this.AddressEditCbo.FormattingEnabled = true;
            this.AddressEditCbo.Location = new System.Drawing.Point(15, 38);
            this.AddressEditCbo.Name = "AddressEditCbo";
            this.AddressEditCbo.Size = new System.Drawing.Size(175, 21);
            this.AddressEditCbo.TabIndex = 1;
            this.AddressEditCbo.SelectedIndexChanged += new System.EventHandler(this.AddressEditCbo_SelectedIndexChanged);
            this.AddressEditCbo.Validating += new System.ComponentModel.CancelEventHandler(this.AddressEditCbo_Validating);
            this.AddressEditCbo.Validated += new System.EventHandler(this.AddressEditCbo_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(15, 77);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(115, 77);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // ChooseAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 112);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.AddressEditCbo);
            this.Controls.Add(this.lblChooseAddress);
            this.Name = "ChooseAddressForm";
            this.Text = "Choose Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseAddress;
        private System.Windows.Forms.ComboBox AddressEditCbo;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}