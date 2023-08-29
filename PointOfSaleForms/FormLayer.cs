using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FerPROJ.FerFORMS.FrmManageMain;

namespace PointOfSaleForms
{
    public class FormLayer
    {
        public class ListForms
        {
            public void ListOfUsers()
            {
                using (FrmUsers frm = new FrmUsers())
                {
                    frm.ShowDialog();
                }
            }
            public bool ListOfProducts(bool manageMode, out string pCode)
            {
                using (FrmProductList frm = new FrmProductList())
                {
                    frm.CurrentManageMode = manageMode;
                    frm.ShowDialog();
                    pCode = frm.Form_IdTrack;
                    return true;
                }
            }
        }
        public class ManageForm
        {
            public bool ManageLogin() 
            {
                using (ManageLogin frm = new ManageLogin())
                {
                    frm.CurrentFormMode = FormMode.Add;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageUser(string idTrack, FormMode formMode)
            {
                using (ManageUser frm = new ManageUser())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageSales(string idTrack, FormMode formMode)
            {
                using(ManageNewSales frm = new ManageNewSales())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageProduct(string idTrack, FormMode formMode)
            {
                using (ManageProduct frm = new ManageProduct())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
        }

    }
}
