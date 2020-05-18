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
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCompanyName.Location = new System.Drawing.Point(219, 109);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(281, 29);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtDocument
            // 
            this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDocument.Location = new System.Drawing.Point(219, 169);
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
            this.comboFederativeUnit.Location = new System.Drawing.Point(219, 223);
            this.comboFederativeUnit.Name = "comboFederativeUnit";
            this.comboFederativeUnit.Size = new System.Drawing.Size(100, 32);
            this.comboFederativeUnit.TabIndex = 2;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(39, 115);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(145, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblFederativeUnit
            // 
            this.lblFederativeUnit.AutoSize = true;
            this.lblFederativeUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFederativeUnit.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFederativeUnit.ForeColor = System.Drawing.Color.Black;
            this.lblFederativeUnit.Location = new System.Drawing.Point(39, 229);
            this.lblFederativeUnit.Name = "lblFederativeUnit";
            this.lblFederativeUnit.Size = new System.Drawing.Size(137, 23);
            this.lblFederativeUnit.TabIndex = 4;
            this.lblFederativeUnit.Text = "Federative Unit";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocument.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocument.ForeColor = System.Drawing.Color.Black;
            this.lblDocument.Location = new System.Drawing.Point(39, 172);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(171, 23);
            this.lblDocument.TabIndex = 5;
            this.lblDocument.Text = "Document Number";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(205, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(124, 51);
            this.btnSave.TabIndex = 28;
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
            this.panelTitle.Size = new System.Drawing.Size(565, 57);
            this.panelTitle.TabIndex = 29;
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(507, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 48);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 20;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(12, 8);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(57, 45);
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
            this.lblTitle.Location = new System.Drawing.Point(75, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "New Company";
            // 
            // NewCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(565, 368);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDocument);
            this.Controls.Add(this.lblFederativeUnit);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.comboFederativeUnit);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Company";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewCompanyForm_FormClosed);
            this.Load += new System.EventHandler(this.NewCompanyForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picClose;
    }
}