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
    public partial class ManageUnitOfMeasure : ManageFormSettings
    {
        UnitOfMeasureDTO MyDTO = new UnitOfMeasureDTO();
        public ManageUnitOfMeasure()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            switch (CurrentFormMode)
            {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    MyDTO = new UnitOfMeasureDB().GetById(Manage_IdTrack);
                    break;
            }
            unitOfMeasureDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            return new UnitOfMeasureDB().SaveData(MyDTO);
        }
        protected override bool OnUpdateData()
        {
            return new UnitOfMeasureDB().UpdateData(MyDTO);
        }
        protected override bool OnSaveNewData()
        {
            MyDTO = new UnitOfMeasureDTO();
            unitOfMeasureDTOBindingSource.DataSource = MyDTO;
            return true;
        }
    }
}
