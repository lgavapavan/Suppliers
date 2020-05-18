namespace Suppliers.Forms
{
    partial class SuppliersListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersListForm));
            this.lblSuppliersList = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.dgvIndividualSuppliers = new System.Windows.Forms.DataGridView();
            this.lblIndividualEntitySuppliers = new System.Windows.Forms.Label();
            this.lblFilters = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.dtpDateSaved = new System.Windows.Forms.DateTimePicker();
            this.radioFilterByDocument = new System.Windows.Forms.RadioButton();
            this.radioFilterBySupplierName = new System.Windows.Forms.RadioButton();
            this.radioFilterByDate = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualSuppliers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppliersList
            // 
            this.lblSuppliersList.AutoSize = true;
            this.lblSuppliersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSuppliersList.ForeColor = System.Drawing.Color.Black;
            this.lblSuppliersList.Location = new System.Drawing.Point(12, 96);
            this.lblSuppliersList.Name = "lblSuppliersList";
            this.lblSuppliersList.Size = new System.Drawing.Size(190, 24);
            this.lblSuppliersList.TabIndex = 12;
            this.lblSuppliersList.Text = "Legal Entity Suppliers";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 123);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.RowTemplate.Height = 30;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(1227, 191);
            this.dgvSuppliers.TabIndex = 19;
            // 
            // dgvIndividualSuppliers
            // 
            this.dgvIndividualSuppliers.AllowUserToAddRows = false;
            this.dgvIndividualSuppliers.AllowUserToDeleteRows = false;
            this.dgvIndividualSuppliers.AllowUserToResizeColumns = false;
            this.dgvIndividualSuppliers.AllowUserToResizeRows = false;
            this.dgvIndividualSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIndividualSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIndividualSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIndividualSuppliers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIndividualSuppliers.Location = new System.Drawing.Point(12, 351);
            this.dgvIndividualSuppliers.MultiSelect = false;
            this.dgvIndividualSuppliers.Name = "dgvIndividualSuppliers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIndividualSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIndividualSuppliers.RowTemplate.Height = 30;
            this.dgvIndividualSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIndividualSuppliers.Size = new System.Drawing.Size(1227, 191);
            this.dgvIndividualSuppliers.TabIndex = 20;
            // 
            // lblIndividualEntitySuppliers
            // 
            this.lblIndividualEntitySuppliers.AutoSize = true;
            this.lblIndividualEntitySuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIndividualEntitySuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblIndividualEntitySuppliers.ForeColor = System.Drawing.Color.Black;
            this.lblIndividualEntitySuppliers.Location = new System.Drawing.Point(12, 324);
            this.lblIndividualEntitySuppliers.Name = "lblIndividualEntitySuppliers";
            this.lblIndividualEntitySuppliers.Size = new System.Drawing.Size(223, 24);
            this.lblIndividualEntitySuppliers.TabIndex = 21;
            this.lblIndividualEntitySuppliers.Text = "Individual Entity Suppliers";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.ForeColor = System.Drawing.Color.White;
            this.lblFilters.Location = new System.Drawing.Point(82, 30);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(76, 30);
            this.lblFilters.TabIndex = 22;
            this.lblFilters.Text = "Filters";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSupplierName.Location = new System.Drawing.Point(649, 9);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(158, 29);
            this.txtSupplierName.TabIndex = 26;
            this.txtSupplierName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplierName_KeyUp);
            // 
            // txtDocument
            // 
            this.txtDocument.Enabled = false;
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(649, 45);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(158, 29);
            this.txtDocument.TabIndex = 27;
            this.txtDocument.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyUp);
            // 
            // dtpDateSaved
            // 
            this.dtpDateSaved.Enabled = false;
            this.dtpDateSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateSaved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSaved.Location = new System.Drawing.Point(1019, 9);
            this.dtpDateSaved.Name = "dtpDateSaved";
            this.dtpDateSaved.Size = new System.Drawing.Size(129, 29);
            this.dtpDateSaved.TabIndex = 28;
            this.dtpDateSaved.ValueChanged += new System.EventHandler(this.dtpDateSaved_ValueChanged);
            // 
            // radioFilterByDocument
            // 
            this.radioFilterByDocument.AutoSize = true;
            this.radioFilterByDocument.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFilterByDocument.ForeColor = System.Drawing.Color.White;
            this.radioFilterByDocument.Location = new System.Drawing.Point(463, 46);
            this.radioFilterByDocument.Name = "radioFilterByDocument";
            this.radioFilterByDocument.Size = new System.Drawing.Size(140, 27);
            this.radioFilterByDocument.TabIndex = 29;
            this.radioFilterByDocument.Text = "By Document";
            this.radioFilterByDocument.UseVisualStyleBackColor = true;
            this.radioFilterByDocument.CheckedChanged += new System.EventHandler(this.radioFilterByDocument_CheckedChanged);
            // 
            // radioFilterBySupplierName
            // 
            this.radioFilterBySupplierName.AutoSize = true;
            this.radioFilterBySupplierName.Checked = true;
            this.radioFilterBySupplierName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFilterBySupplierName.ForeColor = System.Drawing.Color.White;
            this.radioFilterBySupplierName.Location = new System.Drawing.Point(463, 11);
            this.radioFilterBySupplierName.Name = "radioFilterBySupplierName";
            this.radioFilterBySupplierName.Size = new System.Drawing.Size(178, 27);
            this.radioFilterBySupplierName.TabIndex = 30;
            this.radioFilterBySupplierName.TabStop = true;
            this.radioFilterBySupplierName.Text = "By Supplier Name";
            this.radioFilterBySupplierName.UseVisualStyleBackColor = true;
            this.radioFilterBySupplierName.CheckedChanged += new System.EventHandler(this.radioFilterBySupplierName_CheckedChanged);
            // 
            // radioFilterByDate
            // 
            this.radioFilterByDate.AutoSize = true;
            this.radioFilterByDate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFilterByDate.ForeColor = System.Drawing.Color.White;
            this.radioFilterByDate.Location = new System.Drawing.Point(863, 11);
            this.radioFilterByDate.Name = "radioFilterByDate";
            this.radioFilterByDate.Size = new System.Drawing.Size(147, 27);
            this.radioFilterByDate.TabIndex = 31;
            this.radioFilterByDate.Text = "By Date Saved";
            this.radioFilterByDate.UseVisualStyleBackColor = true;
            this.radioFilterByDate.CheckedChanged += new System.EventHandler(this.radioFilterByDate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.picFilter);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.radioFilterByDate);
            this.panel1.Controls.Add(this.lblFilters);
            this.panel1.Controls.Add(this.radioFilterBySupplierName);
            this.panel1.Controls.Add(this.radioFilterByDocument);
            this.panel1.Controls.Add(this.dtpDateSaved);
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.txtDocument);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 86);
            this.panel1.TabIndex = 32;
            // 
            // picFilter
            // 
            this.picFilter.Image = ((System.Drawing.Image)(resources.GetObject("picFilter.Image")));
            this.picFilter.Location = new System.Drawing.Point(12, 10);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(64, 64);
            this.picFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFilter.TabIndex = 34;
            this.picFilter.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(1019, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 33);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear filter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.Location = new System.Drawing.Point(863, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 33);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1184, 18);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 33;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // SuppliersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1254, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIndividualEntitySuppliers);
            this.Controls.Add(this.dgvIndividualSuppliers);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.lblSuppliersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppliersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliersListForm";
            this.Load += new System.EventHandler(this.SuppliersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualSuppliers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuppliersList;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvIndividualSuppliers;
        private System.Windows.Forms.Label lblIndividualEntitySuppliers;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.DateTimePicker dtpDateSaved;
        private System.Windows.Forms.RadioButton radioFilterByDocument;
        private System.Windows.Forms.RadioButton radioFilterBySupplierName;
        private System.Windows.Forms.RadioButton radioFilterByDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picClose;
    }
}