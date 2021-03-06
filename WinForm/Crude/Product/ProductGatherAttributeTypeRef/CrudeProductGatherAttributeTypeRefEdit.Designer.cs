﻿namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductGatherAttributeType;
        
        private System.Windows.Forms.Label labelProductGatherAttributeType;
        
        private System.Windows.Forms.TextBox textBoxProductGatherAttributeTypeName;
        
        private System.Windows.Forms.Label labelProductGatherAttributeTypeName;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
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
            this.labelProductGatherAttributeType = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeType = new System.Windows.Forms.TextBox();
            this.labelProductGatherAttributeTypeName = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductGatherAttributeType
            //
            this.labelProductGatherAttributeType.AutoSize = true;
            this.labelProductGatherAttributeType.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherAttributeType.Name = "labelProductGatherAttributeType";
            this.labelProductGatherAttributeType.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeType.TabIndex = 2;
            this.labelProductGatherAttributeType.Text = "Product Gather Attribute Type:";
            //
            //textBoxProductGatherAttributeType
            //
            this.textBoxProductGatherAttributeType.Location = new System.Drawing.Point(238, 13);
            this.textBoxProductGatherAttributeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherAttributeType.Name = "textBoxProductGatherAttributeType";
            this.textBoxProductGatherAttributeType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeType.TabIndex = 3;
            //
            // labelProductGatherAttributeTypeName
            //
            this.labelProductGatherAttributeTypeName.AutoSize = true;
            this.labelProductGatherAttributeTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherAttributeTypeName.Name = "labelProductGatherAttributeTypeName";
            this.labelProductGatherAttributeTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeTypeName.TabIndex = 4;
            this.labelProductGatherAttributeTypeName.Text = "Product Gather Attribute Type Name:";
            //
            //textBoxProductGatherAttributeTypeName
            //
            this.textBoxProductGatherAttributeTypeName.Location = new System.Drawing.Point(238, 36);
            this.textBoxProductGatherAttributeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherAttributeTypeName.Name = "textBoxProductGatherAttributeTypeName";
            this.textBoxProductGatherAttributeTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeTypeName.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(296, 82);
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
            this.ClientSize = new System.Drawing.Size(500, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductGatherAttributeTypeRefEdit";
            this.Text = "Product Gather Attribute Type Ref Edit";
            this.Controls.Add(this.labelProductGatherAttributeType);
            this.Controls.Add(this.textBoxProductGatherAttributeType);
            this.Controls.Add(this.labelProductGatherAttributeTypeName);
            this.Controls.Add(this.textBoxProductGatherAttributeTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
