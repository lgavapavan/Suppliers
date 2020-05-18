using Suppliers.Entities;
using Suppliers.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliers
{
    public partial class Form1 : Form
    {
        internal List<Company> Companies { get; set; }
        internal List<Supplier> Suppliers { get; set; }
        internal List<IndividualEntity> IndividualEntities { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = lblTitle;
        }
        
        internal Form1(List<Company> companies, List<Supplier> suppliers, List<IndividualEntity> individualEntities)
        {
            InitializeComponent();
            this.ActiveControl = lblTitle;
            this.Companies = companies;
            this.Suppliers = suppliers;
            this.IndividualEntities = individualEntities;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void saveNewCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewCompanyForm(this.Companies, this.Suppliers, this.IndividualEntities);
            form.Show();
            this.Close();
        }

        private void openCompaniesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Companies != null)
            {
                var form = new CompaniesListForm(this.Companies);
                form.Show();
            }
            else
            {
                MessageBox.Show("No companies were added yet.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Companies != null)
            {
                var form = new NewSupplierForm(this.Companies, this.Suppliers, this.IndividualEntities);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to save at least one company before adding suppliers", "No companies were added yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openSuppliersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Suppliers != null || this.IndividualEntities != null)
            {
                var form = new SuppliersListForm(this.Suppliers, this.IndividualEntities);
                form.Show();
            }
            else
            {
                MessageBox.Show("There are no suppliers added yet.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            var form = new NewCompanyForm(this.Companies, this.Suppliers, this.IndividualEntities);
            form.Show();
            this.Close();
        }

        private void btnCompaniesList_Click(object sender, EventArgs e)
        {
            if (this.Companies != null)
            {
                var form = new CompaniesListForm(this.Companies);
                form.Show();
            }
            else
            {
                MessageBox.Show("No companies were added yet.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            if (this.Companies != null)
            {
                var form = new NewSupplierForm(this.Companies, this.Suppliers, this.IndividualEntities);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to save at least one company before adding suppliers", "No companies were added yet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSuppliersList_Click(object sender, EventArgs e)
        {
            if (this.Suppliers != null || this.IndividualEntities != null)
            {
                var form = new SuppliersListForm(this.Suppliers, this.IndividualEntities);
                form.Show();
            }
            else
            {
                MessageBox.Show("There are no suppliers added yet.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
