
namespace PointOfSaleSystem.UserControlFolder
{
    partial class ucSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customLabelTitle1 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.createSalesCustomButton = new FerPROJ.CustomButton();
            this.customButton2 = new FerPROJ.CustomButton();
            this.ucPanelMain.SuspendLayout();
            this.ucPanelMain1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucLabelMain4
            // 
            this.ucLabelMain4.BackColor = System.Drawing.Color.Silver;
            this.ucLabelMain4.Location = new System.Drawing.Point(5, 0);
            this.ucLabelMain4.Size = new System.Drawing.Size(950, 5);
            this.ucLabelMain4.Text = "";
            // 
            // ucLabelMain3
            // 
            this.ucLabelMain3.BackColor = System.Drawing.Color.Silver;
            this.ucLabelMain3.Location = new System.Drawing.Point(5, 537);
            this.ucLabelMain3.Size = new System.Drawing.Size(950, 5);
            this.ucLabelMain3.Text = "";
            // 
            // ucLabelMain2
            // 
            this.ucLabelMain2.BackColor = System.Drawing.Color.Silver;
            this.ucLabelMain2.Location = new System.Drawing.Point(955, 0);
            this.ucLabelMain2.Size = new System.Drawing.Size(5, 542);
            this.ucLabelMain2.Text = "";
            // 
            // ucLabelMain1
            // 
            this.ucLabelMain1.BackColor = System.Drawing.Color.Silver;
            this.ucLabelMain1.Size = new System.Drawing.Size(5, 542);
            this.ucLabelMain1.Text = "";
            // 
            // ucPanelMain
            // 
            this.ucPanelMain.Size = new System.Drawing.Size(960, 542);
            // 
            // ucPanelMain1
            // 
            this.ucPanelMain1.Controls.Add(this.customButton2);
            this.ucPanelMain1.Controls.Add(this.createSalesCustomButton);
            this.ucPanelMain1.Controls.Add(this.customLabelTitle1);
            this.ucPanelMain1.Location = new System.Drawing.Point(5, 5);
            this.ucPanelMain1.Size = new System.Drawing.Size(950, 532);
            // 
            // customLabelTitle1
            // 
            this.customLabelTitle1.AutoSize = true;
            this.customLabelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.customLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle1.Location = new System.Drawing.Point(27, 22);
            this.customLabelTitle1.Name = "customLabelTitle1";
            this.customLabelTitle1.Size = new System.Drawing.Size(163, 36);
            this.customLabelTitle1.TabIndex = 1;
            this.customLabelTitle1.Text = "Sales Function";
            // 
            // createSalesCustomButton
            // 
            this.createSalesCustomButton.BackColor = System.Drawing.Color.Silver;
            this.createSalesCustomButton.BackgroundColor = System.Drawing.Color.Silver;
            this.createSalesCustomButton.BorderColor = System.Drawing.Color.Green;
            this.createSalesCustomButton.BorderRadius = 20;
            this.createSalesCustomButton.BorderSize = 0;
            this.createSalesCustomButton.FlatAppearance.BorderSize = 0;
            this.createSalesCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSalesCustomButton.Font = new System.Drawing.Font("Poppins", 9F);
            this.createSalesCustomButton.ForeColor = System.Drawing.Color.Black;
            this.createSalesCustomButton.Location = new System.Drawing.Point(33, 81);
            this.createSalesCustomButton.Name = "createSalesCustomButton";
            this.createSalesCustomButton.Size = new System.Drawing.Size(150, 40);
            this.createSalesCustomButton.TabIndex = 2;
            this.createSalesCustomButton.Text = "Create New Sales";
            this.createSalesCustomButton.TextColor = System.Drawing.Color.Black;
            this.createSalesCustomButton.UseVisualStyleBackColor = false;
            this.createSalesCustomButton.Click += new System.EventHandler(this.createSalesCustomButton_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Silver;
            this.customButton2.BackgroundColor = System.Drawing.Color.Silver;
            this.customButton2.BorderColor = System.Drawing.Color.Green;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Poppins", 9F);
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(208, 81);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(150, 40);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "Create New Payment";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Silver;
            this.BorderSize = 5;
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(960, 542);
            this.ucPanelMain.ResumeLayout(false);
            this.ucPanelMain1.ResumeLayout(false);
            this.ucPanelMain1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle1;
        private FerPROJ.CustomButton customButton2;
        private FerPROJ.CustomButton createSalesCustomButton;
    }
}
