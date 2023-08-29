
namespace PointOfSaleSettings
{
    partial class SplasherFormSettings
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
            this.customLabelTitle1 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.basePnl2.SuspendLayout();
            this.PlanelSplasherBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Controls.Add(this.customLabelTitle1);
            this.basePnl2.Size = new System.Drawing.Size(416, 146);
            this.basePnl2.Controls.SetChildIndex(this.PlanelSplasherBottom, 0);
            this.basePnl2.Controls.SetChildIndex(this.customLabelTitle1, 0);
            // 
            // pbLoadingPercent
            // 
            this.pbLoadingPercent.Size = new System.Drawing.Size(416, 21);
            // 
            // LblLoadingMessage
            // 
            this.LblLoadingMessage.Size = new System.Drawing.Size(416, 20);
            // 
            // PlanelSplasherBottom
            // 
            this.PlanelSplasherBottom.Location = new System.Drawing.Point(0, 102);
            this.PlanelSplasherBottom.Size = new System.Drawing.Size(416, 44);
            // 
            // customLabelTitle1
            // 
            this.customLabelTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customLabelTitle1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabelTitle1.ForeColor = System.Drawing.Color.White;
            this.customLabelTitle1.Location = new System.Drawing.Point(0, 20);
            this.customLabelTitle1.Name = "customLabelTitle1";
            this.customLabelTitle1.Size = new System.Drawing.Size(416, 82);
            this.customLabelTitle1.TabIndex = 3;
            this.customLabelTitle1.Text = "Welcome to \r\nPoint of Sale System";
            this.customLabelTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SplasherFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 152);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplasherFormSettings";
            this.Text = "frm";
            this.basePnl2.ResumeLayout(false);
            this.PlanelSplasherBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle1;
    }
}