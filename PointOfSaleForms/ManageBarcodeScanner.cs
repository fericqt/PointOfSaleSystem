using FerPROJ;
using FerPROJ.FerCLASS;
using PointOfSaleDB;
using PointOfSaleSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            SetLocation();
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
            bs.LaunchCamera();

            if (bs.IsCameraOpen)
            {
                bs.BarcodeScanned += Output;
                bs.CameraDisplay += CameraDisplay;
                scanningProgressBar.Style = ProgressBarStyle.Marquee;
            }

        }

        private void CameraDisplay(Bitmap obj)
        {
            BeginInvoke(new Action(() => barcodePictureBox.BackgroundImage = obj));
        }

        private void Output(string barcodeData)
        {

            BeginInvoke(new Action(() => barcodeCustomTextBox.Text = barcodeData));
        }

        private void ManageBarcodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            bs.Stop();
            bs.TerminateCamera();
        }
        protected override bool OnSaveData()
        {
            if (barcodeCustomTextBox.Text != "")
            {
                var pCode = new ProductDB().GetByBarcode(barcodeCustomTextBox.Text).ProductCode;
                if (pCode != null)
                {
                    Manage_IdTrack = pCode;
                    return true;
                }
            }
            return false;
        }
        private void SetLocation()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(workingArea.Left, workingArea.Top);
        }
        protected override void InitializeKeyboardShortcuts()
        {
            keyboardShortcuts[Keys.Insert] = bs.LaunchCamera;
        }
        private void CameraChecking()
        {
            if (bs._cameraProcess == null)
            {
                CustomShowMessage.WarningMessageBox("Camera is not running yet!\nPlease click [Insert] in your keyboard to launch the camera.", "Warning");
            }
        }

        private void barcodeCustomTextBox__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (barcodeCustomTextBox.Text != "")
                {
                    var pCode = new ProductDB().GetByBarcode(barcodeCustomTextBox.Text).ProductCode;
                    if (pCode != null)
                    {
                        statusCustomLabelDesc.Text = "Found";
                        Manage_IdTrack = pCode;
                        CurrentFormResult = true;
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                //do nothing
                statusCustomLabelDesc.Text = "Not Found";
            }
        }
    }
}
