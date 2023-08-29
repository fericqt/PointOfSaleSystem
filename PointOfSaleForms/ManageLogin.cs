using FerPROJ;
using FerPROJ.FerCLASS;
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
    public partial class ManageLogin : ManageFormSettings
    {
        UserDTO MyDTO = new UserDTO();
        public ManageLogin()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            customTextBox1.Focus();
            switch (CurrentFormMode)
            {
                case FormMode.Add:
                    
                    break;
                case FormMode.Update:
                    break;
                case FormMode.ReadOnly:
                    break;

            }
            userDTOBindingSource.DataSource = MyDTO;
        }
        protected override bool OnSaveData()
        {
            if(new UserDB().ValidateUser(MyDTO))
            {
                return true;
            }
            if(CustomShowMessage.AskMessageBox("Do you want to register an account?", "Confirmation"))
            {
                return new FormLayer.ManageForm().ManageUser("", FormMode.Add);
            }
            return false;
        }
        protected override void InitializeKeyboardShortcuts()
        {
            keyboardShortcuts[Keys.F1] = ConnectionSettings;
        }
        private void ConnectionSettings()
        {
            CustomConnectionSettings.ConnectToDatabase();
        }
    }
}
