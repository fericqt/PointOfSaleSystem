using FerPROJ;
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
using static FerPROJ.FerFORMS.FrmManageMain;

namespace PointOfSaleForms
{
    public partial class FrmProductList : ListFormSettings
    {
        public FrmProductList()
        {
            InitializeComponent();
        }
        protected override void RefreshData()
        {
            new ProductDB().LoadListAll(productDTOCustomDataGridView);
            CustomDGV.SearchDGV(productDTOCustomDataGridView, SearchTextBox);
        }
        protected override bool AddNewItem()
        {
            return new FormLayer.ManageForm().ManageProduct("", FormMode.Add);
        }
        protected override bool UpdateItem()
        {
            if (CustomDGV.GetRowValue(productDTOCustomDataGridView, ProductCode.Index, out string sout))
            {
                return new FormLayer.ManageForm().ManageProduct(sout, FormMode.Update);
            }
            return false;
        }
        protected override bool GetSelectedData()
        {
            if(CustomDGV.GetRowValue(productDTOCustomDataGridView, ProductCode.Index, out string sout))
            {
                Form_IdTrack = sout;
                return true;
            }
            return false;
        }
    }
}
