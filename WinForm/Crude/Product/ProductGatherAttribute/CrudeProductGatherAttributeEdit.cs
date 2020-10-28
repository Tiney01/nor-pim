﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:05:20 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductGatherAttributeEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductGatherAttributeContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherAttributeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductGatherKey,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductGatherAttributeType(string productGatherAttributeTypeRcd) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByProductGatherKey(System.Guid productGatherKeyId) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductGatherKeyId = productGatherKeyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _contract = new CrudeProductGatherAttributeContract();
                _isNew = true;
                _contract.ProductGatherAttributeValue = productGatherAttributeValue;
                textBoxProductGatherAttributeValue.Text = _contract.ProductGatherAttributeValue;
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRcd;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;
                _contract.ProductGatherKeyId = productGatherKeyId;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productGatherAttributeId) {
            var service = new CrudeProductGatherAttributeServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductGatherAttributeId(productGatherAttributeId);
                textBoxProductGatherAttributeValue.Text = _contract.ProductGatherAttributeValue;
                productGatherAttributeTypeRefCombo.Text = _contract.ProductGatherAttributeTypeRcd != null ? _contract.ProductGatherAttributeTypeRcd : String.Empty;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductGatherAttributeServiceClient();
            try {
                _contract.ProductGatherAttributeValue = textBoxProductGatherAttributeValue.Text;
                _contract.ProductGatherAttributeTypeRcd = productGatherAttributeTypeRefCombo.Text;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
