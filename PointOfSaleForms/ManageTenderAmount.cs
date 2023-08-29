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
    public partial class ManageTenderAmount : ManageFormSettings
    {
        public decimal tenderedAmount;
        public ManageTenderAmount()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            customTextBox1.Focus();
        }
        protected override bool OnSaveData()
        {
            tenderedAmount = Convert.ToDecimal(customTextBox1.Text);
            return true;
        }
    }
}
