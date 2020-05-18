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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.btnSuppliersList = new System.Windows.Forms.Button();
            this.btnCompaniesList = new System.Windows.Forms.Button();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCompaniesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSuppliersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNewSupplier);
            this.panel1.Controls.Add(this.btnSuppliersList);
            this.panel1.Controls.Add(this.btnCompaniesList);
            this.panel1.Controls.Add(this.btnNewCompany);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 340);
            this.panel1.TabIndex = 9;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(143)))));
            this.btnNewSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewSupplier.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSupplier.Image")));
            this.btnNewSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSupplier.Location = new System.Drawing.Point(21, 222);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnNewSupplier.Size = new System.Drawing.Size(220, 73);
            this.btnNewSupplier.TabIndex = 27;
            this.btnNewSupplier.Text = "New Suppliers";
            this.btnNewSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSupplier.UseVisualStyleBackColor = false;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // btnSuppliersList
            // 
            this.btnSuppliersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(143)))));
            this.btnSuppliersList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuppliersList.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliersList.ForeColor = System.Drawing.Color.White;
            this.btnSuppliersList.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliersList.Image")));
            this.btnSuppliersList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppliersList.Location = new System.Drawing.Point(343, 222);
            this.btnSuppliersList.Name = "btnSuppliersList";
            this.btnSuppliersList.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnSuppliersList.Size = new System.Drawing.Size(220, 73);
            this.btnSuppliersList.TabIndex = 26;
            this.btnSuppliersList.Text = "Suppliers List";
            this.btnSuppliersList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliersList.UseVisualStyleBackColor = false;
            this.btnSuppliersList.Click += new System.EventHandler(this.btnSuppliersList_Click);
            // 
            // btnCompaniesList
            // 
            this.btnCompaniesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(143)))));
            this.btnCompaniesList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCompaniesList.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompaniesList.ForeColor = System.Drawing.Color.White;
            this.btnCompaniesList.Image = ((System.Drawing.Image)(resources.GetObject("btnCompaniesList.Image")));
            this.btnCompaniesList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompaniesList.Location = new System.Drawing.Point(343, 129);
            this.btnCompaniesList.Name = "btnCompaniesList";
            this.btnCompaniesList.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnCompaniesList.Size = new System.Drawing.Size(220, 73);
            this.btnCompaniesList.TabIndex = 25;
            this.btnCompaniesList.Text = "Companies List";
            this.btnCompaniesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompaniesList.UseVisualStyleBackColor = false;
            this.btnCompaniesList.Click += new System.EventHandler(this.btnCompaniesList_Click);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(143)))));
            this.btnNewCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewCompany.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompany.ForeColor = System.Drawing.Color.White;
            this.btnNewCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCompany.Image")));
            this.btnNewCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCompany.Location = new System.Drawing.Point(21, 129);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnNewCompany.Size = new System.Drawing.Size(220, 73);
            this.btnNewCompany.TabIndex = 24;
            this.btnNewCompany.Text = "New Company";
            this.btnNewCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCompany.UseVisualStyleBackColor = false;
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(156, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Suppliers List Software";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(551, -2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(44, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companiesToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.companiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNewCompanyToolStripMenuItem,
            this.openCompaniesListToolStripMenuItem});
            this.companiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.companiesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.companiesToolStripMenuItem.Text = "Companies";
            // 
            // saveNewCompanyToolStripMenuItem
            // 
            this.saveNewCompanyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.saveNewCompanyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.saveNewCompanyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.saveNewCompanyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveNewCompanyToolStripMenuItem.Image")));
            this.saveNewCompanyToolStripMenuItem.Name = "saveNewCompanyToolStripMenuItem";
            this.saveNewCompanyToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.saveNewCompanyToolStripMenuItem.Text = "Save new company";
            this.saveNewCompanyToolStripMenuItem.Click += new System.EventHandler(this.saveNewCompanyToolStripMenuItem_Click);
            // 
            // openCompaniesListToolStripMenuItem
            // 
            this.openCompaniesListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.openCompaniesListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.openCompaniesListToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.openCompaniesListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openCompaniesListToolStripMenuItem.Image")));
            this.openCompaniesListToolStripMenuItem.Name = "openCompaniesListToolStripMenuItem";
            this.openCompaniesListToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.openCompaniesListToolStripMenuItem.Text = "Open companies list";
            this.openCompaniesListToolStripMenuItem.Click += new System.EventHandler(this.openCompaniesListToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNewSupplierToolStripMenuItem,
            this.openSuppliersListToolStripMenuItem});
            this.suppliersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.suppliersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // saveNewSupplierToolStripMenuItem
            // 
            this.saveNewSupplierToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.saveNewSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.saveNewSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveNewSupplierToolStripMenuItem.Image")));
            this.saveNewSupplierToolStripMenuItem.Name = "saveNewSupplierToolStripMenuItem";
            this.saveNewSupplierToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.saveNewSupplierToolStripMenuItem.Text = "Save new supplier";
            this.saveNewSupplierToolStripMenuItem.Click += new System.EventHandler(this.saveNewSupplierToolStripMenuItem_Click);
            // 
            // openSuppliersListToolStripMenuItem
            // 
            this.openSuppliersListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.openSuppliersListToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.openSuppliersListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openSuppliersListToolStripMenuItem.Image")));
            this.openSuppliersListToolStripMenuItem.Name = "openSuppliersListToolStripMenuItem";
            this.openSuppliersListToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.openSuppliersListToolStripMenuItem.Text = "Open suppliers list";
            this.openSuppliersListToolStripMenuItem.Click += new System.EventHandler(this.openSuppliersListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(596, 340);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNewCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCompaniesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSuppliersListToolStripMenuItem;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.Button btnCompaniesList;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.Button btnSuppliersList;
    }
}

