namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSetEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductExposeSetTypeRefCombo productExposeSetTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetName;
        
        private System.Windows.Forms.Label labelProductExposeSetName;
        
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
            this.labelProductExposeSetTypeRefCombo = new System.Windows.Forms.Label();
            this.productExposeSetTypeRefCombo = new ProductExposeSetTypeRefCombo();
            this.labelProductExposeSetName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductExposeSetTypeRefCombo
            //
            this.labelProductExposeSetTypeRefCombo.AutoSize = true;
            this.labelProductExposeSetTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetTypeRefCombo.Name = "labelProductExposeSetTypeRefCombo";
            this.labelProductExposeSetTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeRefCombo.TabIndex = 2;
            this.labelProductExposeSetTypeRefCombo.Text = "Product Expose Set Type:";
            //
            //productExposeSetTypeRefCombo
            //
            this.productExposeSetTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.productExposeSetTypeRefCombo.Name = "productExposeSetTypeRefCombo";
            this.productExposeSetTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productExposeSetTypeRefCombo.TabIndex = 3;
            //
            // labelProductExposeSetName
            //
            this.labelProductExposeSetName.AutoSize = true;
            this.labelProductExposeSetName.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetName.Name = "labelProductExposeSetName";
            this.labelProductExposeSetName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetName.TabIndex = 4;
            this.labelProductExposeSetName.Text = "Product Expose Set Name:";
            //
            //textBoxProductExposeSetName
            //
            this.textBoxProductExposeSetName.Location = new System.Drawing.Point(161, 36);
            this.textBoxProductExposeSetName.Name = "textBoxProductExposeSetName";
            this.textBoxProductExposeSetName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(161, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 105);
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
            this.ClientSize = new System.Drawing.Size(433, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductExposeSetEdit";
            this.Text = "Product Expose Set Edit";
            this.Controls.Add(this.labelProductExposeSetTypeRefCombo);
            this.Controls.Add(this.productExposeSetTypeRefCombo);
            this.Controls.Add(this.labelProductExposeSetName);
            this.Controls.Add(this.textBoxProductExposeSetName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
