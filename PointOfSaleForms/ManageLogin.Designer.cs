
namespace PointOfSaleForms
{
    partial class ManageLogin
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
            this.customTextBox1 = new FerPROJ.CustomTextBox();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customTextBox2 = new FerPROJ.CustomTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(273, 1);
            this.basePnl2.TabIndex = 0;
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            this.baseButtonUpdate.Text = "Login";
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
            this.PanelMain3.Controls.Add(this.customTextBox2);
            this.PanelMain3.Controls.Add(this.customTextBox1);
            this.PanelMain3.Controls.Add(this.customLabelTitle2);
            this.PanelMain3.Controls.Add(this.customLabelTitle1);
            this.PanelMain3.Size = new System.Drawing.Size(508, 232);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // customLabelTitle1
            // 
            this.customLabelTitle1.AutoSize = true;
            this.customLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle1.Location = new System.Drawing.Point(57, 23);
            this.customLabelTitle1.Name = "customLabelTitle1";
            this.customLabelTitle1.Size = new System.Drawing.Size(127, 36);
            this.customLabelTitle1.TabIndex = 0;
            this.customLabelTitle1.Text = "Username:";
            // 
            // customLabelTitle2
            // 
            this.customLabelTitle2.AutoSize = true;
            this.customLabelTitle2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.customLabelTitle2.Location = new System.Drawing.Point(57, 112);
            this.customLabelTitle2.Name = "customLabelTitle2";
            this.customLabelTitle2.Size = new System.Drawing.Size(122, 36);
            this.customLabelTitle2.TabIndex = 1;
            this.customLabelTitle2.Text = "Password:";
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
            this.customTextBox1.Location = new System.Drawing.Point(63, 63);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.OnFocus = true;
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(395, 31);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.TextProperty = null;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(PointOfSaleBL.UserDTO);
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
            this.customTextBox2.Location = new System.Drawing.Point(63, 152);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.OnFocus = false;
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(395, 31);
            this.customTextBox2.TabIndex = 1;
            this.customTextBox2.TextProperty = null;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.userDTOBindingSource;
            // 
            // ManageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 390);
            this.HideSaveNew = true;
            this.Name = "ManageLogin";
            this.OnUpdateName = "Login";
            this.Text = "ManageLogin";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.CustomTextBox customTextBox1;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle2;
        private FerPROJ.FerCONTROLS.CustomLabelTitle customLabelTitle1;
        private FerPROJ.CustomTextBox customTextBox2;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}