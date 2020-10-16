﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:18 PM
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
    public partial class CrudeDefaultSystemReferenceTableEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultSystemReferenceTableContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultSystemReferenceTableEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultSystemReferenceTableContract();
                _isNew = true;
                Text += " - Not Savable (DefaultUser Missing)";
                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultSystemReferenceTableContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultSystemReferenceTableContract();
                _isNew = true;
                _contract.DefaultSystemReferenceTableName = defaultSystemReferenceTableName;
                textBoxDefaultSystemReferenceTableName.Text = _contract.DefaultSystemReferenceTableName;
                _contract.DefaultSystemReferenceDisplayName = defaultSystemReferenceDisplayName;
                textBoxDefaultSystemReferenceDisplayName.Text = _contract.DefaultSystemReferenceDisplayName;
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form in edit modus
        public void ShowAsEdit(System.Guid defaultSystemReferenceTableId, System.Guid defaultUserId) {
            CrudeDefaultSystemReferenceTableServiceClient service = new CrudeDefaultSystemReferenceTableServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
                textBoxDefaultSystemReferenceTableName.Text = _contract.DefaultSystemReferenceTableName;
                textBoxDefaultSystemReferenceDisplayName.Text = _contract.DefaultSystemReferenceDisplayName;
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

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
            CrudeDefaultSystemReferenceTableServiceClient service = new CrudeDefaultSystemReferenceTableServiceClient();
            try {
                _contract.DefaultSystemReferenceTableName = textBoxDefaultSystemReferenceTableName.Text;
                _contract.DefaultSystemReferenceDisplayName = textBoxDefaultSystemReferenceDisplayName.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value) : DateTime.MinValue;

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
