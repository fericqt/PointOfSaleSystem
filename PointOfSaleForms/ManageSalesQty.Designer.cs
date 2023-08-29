
namespace PointOfSaleForms
{
    partial class ManageSalesQty
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
            this.components = new System.ComponentModel.Container();
            this.customLabelTitle1 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.customLabelTitle2 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.customLabelTitle3 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.salesDetailsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customLabelTitle4 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.label1 = new System.Windows.Forms.Label();
            this.customLabelDesc1 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.customTextBox1 = new FerPROJ.CustomTextBox();
            this.customLabelDesc2 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.customLabelDesc3 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.customLabelDesc4 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.customTextBox2 = new FerPROJ.CustomTextBox();
            this.customTextBox3 = new FerPROJ.CustomTextBox();
            this.customTextBox4 = new FerPROJ.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(398, 1);
            this.basePnl2.TabIndex = 0;
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
            this.PanelMain3.Controls.Add(this.label2);
            this.PanelMain3.Controls.Add(this.customTextBox4);
            this.PanelMain3.Controls.Add(this.customTextBox3);
            this.PanelMain3.Controls.Add(this.customTextBox2);
            this.PanelMain3.Controls.Add(this.customLabelDesc4);
            this.PanelMain3.Controls.Add(this.customLabelDesc3);
            this.PanelMain3.Controls.Add(this.customLabelDesc2);
            this.PanelMain3.Controls.Add(this.customTextBox1);
            this.PanelMain3.Controls.Add(this.customLabelDesc1);
            this.PanelMain3.Controls.Add(this.label1);
            this.PanelMain3.Controls.Add(this.customLabelTitle4);
            this.PanelMain3.Controls.Add(this.customLabelTitle3);
            this.PanelMain3.Controls.Add(this.customLabelTitle2);
            this.PanelMain3.Controls.Add(this.customLabelTitle1);
            this.PanelMain3.Size = new System.Drawing.Size(633, 434);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // customLabelTitle1
            // 
            this.customLabelTitle1.AutoSize = true;
            this.customLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle1.Location = new System.Drawing.Point(32, 26);
            this.customLabelTitle1.Name = "customLabelTitle1";
            this.customLabelTitle1.Size = new System.Drawing.Size(221, 36);
            this.customLabelTitle1.TabIndex = 0;
            this.customLabelTitle1.Text = "ProductDescription:";
            // 
            // customLabelTitle2
            // 
            this.customLabelTitle2.AutoSize = true;
            this.customLabelTitle2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle2.Location = new System.Drawing.Point(32, 116);
            this.customLabelTitle2.Name = "customLabelTitle2";
            this.customLabelTitle2.Size = new System.Drawing.Size(170, 36);
            this.customLabelTitle2.TabIndex = 1;
            this.customLabelTitle2.Text = "RemainingQty:";
            // 
            // customLabelTitle3
            // 
            this.customLabelTitle3.AutoSize = true;
            this.customLabelTitle3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesDetailsDTOBindingSource, "RemainingQty", true));
            this.customLabelTitle3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle3.ForeColor = System.Drawing.Color.Maroon;
            this.customLabelTitle3.Location = new System.Drawing.Point(247, 149);
            this.customLabelTitle3.Name = "customLabelTitle3";
            this.customLabelTitle3.Size = new System.Drawing.Size(221, 36);
            this.customLabelTitle3.TabIndex = 2;
            this.customLabelTitle3.Text = "ProductDescription:";
            // 
            // salesDetailsDTOBindingSource
            // 
            this.salesDetailsDTOBindingSource.DataSource = typeof(PointOfSaleBL.SalesDetailsDTO);
            // 
            // customLabelTitle4
            // 
            this.customLabelTitle4.AutoSize = true;
            this.customLabelTitle4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesDetailsDTOBindingSource, "ProductDescription", true));
            this.customLabelTitle4.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle4.ForeColor = System.Drawing.Color.Maroon;
            this.customLabelTitle4.Location = new System.Drawing.Point(247, 62);
            this.customLabelTitle4.Name = "customLabelTitle4";
            this.customLabelTitle4.Size = new System.Drawing.Size(221, 36);
            this.customLabelTitle4.TabIndex = 3;
            this.customLabelTitle4.Text = "ProductDescription:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 3);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // customLabelDesc1
            // 
            this.customLabelDesc1.AutoSize = true;
            this.customLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc1.Location = new System.Drawing.Point(261, 242);
            this.customLabelDesc1.Name = "customLabelDesc1";
            this.customLabelDesc1.Size = new System.Drawing.Size(39, 25);
            this.customLabelDesc1.TabIndex = 5;
            this.customLabelDesc1.Text = "Qty:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 15;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.salesDetailsDTOBindingSource, "Qty", true));
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(380, 242);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(234, 31);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.TextProperty = null;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // customLabelDesc2
            // 
            this.customLabelDesc2.AutoSize = true;
            this.customLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc2.Location = new System.Drawing.Point(261, 281);
            this.customLabelDesc2.Name = "customLabelDesc2";
            this.customLabelDesc2.Size = new System.Drawing.Size(49, 25);
            this.customLabelDesc2.TabIndex = 7;
            this.customLabelDesc2.Text = "Price:";
            // 
            // customLabelDesc3
            // 
            this.customLabelDesc3.AutoSize = true;
            this.customLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc3.Location = new System.Drawing.Point(261, 320);
            this.customLabelDesc3.Name = "customLabelDesc3";
            this.customLabelDesc3.Size = new System.Drawing.Size(73, 25);
            this.customLabelDesc3.TabIndex = 8;
            this.customLabelDesc3.Text = "Discount";
            // 
            // customLabelDesc4
            // 
            this.customLabelDesc4.AutoSize = true;
            this.customLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc4.Location = new System.Drawing.Point(261, 381);
            this.customLabelDesc4.Name = "customLabelDesc4";
            this.customLabelDesc4.Size = new System.Drawing.Size(108, 25);
            this.customLabelDesc4.TabIndex = 9;
            this.customLabelDesc4.Text = "Total Amount:";
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderRadius = 15;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.salesDetailsDTOBindingSource, "Price", true));
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox2.Location = new System.Drawing.Point(380, 281);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(234, 31);
            this.customTextBox2.TabIndex = 1;
            this.customTextBox2.TextProperty = null;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox3.BorderRadius = 15;
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.salesDetailsDTOBindingSource, "Discount", true));
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox3.Location = new System.Drawing.Point(380, 320);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "";
            this.customTextBox3.Size = new System.Drawing.Size(234, 31);
            this.customTextBox3.TabIndex = 2;
            this.customTextBox3.TextProperty = null;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox4.BorderRadius = 15;
            this.customTextBox4.BorderSize = 2;
            this.customTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.salesDetailsDTOBindingSource, "TotalAmount", true));
            this.customTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox4.Location = new System.Drawing.Point(380, 381);
            this.customTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox4.Multiline = false;
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox4.PasswordChar = false;
            this.customTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox4.PlaceholderText = "";
            this.customTextBox4.Size = new System.Drawing.Size(234, 31);
            this.customTextBox4.TabIndex = 3;
            this.customTextBox4.TextProperty = null;
            this.customTextBox4.Texts = "";
            this.customTextBox4.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 3);
            this.label2.TabIndex = 13;
            this.label2.Text = ".";
            // 
            // ManageSalesQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 592);
            this.HideSaveNew = true;
            this.Name = "ManageSalesQty";
            this.Text = "ManageSalesQty";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FerPROJ.CustomTextBox customTextBox4;
        private System.Windows.Forms.BindingSource salesDetailsDTOBindingSource;
        private FerPROJ.CustomTextBox customTextBox3;
        private FerPROJ.CustomTextBox customTextBox2;
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc4;
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc3;
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc2;
        private FerPROJ.CustomTextBox customTextBox1;
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc1;
        private System.Windows.Forms.Label label1;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle4;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle3;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle2;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle1;
    }
}