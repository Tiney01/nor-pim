﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:25:09 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateComboStyle1
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this ComboBox UserControl class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class ProductExposeSetTypeRefCombo : UserControl {

        // Constructs the control with an empty ComboBox
        public ProductExposeSetTypeRefCombo() {
            InitializeComponent();
        }

        // get or sets the current combobox row
        public override string Text {
            get {
                string selectedValue = string.Empty;
                try {
                    selectedValue = cboRef.SelectedValue.ToString();
                } catch { }
                return selectedValue;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value; ;
            }
        }

        // event for when a new item is selected in the ComboBox
        public event EventHandler Picked;

        // populates the ComboBox with all rows from the SOAP service
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }

        // trigger Picked event when selected row in the ComboBox changes
        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboRef.SelectedValue != null && Picked != null) {
                Picked(new object(), new EventArgs());
            }
        }

        // fetch all rows from the SOAP layer and populate the ComboBox with it
        public void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeProductExposeSetTypeRefServiceClient productExposeSetTypeRef = null;

                try {
                    productExposeSetTypeRef = new CrudeProductExposeSetTypeRefServiceClient();
                    List<CrudeProductExposeSetTypeRefContract> contracts = productExposeSetTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "ProductExposeSetTypeName";
                    cboRef.ValueMember = "ProductExposeSetTypeRcd";
                } catch (Exception ex) {
                    if (ex != null) { }
                } finally {
                    if (productExposeSetTypeRef != null) {
                        productExposeSetTypeRef.Close();
                    }
                }
            }
        }
    }
}
