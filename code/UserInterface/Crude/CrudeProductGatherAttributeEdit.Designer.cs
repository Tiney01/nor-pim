namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherAttributeEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductGatherAttributeValue;
        
        private System.Windows.Forms.Label labelProductGatherAttributeValue;
        
        private ProductGatherAttributeTypeRefCombo productGatherAttributeTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductGatherAttributeTypeRefCombo;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelProductGatherAttributeValue = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeValue = new System.Windows.Forms.TextBox();
            this.labelProductGatherAttributeTypeRefCombo = new System.Windows.Forms.Label();
            this.productGatherAttributeTypeRefCombo = new ProductGatherAttributeTypeRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductGatherAttributeValue
            //
            this.labelProductGatherAttributeValue.AutoSize = true;
            this.labelProductGatherAttributeValue.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherAttributeValue.Name = "labelProductGatherAttributeValue";
            this.labelProductGatherAttributeValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeValue.TabIndex = 2;
            this.labelProductGatherAttributeValue.Text = "Product Gather Attribute Value:";
            //
            //textBoxProductGatherAttributeValue
            //
            this.textBoxProductGatherAttributeValue.Location = new System.Drawing.Point(210, 13);
            this.textBoxProductGatherAttributeValue.Name = "textBoxProductGatherAttributeValue";
            this.textBoxProductGatherAttributeValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeValue.TabIndex = 3;
            //
            // labelProductGatherAttributeTypeRefCombo
            //
            this.labelProductGatherAttributeTypeRefCombo.AutoSize = true;
            this.labelProductGatherAttributeTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherAttributeTypeRefCombo.Name = "labelProductGatherAttributeTypeRefCombo";
            this.labelProductGatherAttributeTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeTypeRefCombo.TabIndex = 4;
            this.labelProductGatherAttributeTypeRefCombo.Text = "Product Gather Attribute Type:";
            //
            //productGatherAttributeTypeRefCombo
            //
            this.productGatherAttributeTypeRefCombo.Location = new System.Drawing.Point(210, 36);
            this.productGatherAttributeTypeRefCombo.Name = "productGatherAttributeTypeRefCombo";
            this.productGatherAttributeTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productGatherAttributeTypeRefCombo.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(210, 59);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 105);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(268, 105);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductGatherAttributeEdit";
            this.Text = "Product Gather Attribute Edit";
            this.Controls.Add(this.labelProductGatherAttributeValue);
            this.Controls.Add(this.textBoxProductGatherAttributeValue);
            this.Controls.Add(this.labelProductGatherAttributeTypeRefCombo);
            this.Controls.Add(this.productGatherAttributeTypeRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
