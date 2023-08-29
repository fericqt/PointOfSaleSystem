using FerPROJ.FerUC;
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
    public partial class ucSales : ucCustom
    {
        public ucSales()
        {
            InitializeComponent();
        }

        private void createSalesCustomButton_Click(object sender, EventArgs e)
        {
            new FormLayer.ManageForm().ManageSales("", FormMode.Add);
        }
    }
}
