using FerPROJ;
using PointOfSaleBL;
using PointOfSaleDB;
using PointOfSaleReports;
using PointOfSaleSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleForms
{
    public partial class ManageNewSales : ManageFormSettings
    {
        SalesDTO MyDTO = new SalesDTO();
        public ManageNewSales()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            salesDTOBindingSource.DataSource = MyDTO;
            salesDetailsDTOBindingSource.DataSource = MyDTO.PurchaseItem;
        }
        private void SetReset()
        {
            salesDTOBindingSource.ResetBindings(false);
            salesDetailsDTOBindingSource.ResetBindings(false);
        }
        private void ClearTransaction()
        {
            MyDTO = new SalesDTO();
            salesDetailsDTOBindingSource.DataSource = MyDTO.PurchaseItem;
            salesDTOBindingSource.DataSource = MyDTO;
        }
        protected override void InitializeKeyboardShortcuts()
        {
            keyboardShortcuts[Keys.F1] = NewTransaction;
            keyboardShortcuts[Keys.F2] = RemoveItem;
            keyboardShortcuts[Keys.F3] = TenderAmount;
            keyboardShortcuts[Keys.F4] = PostTransaction;
        }
        private void NewTransaction()
        {
            if(new FormLayer.ListForms().ListOfProducts(true, out string pCode))
            {
                using (ManageSalesQty frm = new ManageSalesQty())
                {
                    frm.Manage_IdTrack = pCode;
                    frm.CurrentFormMode = FormMode.Add;
                    frm.ShowDialog();
                    if (frm.CurrentFormResult)
                    {
                        MyDTO.AddItem(frm.MyDTO);
                    }
                }
            }
            SetReset();
        }
        private void RemoveItem()
        {
            var selectedItem = CustomDGV.GetItemDTO<SalesDetailsDTO>(salesDetailsDTOCustomDataGridView);
            MyDTO.RemoveItem(selectedItem);
            SetReset();
        }
        private void TenderAmount()
        {
            using (var frm = new ManageTenderAmount())
            {
                frm.ShowDialog();
                if (frm.CurrentFormResult)
                {
                    MyDTO.TenderAmount = frm.tenderedAmount;
                }
                SetReset();
            }
        }
        private void PostTransaction()
        {
            if(new SalesDB().SaveData(MyDTO))
            {
                if(CustomShowMessage.AskMessageBox("Do you want to print transaction?", "Confirmation"))
                {
                    new TReports().PreviewReport(TReports.TReportsList.SalesReceipt, MyDTO.TransNo);
                }
                ClearTransaction();
            }
            return;
        }
    }
}
