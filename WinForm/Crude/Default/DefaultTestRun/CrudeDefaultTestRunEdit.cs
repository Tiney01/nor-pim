﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:49 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial class CrudeDefaultTestRunEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultTestRunContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultTestRunEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultTestRunContract();
                _isNew = true;
                this.Text += " - Not Savable (DefaultTest,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultTestRunContract();
                _isNew = true;
                _contract.DefaultTestId = defaultTestId;
                _contract.DefaultTestRunResultRcd = defaultTestRunResultRcd;
                defaultTestRunResultRefCombo.Text = _contract.DefaultTestRunResultRcd != null ? _contract.DefaultTestRunResultRcd : String.Empty;
                _contract.Result = result;
                textBoxResult.Text = _contract.Result;
                _contract.StartDateTime = startDateTime;
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                _contract.EndDateTime = endDateTime;
                dateTimePickerEndDateTime.Value = _contract.EndDateTime != DateTime.MinValue ? _contract.EndDateTime : dateTimePickerEndDateTime.MinDate;
                dateTimePickerEndDateTime.Checked = _contract.EndDateTime != DateTime.MinValue;
                _contract.ElapsedMilliseconds = elapsedMilliseconds;
                maskedTextBoxElapsedMilliseconds.Text = _contract.ElapsedMilliseconds.ToString();
                _contract.UserId = userId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid defaultTestRunId) {
            var service = new CrudeDefaultTestRunServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultTestRunId(defaultTestRunId);
                defaultTestRunResultRefCombo.Text = _contract.DefaultTestRunResultRcd != null ? _contract.DefaultTestRunResultRcd : String.Empty;
                textBoxResult.Text = _contract.Result;
                dateTimePickerStartDateTime.Value = _contract.StartDateTime != DateTime.MinValue ? _contract.StartDateTime : dateTimePickerStartDateTime.MinDate;
                dateTimePickerStartDateTime.Checked = _contract.StartDateTime != DateTime.MinValue;
                dateTimePickerEndDateTime.Value = _contract.EndDateTime != DateTime.MinValue ? _contract.EndDateTime : dateTimePickerEndDateTime.MinDate;
                dateTimePickerEndDateTime.Checked = _contract.EndDateTime != DateTime.MinValue;
                maskedTextBoxElapsedMilliseconds.Text = _contract.ElapsedMilliseconds.ToString();
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

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
            var service = new CrudeDefaultTestRunServiceClient();
            try {
                _contract.DefaultTestRunResultRcd = defaultTestRunResultRefCombo.Text;
                _contract.Result = textBoxResult.Text;
                _contract.StartDateTime = dateTimePickerStartDateTime.Checked ? Convert.ToDateTime(dateTimePickerStartDateTime.Value): DateTime.MinValue;
                _contract.EndDateTime = dateTimePickerEndDateTime.Checked ? Convert.ToDateTime(dateTimePickerEndDateTime.Value): DateTime.MinValue;
                _contract.ElapsedMilliseconds = maskedTextBoxElapsedMilliseconds.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxElapsedMilliseconds.Text);
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

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
