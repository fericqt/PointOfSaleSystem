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
    public partial class FrmProductCategory : ListFormSettings
    {
        public FrmProductCategory()
        {
            InitializeComponent();
        }
        protected override void RefreshData()
        {
            new ProductCategoryDB().LoadListAll(productCategoryDTOCustomDataGridView);
        }
        protected override bool AddNewItem()
        {
            return new FormLayer.ManageForm().ManageProductCategory("", FormMode.Add);
        }
        protected override bool UpdateItem()
        {
            if (CustomDGV.GetRowValue(productCategoryDTOCustomDataGridView, IdTrack.Index, out string sout))
            {
                return new FormLayer.ManageForm().ManageProductCategory(sout, FormMode.Update);
            }
            return false;
        }
        protected override bool DeleteItem()
        {
            if (CustomDGV.GetRowValue(productCategoryDTOCustomDataGridView, IdTrack.Index, out string sout))
            {
                return new ProductCategoryDB().DeleteData(sout);
            }
            return false;
        }
    }
}
