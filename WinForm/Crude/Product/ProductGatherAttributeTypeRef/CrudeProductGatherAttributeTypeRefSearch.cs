﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:20 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
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
    public partial class CrudeProductGatherAttributeTypeRefSearch : Form {

        // the following fields holds initial state for foreign key's
        private System.Guid _userId;

        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherAttributeTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherAttributeTypeRef();
            AcceptButton = buttonCrudeProductGatherAttributeTypeRefSearch;
            CancelButton = buttonClose;
        }

        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductGatherAttributeTypeRef();

                base.Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductGatherAttributeTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                CrudeProductGatherAttributeTypeRefEdit editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsEdit((string)dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value, _userId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows a form for adding more rows
        private void buttonCrudeProductGatherAttributeTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                CrudeProductGatherAttributeTypeRefEdit editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeProductGatherAttributeTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                CrudeProductGatherAttributeTypeRefEdit editForm = new CrudeProductGatherAttributeTypeRefEdit();
                editForm.MdiParent = MdiParent;
                editForm.ShowAsEdit((string)dataGridViewCrudeProductGatherAttributeTypeRef.CurrentRow.Cells["ProductGatherAttributeTypeRcd"].Value, _userId);
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // does a search based on the filter and populates the grid
        private void buttonCrudeProductGatherAttributeTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherAttributeTypeRef();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        // refresh the grid
        public void RefreshCrudeProductGatherAttributeTypeRef() {
            CrudeProductGatherAttributeTypeRefServiceClient productGatherAttributeTypeRef = new CrudeProductGatherAttributeTypeRefServiceClient();

            try {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherAttributeTypeRef.FetchWithFilter(
                             textBoxProductGatherAttributeType.Text
                            , textBoxProductGatherAttributeTypeName.Text
                            , Guid.Empty
                            , DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttributeTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherAttributeTypeRef.Refresh();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                productGatherAttributeTypeRef.Close();
            }
        }

        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductGatherAttributeTypeRef() {
            try {
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Clear();
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeName", "Product Gather Attribute Type Name");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ProductGatherAttributeTypeName"].DataPropertyName = "ProductGatherAttributeTypeName";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ProductGatherAttributeTypeRcd", "Product Gather Attribute Type");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ProductGatherAttributeTypeRcd"].DataPropertyName = "ProductGatherAttributeTypeRcd";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("DateTime", "Date Time");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherAttributeTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherAttributeTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherAttributeTypeRef.AutoResizeColumns();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }
    }
}
