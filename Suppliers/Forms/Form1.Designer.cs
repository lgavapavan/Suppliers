namespace Suppliers
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNewCompany = new System.Windows.Forms.Label();
            this.lblNewSupplier = new System.Windows.Forms.Label();
            this.picNewSupplier = new System.Windows.Forms.PictureBox();
            this.picNewCompany = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompaniesList = new System.Windows.Forms.Label();
            this.picCompaniesList = new System.Windows.Forms.PictureBox();
            this.lblSuppliersList = new System.Windows.Forms.Label();
            this.picSuppliersList = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewCompany)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompaniesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuppliersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewCompany
            // 
            this.lblNewCompany.AutoSize = true;
            this.lblNewCompany.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblNewCompany.Location = new System.Drawing.Point(35, 64);
            this.lblNewCompany.Name = "lblNewCompany";
            this.lblNewCompany.Size = new System.Drawing.Size(135, 24);
            this.lblNewCompany.TabIndex = 0;
            this.lblNewCompany.Text = "New Company";
            // 
            // lblNewSupplier
            // 
            this.lblNewSupplier.AutoSize = true;
            this.lblNewSupplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblNewSupplier.Location = new System.Drawing.Point(35, 137);
            this.lblNewSupplier.Name = "lblNewSupplier";
            this.lblNewSupplier.Size = new System.Drawing.Size(124, 24);
            this.lblNewSupplier.TabIndex = 1;
            this.lblNewSupplier.Text = "New Supplier";
            // 
            // picNewSupplier
            // 
            this.picNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("picNewSupplier.Image")));
            this.picNewSupplier.Location = new System.Drawing.Point(184, 124);
            this.picNewSupplier.Name = "picNewSupplier";
            this.picNewSupplier.Size = new System.Drawing.Size(67, 50);
            this.picNewSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewSupplier.TabIndex = 7;
            this.picNewSupplier.TabStop = false;
            this.picNewSupplier.Click += new System.EventHandler(this.picNewSupplier_Click);
            // 
            // picNewCompany
            // 
            this.picNewCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNewCompany.Image = ((System.Drawing.Image)(resources.GetObject("picNewCompany.Image")));
            this.picNewCompany.Location = new System.Drawing.Point(184, 51);
            this.picNewCompany.Name = "picNewCompany";
            this.picNewCompany.Size = new System.Drawing.Size(67, 50);
            this.picNewCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewCompany.TabIndex = 8;
            this.picNewCompany.TabStop = false;
            this.picNewCompany.Click += new System.EventHandler(this.picNewCompany_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.lblCompaniesList);
            this.panel1.Controls.Add(this.picCompaniesList);
            this.panel1.Controls.Add(this.lblSuppliersList);
            this.panel1.Controls.Add(this.picSuppliersList);
            this.panel1.Controls.Add(this.lblNewCompany);
            this.panel1.Controls.Add(this.picNewCompany);
            this.panel1.Controls.Add(this.lblNewSupplier);
            this.panel1.Controls.Add(this.picNewSupplier);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 278);
            this.panel1.TabIndex = 9;
            // 
            // lblCompaniesList
            // 
            this.lblCompaniesList.AutoSize = true;
            this.lblCompaniesList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCompaniesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCompaniesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblCompaniesList.Location = new System.Drawing.Point(295, 64);
            this.lblCompaniesList.Name = "lblCompaniesList";
            this.lblCompaniesList.Size = new System.Drawing.Size(138, 24);
            this.lblCompaniesList.TabIndex = 12;
            this.lblCompaniesList.Text = "Companies List";
            // 
            // picCompaniesList
            // 
            this.picCompaniesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCompaniesList.Image = ((System.Drawing.Image)(resources.GetObject("picCompaniesList.Image")));
            this.picCompaniesList.Location = new System.Drawing.Point(444, 51);
            this.picCompaniesList.Name = "picCompaniesList";
            this.picCompaniesList.Size = new System.Drawing.Size(67, 50);
            this.picCompaniesList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCompaniesList.TabIndex = 15;
            this.picCompaniesList.TabStop = false;
            this.picCompaniesList.Click += new System.EventHandler(this.picCompaniesList_Click);
            // 
            // lblSuppliersList
            // 
            this.lblSuppliersList.AutoSize = true;
            this.lblSuppliersList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSuppliersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblSuppliersList.Location = new System.Drawing.Point(295, 137);
            this.lblSuppliersList.Name = "lblSuppliersList";
            this.lblSuppliersList.Size = new System.Drawing.Size(121, 24);
            this.lblSuppliersList.TabIndex = 13;
            this.lblSuppliersList.Text = "Suppliers List";
            // 
            // picSuppliersList
            // 
            this.picSuppliersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSuppliersList.Image = ((System.Drawing.Image)(resources.GetObject("picSuppliersList.Image")));
            this.picSuppliersList.Location = new System.Drawing.Point(444, 124);
            this.picSuppliersList.Name = "picSuppliersList";
            this.picSuppliersList.Size = new System.Drawing.Size(67, 50);
            this.picSuppliersList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuppliersList.TabIndex = 14;
            this.picSuppliersList.TabStop = false;
            this.picSuppliersList.Click += new System.EventHandler(this.picSuppliersList_Click);
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(252, 216);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(67, 50);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(570, 278);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picNewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewCompany)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompaniesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuppliersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewCompany;
        private System.Windows.Forms.Label lblNewSupplier;
        private System.Windows.Forms.PictureBox picNewSupplier;
        private System.Windows.Forms.PictureBox picNewCompany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompaniesList;
        private System.Windows.Forms.PictureBox picCompaniesList;
        private System.Windows.Forms.Label lblSuppliersList;
        private System.Windows.Forms.PictureBox picSuppliersList;
        private System.Windows.Forms.PictureBox picExit;
    }
}

