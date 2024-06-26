﻿
namespace PointOfSaleForms
{
    partial class ManageBarcodeScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customLabelDesc1 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.barcodeCustomTextBox = new FerPROJ.CustomTextBox();
            this.scanningProgressBar = new System.Windows.Forms.ProgressBar();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.statusCustomLabelDesc = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(347, 1);
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(this.statusCustomLabelDesc);
            this.PanelMain3.Controls.Add(this.barcodePictureBox);
            this.PanelMain3.Controls.Add(this.scanningProgressBar);
            this.PanelMain3.Controls.Add(this.barcodeCustomTextBox);
            this.PanelMain3.Controls.Add(this.customLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(582, 347);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // customLabelDesc1
            // 
            this.customLabelDesc1.AutoSize = true;
            this.customLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc1.Location = new System.Drawing.Point(16, 17);
            this.customLabelDesc1.Name = "customLabelDesc1";
            this.customLabelDesc1.Size = new System.Drawing.Size(74, 25);
            this.customLabelDesc1.TabIndex = 0;
            this.customLabelDesc1.Text = "Barcode:";
            // 
            // barcodeCustomTextBox
            // 
            this.barcodeCustomTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.barcodeCustomTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.barcodeCustomTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.barcodeCustomTextBox.BorderRadius = 15;
            this.barcodeCustomTextBox.BorderSize = 2;
            this.barcodeCustomTextBox.Enabled = false;
            this.barcodeCustomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeCustomTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barcodeCustomTextBox.Location = new System.Drawing.Point(21, 46);
            this.barcodeCustomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.barcodeCustomTextBox.Multiline = false;
            this.barcodeCustomTextBox.Name = "barcodeCustomTextBox";
            this.barcodeCustomTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.barcodeCustomTextBox.PasswordChar = false;
            this.barcodeCustomTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.barcodeCustomTextBox.PlaceholderText = "";
            this.barcodeCustomTextBox.Size = new System.Drawing.Size(542, 31);
            this.barcodeCustomTextBox.TabIndex = 1;
            this.barcodeCustomTextBox.TextProperty = null;
            this.barcodeCustomTextBox.Texts = "";
            this.barcodeCustomTextBox.UnderlinedStyle = false;
            this.barcodeCustomTextBox._TextChanged += new System.EventHandler(this.barcodeCustomTextBox__TextChanged);
            // 
            // scanningProgressBar
            // 
            this.scanningProgressBar.Location = new System.Drawing.Point(21, 84);
            this.scanningProgressBar.Name = "scanningProgressBar";
            this.scanningProgressBar.Size = new System.Drawing.Size(542, 23);
            this.scanningProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.scanningProgressBar.TabIndex = 2;
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barcodePictureBox.Location = new System.Drawing.Point(21, 134);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(542, 193);
            this.barcodePictureBox.TabIndex = 3;
            this.barcodePictureBox.TabStop = false;
            // 
            // statusCustomLabelDesc
            // 
            this.statusCustomLabelDesc.AutoSize = true;
            this.statusCustomLabelDesc.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCustomLabelDesc.Location = new System.Drawing.Point(87, 20);
            this.statusCustomLabelDesc.Name = "statusCustomLabelDesc";
            this.statusCustomLabelDesc.Size = new System.Drawing.Size(70, 19);
            this.statusCustomLabelDesc.TabIndex = 4;
            this.statusCustomLabelDesc.Text = "Scanning.....";
            // 
            // ManageBarcodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 505);
            this.FormDescription = "This is where you can scan barcode using camera.";
            this.FormIcon = global::PointOfSaleForms.Properties.Resources.Icons8_Windows_8_Ecommerce_Barcode_Scanner_32;
            this.FormTitle = "Barcode Scanner";
            this.HideSaveNew = true;
            this.Name = "ManageBarcodeScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageBarcodeScanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageBarcodeScanner_FormClosing);
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc1;
        private FerPROJ.CustomTextBox barcodeCustomTextBox;
        private System.Windows.Forms.ProgressBar scanningProgressBar;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private FerPROJ.FerCONTROLS.CustomLabelDesc statusCustomLabelDesc;
    }
}