namespace norpim.UserInterface {
    
    
    public partial class ProductImageTypeRefCombo {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.ComboBox cboRef;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.cboRef = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboRef
            // 
            this.cboRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRef.FormattingEnabled = true;
            this.cboRef.Location = new System.Drawing.Point(0, 0);
            this.cboRef.Name = "cboRef";
            this.cboRef.Size = new System.Drawing.Size(150, 21);
            this.cboRef.Click += new System.EventHandler(this.cboRef_Click);
            this.cboRef.TabIndex = 0;
            // 
            // ProductImageTypeRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboRef);
            this.Name = "ProductImageTypeRef";
            this.Size = new System.Drawing.Size(150, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
