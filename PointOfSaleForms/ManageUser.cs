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
    public partial class ManageUser : ManageFormSettings
    {
        UserDTO MyDTO = new UserDTO();
        public ManageUser()
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
                    MyDTO = new UserDB().GetById(Manage_IdTrack);
                    break;
                case FormMode.ReadOnly:
                    break;

            }
            userDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            return new UserDB().SaveData(MyDTO);
        }
        protected override bool OnUpdateData()
        {
            return new UserDB().UpdateData(MyDTO);
        }
    }
}
