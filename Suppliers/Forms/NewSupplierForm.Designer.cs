﻿namespace Suppliers.Forms
{
    partial class NewSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSupplierForm));
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.comboDocumentType = new System.Windows.Forms.ComboBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.picSavePhone = new System.Windows.Forms.PictureBox();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSavePhone)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDocument.ForeColor = System.Drawing.Color.Black;
            this.lblDocument.Location = new System.Drawing.Point(43, 245);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(97, 24);
            this.lblDocument.TabIndex = 13;
            this.lblDocument.Text = "Document";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDocumentType.ForeColor = System.Drawing.Color.Black;
            this.lblDocumentType.Location = new System.Drawing.Point(43, 192);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(145, 24);
            this.lblDocumentType.TabIndex = 12;
            this.lblDocumentType.Text = "Document Type";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierName.Location = new System.Drawing.Point(43, 135);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(136, 24);
            this.lblSupplierName.TabIndex = 11;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // comboDocumentType
            // 
            this.comboDocumentType.DropDownHeight = 60;
            this.comboDocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboDocumentType.FormattingEnabled = true;
            this.comboDocumentType.IntegralHeight = false;
            this.comboDocumentType.Location = new System.Drawing.Point(219, 189);
            this.comboDocumentType.Name = "comboDocumentType";
            this.comboDocumentType.Size = new System.Drawing.Size(129, 32);
            this.comboDocumentType.TabIndex = 2;
            this.comboDocumentType.SelectedIndexChanged += new System.EventHandler(this.comboDocumentType_SelectedIndexChanged);
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(219, 245);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(322, 29);
            this.txtDocument.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(219, 132);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(322, 29);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(42, 84);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(91, 24);
            this.lblCompanyName.TabIndex = 17;
            this.lblCompanyName.Text = "Company";
            // 
            // comboCompany
            // 
            this.comboCompany.DropDownHeight = 60;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.IntegralHeight = false;
            this.comboCompany.Location = new System.Drawing.Point(218, 81);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(322, 32);
            this.comboCompany.TabIndex = 0;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.AllowUserToResizeColumns = false;
            this.dgvPhones.AllowUserToResizeRows = false;
            this.dgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhones.Location = new System.Drawing.Point(12, 421);
            this.dgvPhones.MultiSelect = false;
            this.dgvPhones.Name = "dgvPhones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhones.Size = new System.Drawing.Size(548, 150);
            this.dgvPhones.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(43, 357);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 24);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(285, 357);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // picSavePhone
            // 
            this.picSavePhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSavePhone.Image = ((System.Drawing.Image)(resources.GetObject("picSavePhone.Image")));
            this.picSavePhone.Location = new System.Drawing.Point(454, 345);
            this.picSavePhone.Name = "picSavePhone";
            this.picSavePhone.Size = new System.Drawing.Size(55, 41);
            this.picSavePhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSavePhone.TabIndex = 21;
            this.picSavePhone.TabStop = false;
            this.picSavePhone.Click += new System.EventHandler(this.picSavePhone_Click);
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAreaCode.Location = new System.Drawing.Point(219, 357);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(60, 29);
            this.txtAreaCode.TabIndex = 6;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRg.Location = new System.Drawing.Point(399, 295);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(142, 29);
            this.txtRg.TabIndex = 5;
            this.txtRg.Visible = false;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRg.ForeColor = System.Drawing.Color.Black;
            this.lblRg.Location = new System.Drawing.Point(354, 298);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(37, 24);
            this.lblRg.TabIndex = 24;
            this.lblRg.Text = "RG";
            this.lblRg.Visible = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.Black;
            this.lblBirthDate.Location = new System.Drawing.Point(43, 298);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(90, 24);
            this.lblBirthDate.TabIndex = 26;
            this.lblBirthDate.Text = "Birth Date";
            this.lblBirthDate.Visible = false;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(219, 293);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(129, 29);
            this.dtpBirthDate.TabIndex = 4;
            this.dtpBirthDate.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(224, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(124, 51);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.panelTitle.Controls.Add(this.picClose);
            this.panelTitle.Controls.Add(this.picTitle);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(591, 57);
            this.panelTitle.TabIndex = 30;
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(9, 6);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(59, 47);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 19;
            this.picTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(81, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "New Supplier";
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(534, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 31;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // NewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(591, 665);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.picSavePhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.comboDocumentType);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCompanyName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSupplierForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewSupplierForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSavePhone)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.ComboBox comboDocumentType;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox picSavePhone;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picClose;
    }
}