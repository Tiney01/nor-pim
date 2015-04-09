using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeEdit : Form {
        
        private CrudeProductExposeContract _contract;
        
        private Boolean isNew;
        
        private Guid _productExposeSetId;
        
        private Guid _userId;
        
        public CrudeProductExposeEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductExposeContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productExposeSetId, Guid userId) {
            _contract = new CrudeProductExposeContract();
            isNew = true;
            _productExposeSetId = productExposeSetId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productExposeId) {
            var service = new CrudeProductExposeService();
            isNew = false;
            try {
                _contract = service.FetchByProductExposeId(productExposeId);
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductExposeService service = new CrudeProductExposeService();
            try {
                _contract.ProductExposeSetId = _productExposeSetId;
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
                if (isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
