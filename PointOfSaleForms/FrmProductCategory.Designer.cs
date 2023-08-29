
namespace PointOfSaleForms
{
    partial class FrmProductCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productCategoryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryDTOCustomDataGridView = new FerPROJ.FerCONTROLS.CustomDataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDTOCustomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseButtonSelect
            // 
            this.baseButtonSelect.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain4
            // 
            this.PanelMain4.AutoScroll = true;
            this.PanelMain4.Controls.Add(this.productCategoryDTOCustomDataGridView);
            this.PanelMain4.Size = new System.Drawing.Size(632, 363);
            this.PanelMain4.Controls.SetChildIndex(this.productCategoryDTOCustomDataGridView, 0);
            // 
            // productCategoryDTOBindingSource
            // 
            this.productCategoryDTOBindingSource.DataSource = typeof(PointOfSaleBL.ProductCategoryDTO);
            // 
            // productCategoryDTOCustomDataGridView
            // 
            this.productCategoryDTOCustomDataGridView.AllowUserToAddRows = false;
            this.productCategoryDTOCustomDataGridView.AllowUserToDeleteRows = false;
            this.productCategoryDTOCustomDataGridView.AllowUserToOrderColumns = true;
            this.productCategoryDTOCustomDataGridView.AllowUserToResizeRows = false;
            this.productCategoryDTOCustomDataGridView.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.productCategoryDTOCustomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productCategoryDTOCustomDataGridView.AutoGenerateColumns = false;
            this.productCategoryDTOCustomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCategoryDTOCustomDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productCategoryDTOCustomDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.productCategoryDTOCustomDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productCategoryDTOCustomDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productCategoryDTOCustomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productCategoryDTOCustomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryDTOCustomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.productCategoryDTOCustomDataGridView.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.productCategoryDTOCustomDataGridView.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.productCategoryDTOCustomDataGridView.CustomRowFontStyle = new System.Drawing.Font("Poppins", 8F);
            this.productCategoryDTOCustomDataGridView.DataSource = this.productCategoryDTOBindingSource;
            this.productCategoryDTOCustomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productCategoryDTOCustomDataGridView.EnableHeadersVisualStyles = false;
            this.productCategoryDTOCustomDataGridView.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.productCategoryDTOCustomDataGridView.Location = new System.Drawing.Point(0, 41);
            this.productCategoryDTOCustomDataGridView.Name = "productCategoryDTOCustomDataGridView";
            this.productCategoryDTOCustomDataGridView.ReadOnly = true;
            this.productCategoryDTOCustomDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productCategoryDTOCustomDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productCategoryDTOCustomDataGridView.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.productCategoryDTOCustomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productCategoryDTOCustomDataGridView.Size = new System.Drawing.Size(632, 251);
            this.productCategoryDTOCustomDataGridView.TabIndex = 4;
            // 
            // IdTrack
            // 
            this.IdTrack.DataPropertyName = "IdTrack";
            this.IdTrack.FillWeight = 30F;
            this.IdTrack.HeaderText = "IdTrack";
            this.IdTrack.Name = "IdTrack";
            this.IdTrack.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateReference";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateReference";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Name = "FrmProductCategory";
            this.Text = "FrmProductCategory";
            this.PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDTOCustomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomDataGridView productCategoryDTOCustomDataGridView;
        private System.Windows.Forms.BindingSource productCategoryDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}