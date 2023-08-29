
namespace PointOfSaleForms
{
    partial class ManageUser
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
            this.customTextBox1 = new FerPROJ.CustomTextBox();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customLabelTitle1 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.customTextBox2 = new FerPROJ.CustomTextBox();
            this.customLabelTitle2 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.customTextBox3 = new FerPROJ.CustomTextBox();
            this.customLabelTitle3 = new FerPROJ.FerCONTROLS.CustomLabelTitle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(287, 3);
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
            this.PanelMain3.Controls.Add(this.customTextBox3);
            this.PanelMain3.Controls.Add(this.customLabelTitle3);
            this.PanelMain3.Controls.Add(this.customTextBox2);
            this.PanelMain3.Controls.Add(this.customLabelTitle2);
            this.PanelMain3.Controls.Add(this.customTextBox1);
            this.PanelMain3.Controls.Add(this.customLabelTitle1);
            this.PanelMain3.Size = new System.Drawing.Size(522, 300);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // customPanelMain1
            // 
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 15;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.userDTOBindingSource, "Username", true));
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(59, 55);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(395, 31);
            this.customTextBox1.TabIndex = 4;
            this.customTextBox1.TextProperty = null;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(PointOfSaleBL.UserDTO);
            // 
            // customLabelTitle1
            // 
            this.customLabelTitle1.AutoSize = true;
            this.customLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle1.Location = new System.Drawing.Point(53, 15);
            this.customLabelTitle1.Name = "customLabelTitle1";
            this.customLabelTitle1.Size = new System.Drawing.Size(127, 36);
            this.customLabelTitle1.TabIndex = 3;
            this.customLabelTitle1.Text = "Username:";
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderRadius = 15;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.userDTOBindingSource, "Password", true));
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox2.Location = new System.Drawing.Point(59, 143);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(395, 31);
            this.customTextBox2.TabIndex = 6;
            this.customTextBox2.TextProperty = null;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customLabelTitle2
            // 
            this.customLabelTitle2.AutoSize = true;
            this.customLabelTitle2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle2.Location = new System.Drawing.Point(53, 103);
            this.customLabelTitle2.Name = "customLabelTitle2";
            this.customLabelTitle2.Size = new System.Drawing.Size(116, 36);
            this.customLabelTitle2.TabIndex = 5;
            this.customLabelTitle2.Text = "Password";
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox3.BorderRadius = 15;
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("TextProperty", this.userDTOBindingSource, "Password", true));
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox3.Location = new System.Drawing.Point(59, 230);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "";
            this.customTextBox3.Size = new System.Drawing.Size(395, 31);
            this.customTextBox3.TabIndex = 8;
            this.customTextBox3.TextProperty = null;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // customLabelTitle3
            // 
            this.customLabelTitle3.AutoSize = true;
            this.customLabelTitle3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle3.Location = new System.Drawing.Point(53, 190);
            this.customLabelTitle3.Name = "customLabelTitle3";
            this.customLabelTitle3.Size = new System.Drawing.Size(210, 36);
            this.customLabelTitle3.TabIndex = 7;
            this.customLabelTitle3.Text = "Confirm Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.userDTOBindingSource;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 459);
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.CustomTextBox customTextBox3;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle3;
        private FerPROJ.CustomTextBox customTextBox2;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle2;
        private FerPROJ.CustomTextBox customTextBox1;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle1;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}