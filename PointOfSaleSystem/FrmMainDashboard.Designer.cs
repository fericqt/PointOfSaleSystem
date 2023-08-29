
namespace PointOfSaleSystem
{
    partial class FrmMainDashboard
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
            this.customPanel1 = new FerPROJ.FerCONTROLS.CustomPanel();
            this.salesCustomButton = new FerPROJ.CustomButton();
            this.dashboardCustomButton = new FerPROJ.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSales1 = new PointOfSaleSystem.UserControlFolder.ucSales();
            this.ucMain1 = new PointOfSaleSystem.UserControlFolder.ucMain();
            this.MainDashboardPanel1.SuspendLayout();
            this.MainDashboardlpanel10.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardPanel1
            // 
            this.MainDashboardPanel1.Size = new System.Drawing.Size(1176, 616);
            // 
            // MainDashboardlpanel10
            // 
            this.MainDashboardlpanel10.Controls.Add(this.ucSales1);
            this.MainDashboardlpanel10.Controls.Add(this.ucMain1);
            this.MainDashboardlpanel10.Controls.Add(this.customPanel1);
            this.MainDashboardlpanel10.Size = new System.Drawing.Size(1166, 606);
            // 
            // customPanel1
            // 
            this.customPanel1.Controls.Add(this.salesCustomButton);
            this.customPanel1.Controls.Add(this.dashboardCustomButton);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.PanelBackColor = System.Drawing.Color.Empty;
            this.customPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.customPanel1.ShadowSize = 10;
            this.customPanel1.ShadowThickness = 20;
            this.customPanel1.ShowBottomShadow = true;
            this.customPanel1.ShowLeftShadow = true;
            this.customPanel1.ShowRightShadow = true;
            this.customPanel1.ShowTopShadow = true;
            this.customPanel1.Size = new System.Drawing.Size(220, 606);
            this.customPanel1.TabIndex = 0;
            // 
            // salesCustomButton
            // 
            this.salesCustomButton.BackColor = System.Drawing.Color.Silver;
            this.salesCustomButton.BackgroundColor = System.Drawing.Color.Silver;
            this.salesCustomButton.BorderColor = System.Drawing.Color.Yellow;
            this.salesCustomButton.BorderRadius = 20;
            this.salesCustomButton.BorderSize = 0;
            this.salesCustomButton.FlatAppearance.BorderSize = 0;
            this.salesCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesCustomButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesCustomButton.ForeColor = System.Drawing.Color.Black;
            this.salesCustomButton.Location = new System.Drawing.Point(9, 174);
            this.salesCustomButton.Name = "salesCustomButton";
            this.salesCustomButton.Size = new System.Drawing.Size(200, 40);
            this.salesCustomButton.TabIndex = 2;
            this.salesCustomButton.Text = "SALES";
            this.salesCustomButton.TextColor = System.Drawing.Color.Black;
            this.salesCustomButton.UseVisualStyleBackColor = false;
            this.salesCustomButton.Click += new System.EventHandler(this.salesCustomButton_Click);
            // 
            // dashboardCustomButton
            // 
            this.dashboardCustomButton.BackColor = System.Drawing.Color.Silver;
            this.dashboardCustomButton.BackgroundColor = System.Drawing.Color.Silver;
            this.dashboardCustomButton.BorderColor = System.Drawing.Color.Green;
            this.dashboardCustomButton.BorderRadius = 20;
            this.dashboardCustomButton.BorderSize = 0;
            this.dashboardCustomButton.FlatAppearance.BorderSize = 0;
            this.dashboardCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardCustomButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardCustomButton.ForeColor = System.Drawing.Color.Black;
            this.dashboardCustomButton.Location = new System.Drawing.Point(9, 128);
            this.dashboardCustomButton.Name = "dashboardCustomButton";
            this.dashboardCustomButton.Size = new System.Drawing.Size(200, 40);
            this.dashboardCustomButton.TabIndex = 1;
            this.dashboardCustomButton.Text = "DASHBOARD";
            this.dashboardCustomButton.TextColor = System.Drawing.Color.Black;
            this.dashboardCustomButton.UseVisualStyleBackColor = false;
            this.dashboardCustomButton.Click += new System.EventHandler(this.dashboardCustomButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 110);
            this.panel1.TabIndex = 0;
            // 
            // ucSales1
            // 
            this.ucSales1.BorderColor = System.Drawing.Color.Silver;
            this.ucSales1.BorderSize = 8;
            this.ucSales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSales1.Location = new System.Drawing.Point(220, 0);
            this.ucSales1.Name = "ucSales1";
            this.ucSales1.Size = new System.Drawing.Size(946, 606);
            this.ucSales1.TabIndex = 2;
            this.ucSales1.Visible = false;
            // 
            // ucMain1
            // 
            this.ucMain1.AutoScroll = true;
            this.ucMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMain1.Location = new System.Drawing.Point(220, 0);
            this.ucMain1.Name = "ucMain1";
            this.ucMain1.Size = new System.Drawing.Size(946, 606);
            this.ucMain1.TabIndex = 1;
            this.ucMain1.Visible = false;
            // 
            // FrmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1176, 616);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmMainDashboard";
            this.Text = "Form1";
            this.MainDashboardPanel1.ResumeLayout(false);
            this.MainDashboardlpanel10.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomPanel customPanel1;
        private FerPROJ.CustomButton salesCustomButton;
        private FerPROJ.CustomButton dashboardCustomButton;
        private System.Windows.Forms.Panel panel1;
        private UserControlFolder.ucMain ucMain1;
        private UserControlFolder.ucSales ucSales1;
    }
}

