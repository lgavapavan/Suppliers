namespace Suppliers.Forms
{
    partial class NewCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCompanyForm));
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.comboFederativeUnit = new System.Windows.Forms.ComboBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblFederativeUnit = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.picSaveCompany = new System.Windows.Forms.PictureBox();
            this.lblSaveCompany = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(219, 73);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(281, 29);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(219, 133);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(281, 29);
            this.txtDocument.TabIndex = 1;
            // 
            // comboFederativeUnit
            // 
            this.comboFederativeUnit.DropDownHeight = 90;
            this.comboFederativeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboFederativeUnit.FormattingEnabled = true;
            this.comboFederativeUnit.IntegralHeight = false;
            this.comboFederativeUnit.ItemHeight = 24;
            this.comboFederativeUnit.Location = new System.Drawing.Point(219, 187);
            this.comboFederativeUnit.Name = "comboFederativeUnit";
            this.comboFederativeUnit.Size = new System.Drawing.Size(100, 32);
            this.comboFederativeUnit.TabIndex = 2;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblCompanyName.Location = new System.Drawing.Point(43, 76);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(147, 24);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblFederativeUnit
            // 
            this.lblFederativeUnit.AutoSize = true;
            this.lblFederativeUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFederativeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFederativeUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblFederativeUnit.Location = new System.Drawing.Point(43, 190);
            this.lblFederativeUnit.Name = "lblFederativeUnit";
            this.lblFederativeUnit.Size = new System.Drawing.Size(136, 24);
            this.lblFederativeUnit.TabIndex = 4;
            this.lblFederativeUnit.Text = "Federative Unit";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblDocument.Location = new System.Drawing.Point(43, 133);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(171, 24);
            this.lblDocument.TabIndex = 5;
            this.lblDocument.Text = "Document Number";
            // 
            // picSaveCompany
            // 
            this.picSaveCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSaveCompany.Image = ((System.Drawing.Image)(resources.GetObject("picSaveCompany.Image")));
            this.picSaveCompany.Location = new System.Drawing.Point(261, 310);
            this.picSaveCompany.Name = "picSaveCompany";
            this.picSaveCompany.Size = new System.Drawing.Size(55, 41);
            this.picSaveCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveCompany.TabIndex = 6;
            this.picSaveCompany.TabStop = false;
            this.picSaveCompany.Click += new System.EventHandler(this.picSaveCompany_Click);
            // 
            // lblSaveCompany
            // 
            this.lblSaveCompany.AutoSize = true;
            this.lblSaveCompany.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSaveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSaveCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblSaveCompany.Location = new System.Drawing.Point(203, 316);
            this.lblSaveCompany.Name = "lblSaveCompany";
            this.lblSaveCompany.Size = new System.Drawing.Size(52, 24);
            this.lblSaveCompany.TabIndex = 7;
            this.lblSaveCompany.Text = "Save";
            // 
            // NewCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(538, 368);
            this.Controls.Add(this.lblSaveCompany);
            this.Controls.Add(this.picSaveCompany);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblFederativeUnit);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.comboFederativeUnit);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "NewCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCompanyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCompanyForm_FormClosed);
            this.Load += new System.EventHandler(this.NewCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSaveCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.ComboBox comboFederativeUnit;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblFederativeUnit;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.PictureBox picSaveCompany;
        private System.Windows.Forms.Label lblSaveCompany;
    }
}