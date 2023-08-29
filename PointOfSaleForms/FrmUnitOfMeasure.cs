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
    public partial class FrmUnitOfMeasure : ListFormSettings
    {
        public FrmUnitOfMeasure()
        {
            InitializeComponent();
        }
        protected override void RefreshData()
        {
            new UnitOfMeasureDB().LoadListAll(unitOfMeasureDTOCustomDataGridView);
        }
        protected override bool AddNewItem()
        {
            return new FormLayer.ManageForm().ManageUnitOfMeasure("", FormMode.Add);
        }
        protected override bool UpdateItem()
        {
            if(CustomDGV.GetRowValue(unitOfMeasureDTOCustomDataGridView, IdTrack.Index, out string sout))
            {
                return new FormLayer.ManageForm().ManageUnitOfMeasure(sout, FormMode.Update);
            }
            return false;
        }
    }
}
