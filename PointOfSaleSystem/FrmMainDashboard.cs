using FerPROJ.FerFORMS;
using PointOfSaleForms;
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

namespace PointOfSaleSystem
{
    public partial class FrmMainDashboard : FrmDashboardMain
    {
        public FrmMainDashboard()
        {
            InitializeComponent();
        }
        protected override void LoadComponent()
        {
            SplasherFormSettings.CloseSplash();
        }
        private void SetVisible()
        {
            ucMain1.Visible = false;
            ucSales1.Visible = false;
        }

        private void dashboardCustomButton_Click(object sender, EventArgs e)
        {
            SetVisible();
            ucMain1.Visible = true;
        }

        private void salesCustomButton_Click(object sender, EventArgs e)
        {
            SetVisible();
            ucSales1.Visible = true;
        }
    }
}
