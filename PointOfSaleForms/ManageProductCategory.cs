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
    public partial class ManageProductCategory : ManageFormSettings
    {
        ProductCategoryDTO MyDTO = new ProductCategoryDTO();
        public ManageProductCategory()
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
                    MyDTO = new ProductCategoryDB().GetById(Manage_IdTrack);
                    break;
            }
            productCategoryDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            return new ProductCategoryDB().SaveData(MyDTO);
        }
        protected override bool OnUpdateData()
        {
            return new ProductCategoryDB().UpdateData(MyDTO);
        }
    }
}
