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
    public partial class ManageManufacturer : ManageFormSettings
    {
        ManufacturerDTO MyDTO = new ManufacturerDTO();
        public ManageManufacturer()
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
                    MyDTO = new ManufacturerDB().GetById(Manage_IdTrack);
                    break;
            }
            manufacturerDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            return new ManufacturerDB().SaveData(MyDTO);
        }
        protected override bool OnUpdateData()
        {
            return new ManufacturerDB().UpdateData(MyDTO);
        }
    }
}
