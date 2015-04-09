namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemSettingRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private SystemSettingRefCombo systemSettingRefCombo;
        
        private System.Windows.Forms.Label labelSystemSettingRefCombo;
        
        private System.Windows.Forms.TextBox textBoxSystemSettingName;
        
        private System.Windows.Forms.Label labelSystemSettingName;
        
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
            this.labelSystemSettingRefCombo = new System.Windows.Forms.Label();
            this.systemSettingRefCombo = new SystemSettingRefCombo();
            this.labelSystemSettingName = new System.Windows.Forms.Label();
            this.textBoxSystemSettingName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelSystemSettingRefCombo
            //
            this.labelSystemSettingRefCombo.AutoSize = true;
            this.labelSystemSettingRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelSystemSettingRefCombo.Name = "labelSystemSettingRefCombo";
            this.labelSystemSettingRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelSystemSettingRefCombo.TabIndex = 2;
            this.labelSystemSettingRefCombo.Text = "System Setting:";
            //
            //systemSettingRefCombo
            //
            this.systemSettingRefCombo.Location = new System.Drawing.Point(140, 13);
            this.systemSettingRefCombo.Name = "systemSettingRefCombo";
            this.systemSettingRefCombo.Size = new System.Drawing.Size(250, 20);
            this.systemSettingRefCombo.TabIndex = 3;
            //
            // labelSystemSettingName
            //
            this.labelSystemSettingName.AutoSize = true;
            this.labelSystemSettingName.Location = new System.Drawing.Point(11, 36);
            this.labelSystemSettingName.Name = "labelSystemSettingName";
            this.labelSystemSettingName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemSettingName.TabIndex = 4;
            this.labelSystemSettingName.Text = "System Setting Name:";
            //
            //textBoxSystemSettingName
            //
            this.textBoxSystemSettingName.Location = new System.Drawing.Point(140, 36);
            this.textBoxSystemSettingName.Name = "textBoxSystemSettingName";
            this.textBoxSystemSettingName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemSettingName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(140, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 105);
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
            this.ClientSize = new System.Drawing.Size(412, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeSystemSettingRefEdit";
            this.Text = "System Setting Ref Edit";
            this.Controls.Add(this.labelSystemSettingRefCombo);
            this.Controls.Add(this.systemSettingRefCombo);
            this.Controls.Add(this.labelSystemSettingName);
            this.Controls.Add(this.textBoxSystemSettingName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
