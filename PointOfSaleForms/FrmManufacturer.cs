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
    public partial class FrmManufacturer : ListFormSettings
    {
        public FrmManufacturer()
        {
            InitializeComponent();
        }
        protected override void RefreshData()
        {
            new ManufacturerDB().LoadListAll(manufacturerDTOCustomDataGridView);
        }
        protected override bool AddNewItem()
        {
            return new FormLayer.ManageForm().ManageManufacturer("", FormMode.Add);
        }
        protected override bool UpdateItem()
        {
            if(CustomDGV.GetRowValue(manufacturerDTOCustomDataGridView, IdTrack.Index, out string sout))
            {
                return new FormLayer.ManageForm().ManageManufacturer(sout, FormMode.Update);
            }
            return false;
        }
    }
}
