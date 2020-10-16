﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:19 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductCategoryDocumentationEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductCategoryDocumentationContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductCategoryDocumentationEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                Text += " - Not Savable (ProductCategory,User Missing)";
                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProductCategoryDocumentationTypeAndDocumentation(string productCategoryDocumentationTypeRcd, string documentation) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : string.Empty;
                _contract.Documentation = documentation;
                textBoxDocumentation.Text = _contract.Documentation;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProductCategory(System.Guid productCategoryId) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryId = productCategoryId;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryDocumentationContract();
                _isNew = true;
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRcd;
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : string.Empty;
                _contract.ProductCategoryId = productCategoryId;
                _contract.Documentation = documentation;
                textBoxDocumentation.Text = _contract.Documentation;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productCategoryDocumentationId) {
            CrudeProductCategoryDocumentationServiceClient service = new CrudeProductCategoryDocumentationServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
                productCategoryDocumentationTypeRefCombo.Text = _contract.ProductCategoryDocumentationTypeRcd != null ? _contract.ProductCategoryDocumentationTypeRcd : string.Empty;
                textBoxDocumentation.Text = _contract.Documentation;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                service.Close();
            }
        }

        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductCategoryDocumentationServiceClient service = new CrudeProductCategoryDocumentationServiceClient();
            try {
                _contract.ProductCategoryDocumentationTypeRcd = productCategoryDocumentationTypeRefCombo.Text;
                _contract.Documentation = textBoxDocumentation.Text;

                if (_isNew) {
                    service.Insert(_contract);
                } else {
                    service.Update(_contract);
                }
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
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
