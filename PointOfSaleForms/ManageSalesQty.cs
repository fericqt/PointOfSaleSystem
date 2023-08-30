using FerPROJ;
using PointOfSaleBL;
using PointOfSaleDB;
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
    public partial class ManageSalesQty : ManageFormSettings
    {
        public SalesDetailsDTO MyDTO = new SalesDetailsDTO();
        public ManageSalesQty()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            
            switch (CurrentFormMode)
            {
                case FormMode.Add:
                    customTextBox1.Focus();
                    var tblp = new ProductDB().GetById(Manage_IdTrack);
                    MyDTO.RemainingQty = tblp.RemainingQty;
                    MyDTO.ProductCode = tblp.ProductCode;
                    MyDTO.ProductDescription = tblp.ProductDescription;
                    MyDTO.Price = tblp.PriceUsed;
                    break;
                case FormMode.Update:
                    break;
            }
            salesDetailsDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            if (MyDTO.Validation())
            {
                return true;
            }
            CustomShowMessage.WarningMessageBox(MyDTO.Error, "Warning");
            return false;
        }
    }
}
