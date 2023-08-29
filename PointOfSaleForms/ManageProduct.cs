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
    public partial class ManageProduct : ManageFormSettings
    {
        ProductDTO MyDTO = new ProductDTO();
        public ManageProduct()
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
                    MyDTO = new ProductDB().GetById(Manage_IdTrack);
                    break;

            }
            productDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            return new ProductDB().SaveData(MyDTO);
        }
        protected override bool OnUpdateData()
        {
            return new ProductDB().UpdateData(MyDTO);
        }
    }
}
