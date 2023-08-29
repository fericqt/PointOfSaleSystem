
namespace PointOfSaleForms
{
    partial class ManageUnitOfMeasure
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
            this.customLabelDesc1 = new FerPROJ.FerCONTROLS.CustomLabelDesc();
            this.customTextBox1 = new FerPROJ.CustomTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.unitOfMeasureDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(240, 1);
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
            this.PanelMain3.Controls.Add(this.customTextBox1);
            this.PanelMain3.Controls.Add(this.customLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(475, 136);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // customLabelDesc1
            // 
            this.customLabelDesc1.AutoSize = true;
            this.customLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.customLabelDesc1.Location = new System.Drawing.Point(16, 28);
            this.customLabelDesc1.Name = "customLabelDesc1";
            this.customLabelDesc1.Size = new System.Drawing.Size(125, 25);
            this.customLabelDesc1.TabIndex = 0;
            this.customLabelDesc1.Text = "Unit Of Measure:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 15;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.unitOfMeasureDTOBindingSource, "UnitOfMeasure", true));
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(21, 67);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(435, 31);
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.TextProperty = null;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.unitOfMeasureDTOBindingSource;
            // 
            // unitOfMeasureDTOBindingSource
            // 
            this.unitOfMeasureDTOBindingSource.DataSource = typeof(PointOfSaleBL.UnitOfMeasureDTO);
            // 
            // ManageUnitOfMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 294);
            this.Name = "ManageUnitOfMeasure";
            this.Text = "ManageUnitOfMeasure";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.CustomTextBox customTextBox1;
        private FerPROJ.FerCONTROLS.CustomLabelDesc customLabelDesc1;
        private System.Windows.Forms.BindingSource unitOfMeasureDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}