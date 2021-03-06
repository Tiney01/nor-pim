﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:47 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeCartProductSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _clientId;
        
        private System.Guid _productId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeCartProductSearch() {
            InitializeComponent();
            InitializeGridCrudeCartProduct();
            this.AcceptButton = buttonCrudeCartProductSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _clientId = clientId;
                _productId = productId;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;

                RefreshCrudeCartProduct();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeCartProductEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProduct.CurrentRow.Cells["CartProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeCartProductAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeCartProduct_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProduct.CurrentRow.Cells["CartProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeCartProductSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeCartProduct();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        public void RefreshCrudeCartProduct() {
            var cartProduct = new CrudeCartProductServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = cartProduct.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            ,textBoxSessionIdentificator.Text
                            ,Guid.Empty
                            ,textBoxState.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeCartProduct.AutoGenerateColumns = false;
                dataGridViewCrudeCartProduct.DataSource = bindingSource;
                dataGridViewCrudeCartProduct.AutoResizeColumns();
                dataGridViewCrudeCartProduct.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                cartProduct.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeCartProduct() {
            try {
                dataGridViewCrudeCartProduct.Columns.Clear();
                dataGridViewCrudeCartProduct.AutoGenerateColumns = false;
                dataGridViewCrudeCartProduct.Columns.Add("SessionIdentificator","Session Identificator");
                dataGridViewCrudeCartProduct.Columns["SessionIdentificator"].DataPropertyName = "SessionIdentificator";
                dataGridViewCrudeCartProduct.Columns.Add("StateRcd","State");
                dataGridViewCrudeCartProduct.Columns["StateRcd"].DataPropertyName = "StateRcd";
                dataGridViewCrudeCartProduct.Columns.Add("Amount","Amount");
                dataGridViewCrudeCartProduct.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeCartProduct.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeCartProduct.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeCartProduct.Columns.Add("CartProductId","Cart Product");
                dataGridViewCrudeCartProduct.Columns["CartProductId"].DataPropertyName = "CartProductId";
                dataGridViewCrudeCartProduct.Columns["CartProductId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ClientId","Client");
                dataGridViewCrudeCartProduct.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeCartProduct.Columns["ClientId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ProductId","Product");
                dataGridViewCrudeCartProduct.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeCartProduct.Columns["ProductId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeCartProduct.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeCartProduct.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("SessionId","Session");
                dataGridViewCrudeCartProduct.Columns["SessionId"].DataPropertyName = "SessionId";
                dataGridViewCrudeCartProduct.Columns["SessionId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("AspId","Asp");
                dataGridViewCrudeCartProduct.Columns["AspId"].DataPropertyName = "AspId";
                dataGridViewCrudeCartProduct.Columns["AspId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ExtensionData", "");
                dataGridViewCrudeCartProduct.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeCartProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeCartProduct.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
