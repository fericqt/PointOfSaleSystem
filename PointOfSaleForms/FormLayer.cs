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
            public bool ListOfProductCategory(bool manageMode, out string idTrack)
            {
                using (FrmProductCategory frm = new FrmProductCategory())
                {
                    frm.CurrentManageMode = manageMode;
                    frm.ShowDialog();
                    idTrack = frm.Form_IdTrack;
                    return true;
                }
            }
            public bool ListOfUnitOfMeasure(bool manageMode, out string idTrack)
            {
                using (FrmUnitOfMeasure frm = new FrmUnitOfMeasure())
                {
                    frm.CurrentManageMode = manageMode;
                    frm.ShowDialog();
                    idTrack = frm.Form_IdTrack;
                    return true;
                }
            }
            public bool ListOfManufacturer(bool manageMode, out string idTrack)
            {
                using (FrmManufacturer frm = new FrmManufacturer())
                {
                    frm.CurrentManageMode = manageMode;
                    frm.ShowDialog();
                    idTrack = frm.Form_IdTrack;
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
            public bool ManageProductCategory(string idTrack, FormMode formMode)
            {
                using (ManageProductCategory frm = new ManageProductCategory())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageUnitOfMeasure(string idTrack, FormMode formMode)
            {
                using (ManageUnitOfMeasure frm = new ManageUnitOfMeasure())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageManufacturer(string idTrack, FormMode formMode)
            {
                using (ManageManufacturer frm = new ManageManufacturer())
                {
                    frm.Manage_IdTrack = idTrack;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageBarcodeScanner(out string idTrack, FormMode formMode)
            {
                using (ManageBarcodeScanner frm = new ManageBarcodeScanner())
                {
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    idTrack = frm.Manage_IdTrack;
                    return frm.CurrentFormResult;
                }
            }
        }

    }
}
