using PointOfSaleForms;
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

namespace PointOfSaleSystem.UserControlFolder
{
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void productListCustomButton_Click(object sender, EventArgs e)
        {
            new FormLayer.ListForms().ListOfProducts(false, out string sout);
        }

        private void productCatCustomButton_Click(object sender, EventArgs e)
        {
            new FormLayer.ListForms().ListOfProductCategory(false, out string sout);
        }

        private void uomCustomButton_Click(object sender, EventArgs e)
        {
            new FormLayer.ListForms().ListOfUnitOfMeasure(false, out string sout);
        }

        private void manufacturerCustomButton_Click(object sender, EventArgs e)
        {
            new FormLayer.ListForms().ListOfManufacturer(false, out string sout);
        }

        private void productBarcodeCustomButton_Click(object sender, EventArgs e)
        {
            using (var frm = new ManageBarcodeScanner())
            {
                frm.CurrentFormMode = FormMode.Add;
                frm.ShowDialog();
            }
        }
    }
}
