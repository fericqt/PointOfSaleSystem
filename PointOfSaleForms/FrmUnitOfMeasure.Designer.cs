
namespace PointOfSaleForms
{
    partial class FrmUnitOfMeasure
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
            this.unitOfMeasureDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasureDTOCustomDataGridView = new FerPROJ.FerCONTROLS.CustomDataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOCustomDataGridView)).BeginInit();
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
            this.PanelMain4.Controls.Add(this.unitOfMeasureDTOCustomDataGridView);
            this.PanelMain4.Size = new System.Drawing.Size(662, 363);
            this.PanelMain4.Controls.SetChildIndex(this.unitOfMeasureDTOCustomDataGridView, 0);
            // 
            // unitOfMeasureDTOBindingSource
            // 
            this.unitOfMeasureDTOBindingSource.DataSource = typeof(PointOfSaleBL.UnitOfMeasureDTO);
            // 
            // unitOfMeasureDTOCustomDataGridView
            // 
            this.unitOfMeasureDTOCustomDataGridView.AllowUserToAddRows = false;
            this.unitOfMeasureDTOCustomDataGridView.AllowUserToDeleteRows = false;
            this.unitOfMeasureDTOCustomDataGridView.AllowUserToOrderColumns = true;
            this.unitOfMeasureDTOCustomDataGridView.AllowUserToResizeRows = false;
            this.unitOfMeasureDTOCustomDataGridView.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.unitOfMeasureDTOCustomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.unitOfMeasureDTOCustomDataGridView.AutoGenerateColumns = false;
            this.unitOfMeasureDTOCustomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitOfMeasureDTOCustomDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.unitOfMeasureDTOCustomDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.unitOfMeasureDTOCustomDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitOfMeasureDTOCustomDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitOfMeasureDTOCustomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.unitOfMeasureDTOCustomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitOfMeasureDTOCustomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.unitOfMeasureDTOCustomDataGridView.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.unitOfMeasureDTOCustomDataGridView.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.unitOfMeasureDTOCustomDataGridView.CustomRowFontStyle = new System.Drawing.Font("Poppins", 8F);
            this.unitOfMeasureDTOCustomDataGridView.DataSource = this.unitOfMeasureDTOBindingSource;
            this.unitOfMeasureDTOCustomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitOfMeasureDTOCustomDataGridView.EnableHeadersVisualStyles = false;
            this.unitOfMeasureDTOCustomDataGridView.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.unitOfMeasureDTOCustomDataGridView.Location = new System.Drawing.Point(0, 41);
            this.unitOfMeasureDTOCustomDataGridView.Name = "unitOfMeasureDTOCustomDataGridView";
            this.unitOfMeasureDTOCustomDataGridView.ReadOnly = true;
            this.unitOfMeasureDTOCustomDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitOfMeasureDTOCustomDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.unitOfMeasureDTOCustomDataGridView.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.unitOfMeasureDTOCustomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unitOfMeasureDTOCustomDataGridView.Size = new System.Drawing.Size(662, 251);
            this.unitOfMeasureDTOCustomDataGridView.TabIndex = 4;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitOfMeasure";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitOfMeasure";
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
            // FrmUnitOfMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Name = "FrmUnitOfMeasure";
            this.Text = "FrmUnitOfMeasure";
            this.PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDTOCustomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.FerCONTROLS.CustomDataGridView unitOfMeasureDTOCustomDataGridView;
        private System.Windows.Forms.BindingSource unitOfMeasureDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}