using FerPROJ;
using FerPROJ.FerCLASS;
using PointOfSaleBL;
using PointOfSaleDB;
using PointOfSaleReports;
using PointOfSaleSettings;
using System;
using System.Collections.Generic;
using System.Text;
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
            keyboardShortcuts[Keys.F5] = AddCustomerName;
            keyboardShortcuts[Keys.F6] = ScanBarcode;
            keyboardShortcuts[Keys.F7] = ExportToExcel;
            keyboardShortcuts[Keys.F8] = ImportFromExcel;
        }
        private void ImportFromExcel()
        {
            var sb = new StringBuilder();
            var itemToAdd = new List<SalesDetailsDTO>();
            //
            if (CustomGet.ImportFromExcel(out itemToAdd))
            {
                foreach(var item in itemToAdd)
                {
                    if (new ProductDB().GetById(item.ProductCode) == null)
                    {
                        sb.AppendLine($"The ProductCode {item.ProductCode} is not found!");
                    }
                }

                if (sb.Length <= 0)
                {
                    if (MyDTO.AddItemRange(itemToAdd))
                    {
                        CustomShowMessage.InfoMessageBox("Data Imported Successfully.", "Info");
                        SetReset();
                    }
                }
                else
                {
                    CustomShowMessage.WarningMessageBox(sb.ToString(), "Warning");
                }

            }
        }
        private void ExportToExcel()
        {
            CustomGet.ExportToExcel(MyDTO.PurchaseItem, "Sales Details");
        }
        private void ScanBarcode()
        {

            if (new FormLayer.ManageForm().ManageBarcodeScanner(out string pCode, FormMode.Add))
            {

                using (ManageSalesQty frm = new ManageSalesQty())
                {
                    frm.Manage_IdTrack = pCode;
                    frm.CurrentFormMode = FormMode.Add;
                    frm.ShowDialog();
                    if (frm.CurrentFormResult)
                    {
                        MyDTO.AddItem(frm.MyDTO);
                        SetReset();
                        ScanBarcode();
                    }
                }
            }

        }
        private void NewTransaction()
        {
            if (new FormLayer.ListForms().ListOfProducts(true, out string pCode))
            {
                if (pCode != null)
                {
                    using (ManageSalesQty frm = new ManageSalesQty())
                    {
                        frm.Manage_IdTrack = pCode;
                        frm.CurrentFormMode = FormMode.Add;
                        frm.ShowDialog();
                        if (frm.CurrentFormResult)
                        {
                            MyDTO.AddItem(frm.MyDTO);
                            SetReset();
                            NewTransaction();
                        }
                    }
                }
            }
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
            if (new SalesDB().SaveData(MyDTO))
            {
                if (CustomShowMessage.AskMessageBox("Do you want to print transaction?", "Confirmation"))
                {
                    new TReports().PreviewReport(TReports.TReportsList.SalesReceipt, MyDTO.TransNo);
                }
                ClearTransaction();
            }
            return;
        }
        private void AddCustomerName()
        {
            using (var frm = new ManageAddCustomer())
            {
                frm.ShowDialog();
                if (frm.CurrentFormResult)
                {
                    MyDTO.CustomerName = frm.customerName;
                }
            }
            SetReset();
        }


    }
}
