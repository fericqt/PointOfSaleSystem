
namespace PointOfSaleForms
{
    partial class FrmManufacturer
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
            this.manufacturerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerDTOCustomDataGridView = new FerPROJ.FerCONTROLS.CustomDataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDTOCustomDataGridView)).BeginInit();
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
            this.PanelMain4.Controls.Add(this.manufacturerDTOCustomDataGridView);
            this.PanelMain4.Size = new System.Drawing.Size(662, 363);
            this.PanelMain4.Controls.SetChildIndex(this.manufacturerDTOCustomDataGridView, 0);
            // 
            // manufacturerDTOBindingSource
            // 
            this.manufacturerDTOBindingSource.DataSource = typeof(PointOfSaleBL.ManufacturerDTO);
            // 
            // manufacturerDTOCustomDataGridView
            // 
            this.manufacturerDTOCustomDataGridView.AllowUserToAddRows = false;
            this.manufacturerDTOCustomDataGridView.AllowUserToDeleteRows = false;
            this.manufacturerDTOCustomDataGridView.AllowUserToOrderColumns = true;
            this.manufacturerDTOCustomDataGridView.AllowUserToResizeRows = false;
            this.manufacturerDTOCustomDataGridView.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.manufacturerDTOCustomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.manufacturerDTOCustomDataGridView.AutoGenerateColumns = false;
            this.manufacturerDTOCustomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manufacturerDTOCustomDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.manufacturerDTOCustomDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.manufacturerDTOCustomDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manufacturerDTOCustomDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerDTOCustomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.manufacturerDTOCustomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturerDTOCustomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.manufacturerDTOCustomDataGridView.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.manufacturerDTOCustomDataGridView.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.manufacturerDTOCustomDataGridView.CustomRowFontStyle = new System.Drawing.Font("Poppins", 8F);
            this.manufacturerDTOCustomDataGridView.DataSource = this.manufacturerDTOBindingSource;
            this.manufacturerDTOCustomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manufacturerDTOCustomDataGridView.EnableHeadersVisualStyles = false;
            this.manufacturerDTOCustomDataGridView.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.manufacturerDTOCustomDataGridView.Location = new System.Drawing.Point(0, 41);
            this.manufacturerDTOCustomDataGridView.Name = "manufacturerDTOCustomDataGridView";
            this.manufacturerDTOCustomDataGridView.ReadOnly = true;
            this.manufacturerDTOCustomDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerDTOCustomDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.manufacturerDTOCustomDataGridView.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.manufacturerDTOCustomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manufacturerDTOCustomDataGridView.Size = new System.Drawing.Size(662, 251);
            this.manufacturerDTOCustomDataGridView.TabIndex = 4;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer";
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
            // FrmManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Name = "FrmManufacturer";
            this.Text = "FrmManufacturer";
            this.PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDTOCustomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomDataGridView manufacturerDTOCustomDataGridView;
        private System.Windows.Forms.BindingSource manufacturerDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}