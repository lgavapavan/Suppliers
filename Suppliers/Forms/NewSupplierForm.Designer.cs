namespace Suppliers.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSupplierForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSaveCompany = new System.Windows.Forms.Label();
            this.picSaveSupplier = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picSaveSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSavePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaveCompany
            // 
            this.lblSaveCompany.AutoSize = true;
            this.lblSaveCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSaveCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblSaveCompany.Location = new System.Drawing.Point(206, 610);
            this.lblSaveCompany.Name = "lblSaveCompany";
            this.lblSaveCompany.Size = new System.Drawing.Size(52, 24);
            this.lblSaveCompany.TabIndex = 15;
            this.lblSaveCompany.Text = "Save";
            // 
            // picSaveSupplier
            // 
            this.picSaveSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSaveSupplier.Image = ((System.Drawing.Image)(resources.GetObject("picSaveSupplier.Image")));
            this.picSaveSupplier.Location = new System.Drawing.Point(264, 604);
            this.picSaveSupplier.Name = "picSaveSupplier";
            this.picSaveSupplier.Size = new System.Drawing.Size(55, 41);
            this.picSaveSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveSupplier.TabIndex = 14;
            this.picSaveSupplier.TabStop = false;
            this.picSaveSupplier.Click += new System.EventHandler(this.picSaveSupplier_Click);
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblDocument.Location = new System.Drawing.Point(43, 234);
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
            this.lblDocumentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblDocumentType.Location = new System.Drawing.Point(43, 181);
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
            this.lblSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblSupplierName.Location = new System.Drawing.Point(43, 124);
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
            this.comboDocumentType.Location = new System.Drawing.Point(219, 178);
            this.comboDocumentType.Name = "comboDocumentType";
            this.comboDocumentType.Size = new System.Drawing.Size(129, 32);
            this.comboDocumentType.TabIndex = 2;
            this.comboDocumentType.SelectedIndexChanged += new System.EventHandler(this.comboDocumentType_SelectedIndexChanged);
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(219, 234);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(322, 29);
            this.txtDocument.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(219, 121);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(322, 29);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblCompanyName.Location = new System.Drawing.Point(42, 73);
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
            this.comboCompany.Location = new System.Drawing.Point(218, 70);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhones.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPhones.Location = new System.Drawing.Point(12, 410);
            this.dgvPhones.MultiSelect = false;
            this.dgvPhones.Name = "dgvPhones";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhones.Size = new System.Drawing.Size(548, 150);
            this.dgvPhones.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblPhone.Location = new System.Drawing.Point(43, 346);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 24);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(285, 346);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // picSavePhone
            // 
            this.picSavePhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSavePhone.Image = ((System.Drawing.Image)(resources.GetObject("picSavePhone.Image")));
            this.picSavePhone.Location = new System.Drawing.Point(454, 334);
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
            this.txtAreaCode.Location = new System.Drawing.Point(219, 346);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(60, 29);
            this.txtAreaCode.TabIndex = 6;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRg.Location = new System.Drawing.Point(399, 284);
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
            this.lblRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblRg.Location = new System.Drawing.Point(354, 287);
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
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblBirthDate.Location = new System.Drawing.Point(43, 287);
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
            this.dtpBirthDate.Location = new System.Drawing.Point(219, 282);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(129, 29);
            this.dtpBirthDate.TabIndex = 4;
            this.dtpBirthDate.Visible = false;
            // 
            // NewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(572, 651);
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
            this.Controls.Add(this.lblSaveCompany);
            this.Controls.Add(this.picSaveSupplier);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.comboDocumentType);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "NewSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSupplierForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewSupplierForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picSaveSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSavePhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaveCompany;
        private System.Windows.Forms.PictureBox picSaveSupplier;
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
    }
}