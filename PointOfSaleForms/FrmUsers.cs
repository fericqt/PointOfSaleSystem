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
using static FerPROJ.FerFORMS.FrmManageMain;

namespace PointOfSaleForms
{
    public partial class FrmUsers : ListFormSettings
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        protected override void RefreshData()
        {
            new UserDB().LoadListAll(userDTOCustomDataGridView);
            CustomDGV.SearchDGV(userDTOCustomDataGridView, SearchTextBox);
            
        }
        protected override bool AddNewItem()
        {
            return new FormLayer.ManageForm().ManageUser("", FormMode.Add);
        }
        protected override bool UpdateItem()
        {
            if (CustomDGV.GetRowValue(userDTOCustomDataGridView, UserID.Index, out string sout)) {
                return new FormLayer.ManageForm().ManageUser(sout, FormMode.Update);
            }
            return false;
        }
    }
}
