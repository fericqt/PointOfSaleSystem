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
    public partial class ManageAddCustomer : ManageFormSettings
    {
        public string customerName;
        public ManageAddCustomer()
        {
            InitializeComponent();
        }
        protected override bool OnSaveData()
        {
            customerName = customTextBox1.Text;
            return true;
        }
    }
}
