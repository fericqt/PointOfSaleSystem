using FerPROJ;
using FerPROJ.FerCLASS;
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
    public partial class ManageBarcodeScanner : ManageFormSettings
    {
        CustomBarcodeScanner bs = new CustomBarcodeScanner();
        public ManageBarcodeScanner()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            switch (CurrentFormMode)
            {
                case FormMode.Add:
                    StartScanning();
                    break;
                case FormMode.Update:
                    break;
            }

        }

        private void StartScanning()
        {
            bs.Start();
            bs.BarcodeScanned += Output;
            if (bs.IsCameraOpen)
            {
                scanningProgressBar.Style = ProgressBarStyle.Marquee;
            }
        }
        private void Output(string barcodeData)
        {
            BeginInvoke(new Action(() => barcodeCustomTextBox.Text = barcodeData));
        }

        private void ManageBarcodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            bs.Stop();
        }
        protected override bool OnSaveData()
        {
            Manage_IdTrack = barcodeCustomTextBox.Text;
            return true;
        }

    }
}
