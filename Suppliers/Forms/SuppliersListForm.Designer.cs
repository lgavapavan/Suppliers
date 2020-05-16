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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualSuppliers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppliersList
            // 
            this.lblSuppliersList.AutoSize = true;
            this.lblSuppliersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSuppliersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblSuppliersList.Location = new System.Drawing.Point(12, 89);
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
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 116);
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
            this.dgvSuppliers.Size = new System.Drawing.Size(1227, 166);
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
            this.dgvIndividualSuppliers.Location = new System.Drawing.Point(12, 321);
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
            this.dgvIndividualSuppliers.Size = new System.Drawing.Size(1227, 166);
            this.dgvIndividualSuppliers.TabIndex = 20;
            // 
            // lblIndividualEntitySuppliers
            // 
            this.lblIndividualEntitySuppliers.AutoSize = true;
            this.lblIndividualEntitySuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIndividualEntitySuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblIndividualEntitySuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblIndividualEntitySuppliers.Location = new System.Drawing.Point(12, 294);
            this.lblIndividualEntitySuppliers.Name = "lblIndividualEntitySuppliers";
            this.lblIndividualEntitySuppliers.Size = new System.Drawing.Size(223, 24);
            this.lblIndividualEntitySuppliers.TabIndex = 21;
            this.lblIndividualEntitySuppliers.Text = "Individual Entity Suppliers";
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblFilters.Location = new System.Drawing.Point(50, 29);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(82, 29);
            this.lblFilters.TabIndex = 22;
            this.lblFilters.Text = "Filters";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSupplierName.Location = new System.Drawing.Point(488, 8);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(158, 29);
            this.txtSupplierName.TabIndex = 26;
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(488, 44);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(158, 29);
            this.txtDocument.TabIndex = 27;
            // 
            // dtpDateSaved
            // 
            this.dtpDateSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateSaved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSaved.Location = new System.Drawing.Point(858, 8);
            this.dtpDateSaved.Name = "dtpDateSaved";
            this.dtpDateSaved.Size = new System.Drawing.Size(129, 29);
            this.dtpDateSaved.TabIndex = 28;
            // 
            // radioFilterByDocument
            // 
            this.radioFilterByDocument.AutoSize = true;
            this.radioFilterByDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.radioFilterByDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.radioFilterByDocument.Location = new System.Drawing.Point(302, 45);
            this.radioFilterByDocument.Name = "radioFilterByDocument";
            this.radioFilterByDocument.Size = new System.Drawing.Size(141, 28);
            this.radioFilterByDocument.TabIndex = 29;
            this.radioFilterByDocument.Text = "By Document";
            this.radioFilterByDocument.UseVisualStyleBackColor = true;
            // 
            // radioFilterBySupplierName
            // 
            this.radioFilterBySupplierName.AutoSize = true;
            this.radioFilterBySupplierName.Checked = true;
            this.radioFilterBySupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.radioFilterBySupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.radioFilterBySupplierName.Location = new System.Drawing.Point(302, 10);
            this.radioFilterBySupplierName.Name = "radioFilterBySupplierName";
            this.radioFilterBySupplierName.Size = new System.Drawing.Size(180, 28);
            this.radioFilterBySupplierName.TabIndex = 30;
            this.radioFilterBySupplierName.TabStop = true;
            this.radioFilterBySupplierName.Text = "By Supplier Name";
            this.radioFilterBySupplierName.UseVisualStyleBackColor = true;
            // 
            // radioFilterByDate
            // 
            this.radioFilterByDate.AutoSize = true;
            this.radioFilterByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.radioFilterByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.radioFilterByDate.Location = new System.Drawing.Point(702, 10);
            this.radioFilterByDate.Name = "radioFilterByDate";
            this.radioFilterByDate.Size = new System.Drawing.Size(150, 28);
            this.radioFilterByDate.TabIndex = 31;
            this.radioFilterByDate.Text = "By Date Saved";
            this.radioFilterByDate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.panel1.Size = new System.Drawing.Size(1251, 86);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(872, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 33);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear filter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSearch.Location = new System.Drawing.Point(702, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 33);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SuppliersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1251, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIndividualEntitySuppliers);
            this.Controls.Add(this.dgvIndividualSuppliers);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.lblSuppliersList);
            this.Name = "SuppliersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliersListForm";
            this.Load += new System.EventHandler(this.SuppliersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualSuppliers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}