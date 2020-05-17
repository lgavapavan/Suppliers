using Suppliers.Entities;
using Suppliers.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliers.Forms
{
    public partial class SuppliersListForm : Form
    {
        internal List<Supplier> Suppliers { get; set; }
        internal List<IndividualEntity> IndividualEntities { get; set; }

        internal SuppliersListForm(List<Supplier> suppliers, List<IndividualEntity> individualEntities)
        {
            InitializeComponent();
            this.Suppliers = suppliers;
            this.IndividualEntities = individualEntities;
        }

        private void SuppliersListForm_Load(object sender, EventArgs e)
        {
            if (this.Suppliers != null)
            {
                dgvSuppliers.DataSource = LoadSuppliersList();
            }
            if (this.IndividualEntities != null)
            {
                dgvIndividualSuppliers.DataSource = LoadIndividualSuppliersList();
            }
        }

        private DataTable LoadSuppliersList()
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Supplier's Company", typeof(string));
            dt.Columns.Add("Company", typeof(string));
            dt.Columns.Add("Document Type", typeof(string));
            dt.Columns.Add("Document", typeof(string));
            dt.Columns.Add("Date Saved", typeof(DateTime));
            dt.Columns.Add("Area Code", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            List<Supplier> suppliers = this.Suppliers;
            if (suppliers != null)
            {
                for (int i = 0; i <= this.Suppliers.Count - 1; i++)
                {
                    foreach (var item in this.Suppliers[i].Phones)
                    {

                        DataRow dr = dt.NewRow();
                        dr["Supplier's Company"] = this.Suppliers[i].Name;
                        dr["Company"] = this.Suppliers[i].Company.CompanyName;
                        dr["Document Type"] = DocumentTypes.CNPJ.ToString();
                        dr["Document"] = this.Suppliers[i].Documents[0].DocumentNumber;
                        dr["Date Saved"] = this.Suppliers[i].DateSaved;
                        dr["Area Code"] = item.AreaCode;
                        dr["Phone"] = item.Number;
                        dt.Rows.Add(dr);
                    }
                }
            }

            return dt;
        }

        private DataTable LoadIndividualSuppliersList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Supplier's Company", typeof(string));
            dt.Columns.Add("Company", typeof(string));
            dt.Columns.Add("Document Type", typeof(string));
            dt.Columns.Add("Document", typeof(string));
            dt.Columns.Add("RG", typeof(string));
            dt.Columns.Add("Birth Date", typeof(DateTime));
            dt.Columns.Add("Date Saved", typeof(DateTime));
            dt.Columns.Add("Area Code", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            List<IndividualEntity> individualEntities = this.IndividualEntities;
            if (individualEntities != null)
            {
                for (int i = 0; i <= this.IndividualEntities.Count - 1; i++)
                {
                    foreach (var item in this.IndividualEntities[i].Phones)
                    {
                        DataRow dr = dt.NewRow();

                        dr["Supplier's Company"] = this.IndividualEntities[i].Name;
                        dr["Company"] = this.IndividualEntities[i].Company.CompanyName;
                        dr["Document Type"] = DocumentTypes.CPF.ToString();
                
                        foreach (var document in this.IndividualEntities[i].Documents)
                        {
                            if (document.DocumentType == DocumentTypes.CPF)
                            {
                                dr["Document"] = document.DocumentNumber;
                            }
                            else if (document.DocumentType == DocumentTypes.RG)
                            {
                                dr["RG"] = document.DocumentNumber;
                            }
                        }

                        dr["Birth Date"] = this.IndividualEntities[i].BirthDate.Date;
                        dr["Date Saved"] = this.IndividualEntities[i].DateSaved;
                        dr["Area Code"] = item.AreaCode;
                        dr["Phone"] = item.Number;

                        dt.Rows.Add(dr);
                    }
                }
            }

            return dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private DataTable SearchIndividualSupplierByDate()
        {
            DataTable dtIndividualSupplier = new DataTable();
            dtIndividualSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Document Type", typeof(string));
            dtIndividualSupplier.Columns.Add("Document", typeof(string));
            dtIndividualSupplier.Columns.Add("RG", typeof(string));
            dtIndividualSupplier.Columns.Add("Birth Date", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Area Code", typeof(string));
            dtIndividualSupplier.Columns.Add("Phone", typeof(string));

            List<IndividualEntity> individualEntities = this.IndividualEntities;
            if (individualEntities != null)
            {
                foreach (var entity in individualEntities)
                {
                    if (entity.DateSaved.Date == dtpDateSaved.Value.Date)
                    {
                        foreach (var phone in entity.Phones)
                        {
                            DataRow dr = dtIndividualSupplier.NewRow();

                            dr["Supplier's Company"] = entity.Name;
                            dr["Company"] = entity.Company.CompanyName;
                            dr["Document Type"] = DocumentTypes.CPF.ToString();

                            foreach (var document in entity.Documents)
                            {
                                if (document.DocumentType == DocumentTypes.CPF)
                                {
                                    dr["Document"] = document.DocumentNumber;
                                }
                                else if (document.DocumentType == DocumentTypes.RG)
                                {
                                    dr["RG"] = document.DocumentNumber;
                                }
                            }

                            dr["Birth Date"] = entity.BirthDate.Date;
                            dr["Date Saved"] = entity.DateSaved;

                            dr["Area Code"] = phone.AreaCode;
                            dr["Phone"] = phone.Number;

                            dtIndividualSupplier.Rows.Add(dr);
                        }
                    }
                }
            }
            return dtIndividualSupplier;
        }
        
        private DataTable SearchLegalSupplierByDate()
        {
            DataTable dtLegalSupplier = new DataTable();

            dtLegalSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtLegalSupplier.Columns.Add("Company", typeof(string));
            dtLegalSupplier.Columns.Add("Document Type", typeof(string));
            dtLegalSupplier.Columns.Add("Document", typeof(string));
            dtLegalSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtLegalSupplier.Columns.Add("Area Code", typeof(string));
            dtLegalSupplier.Columns.Add("Phone", typeof(string));

            List<Supplier> suppliers = this.Suppliers;
            if (suppliers != null)
            {
                foreach (var entity in suppliers)
                {
                    if (entity.DateSaved.Date == dtpDateSaved.Value.Date)
                    {
                        foreach (var phone in entity.Phones)
                        {

                            DataRow dr = dtLegalSupplier.NewRow();
                            dr["Supplier's Company"] = entity.Name;
                            dr["Company"] = entity.Company.CompanyName;
                            dr["Document Type"] = DocumentTypes.CNPJ.ToString();
                            dr["Document"] = entity.Documents[0].DocumentNumber;
                            dr["Date Saved"] = entity.DateSaved;
                            dr["Area Code"] = phone.AreaCode;
                            dr["Phone"] = phone.Number;
                            dtLegalSupplier.Rows.Add(dr);
                        }
                    }
                }
            }
            return dtLegalSupplier;
        }

        private DataTable SearchIndividualSupplierByName()
        {
            DataTable dtIndividualSupplier = new DataTable();
            dtIndividualSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Document Type", typeof(string));
            dtIndividualSupplier.Columns.Add("Document", typeof(string));
            dtIndividualSupplier.Columns.Add("RG", typeof(string));
            dtIndividualSupplier.Columns.Add("Birth Date", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Area Code", typeof(string));
            dtIndividualSupplier.Columns.Add("Phone", typeof(string));

            List<IndividualEntity> individualEntities = this.IndividualEntities;
            if (individualEntities != null)
            {
                foreach (var entity in individualEntities)
                {
                    if (entity.Name.ToString().ToLower().Contains(txtSupplierName.Text.ToLower()))
                    {
                        foreach (var phone in entity.Phones)
                        {
                            DataRow dr = dtIndividualSupplier.NewRow();

                            dr["Supplier's Company"] = entity.Name;
                            dr["Company"] = entity.Company.CompanyName;
                            dr["Document Type"] = DocumentTypes.CPF.ToString();

                            foreach (var document in entity.Documents)
                            {
                                if (document.DocumentType == DocumentTypes.CPF)
                                {
                                    dr["Document"] = document.DocumentNumber;
                                }
                                else if (document.DocumentType == DocumentTypes.RG)
                                {
                                    dr["RG"] = document.DocumentNumber;
                                }
                            }

                            dr["Birth Date"] = entity.BirthDate.Date;
                            dr["Date Saved"] = entity.DateSaved;

                            dr["Area Code"] = phone.AreaCode;
                            dr["Phone"] = phone.Number;

                            dtIndividualSupplier.Rows.Add(dr);
                        }
                    }
                }
            }
            return dtIndividualSupplier;
        }
        
        private DataTable SearchLegalSupplierByName()
        {
            DataTable dtLegalSupplier = new DataTable();

            dtLegalSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtLegalSupplier.Columns.Add("Company", typeof(string));
            dtLegalSupplier.Columns.Add("Document Type", typeof(string));
            dtLegalSupplier.Columns.Add("Document", typeof(string));
            dtLegalSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtLegalSupplier.Columns.Add("Area Code", typeof(string));
            dtLegalSupplier.Columns.Add("Phone", typeof(string));

            List<Supplier> suppliers = this.Suppliers;
            if (suppliers != null)
            {
                foreach (var entity in suppliers)
                {
                    if (entity.Name.ToString().ToLower().Contains(txtSupplierName.Text.ToLower()))
                    {
                        foreach (var phone in entity.Phones)
                        {

                            DataRow dr = dtLegalSupplier.NewRow();
                            dr["Supplier's Company"] = entity.Name;
                            dr["Company"] = entity.Company.CompanyName;
                            dr["Document Type"] = DocumentTypes.CNPJ.ToString();
                            dr["Document"] = entity.Documents[0].DocumentNumber;
                            dr["Date Saved"] = entity.DateSaved;
                            dr["Area Code"] = phone.AreaCode;
                            dr["Phone"] = phone.Number;
                            dtLegalSupplier.Rows.Add(dr);
                        }
                    }
                }
            }
            return dtLegalSupplier;
        }
        private DataTable SearchIndividualSupplierByDocument()
        {
            DataTable dtIndividualSupplier = new DataTable();
            dtIndividualSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Company", typeof(string));
            dtIndividualSupplier.Columns.Add("Document Type", typeof(string));
            dtIndividualSupplier.Columns.Add("Document", typeof(string));
            dtIndividualSupplier.Columns.Add("RG", typeof(string));
            dtIndividualSupplier.Columns.Add("Birth Date", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtIndividualSupplier.Columns.Add("Area Code", typeof(string));
            dtIndividualSupplier.Columns.Add("Phone", typeof(string));

            List<IndividualEntity> individualEntities = this.IndividualEntities;
            if (individualEntities != null)
            {
                foreach (var entity in individualEntities)
                {
                    foreach (var document in entity.Documents)
                    {
                        string docNumber = Regex.Replace(document.DocumentNumber.ToString(), "[^0-9a-zA-Z]", "");
                        string searchDocNumber = Regex.Replace(txtDocument.Text, "[^0-9a-zA-Z]", "");
                        if (docNumber.Contains(searchDocNumber))
                        {
                            foreach (var phone in entity.Phones)
                            {
                                DataRow dr = dtIndividualSupplier.NewRow();

                                dr["Supplier's Company"] = entity.Name;
                                dr["Company"] = entity.Company.CompanyName;
                                dr["Document Type"] = DocumentTypes.CPF.ToString();

                                foreach (var item in entity.Documents)
                                {
                                    if (item.DocumentType == DocumentTypes.CPF)
                                    {
                                        dr["Document"] = item.DocumentNumber;
                                    }
                                    else if (item.DocumentType == DocumentTypes.RG)
                                    {
                                        dr["RG"] = item.DocumentNumber;
                                    }
                                }

                                dr["Birth Date"] = entity.BirthDate.Date;
                                dr["Date Saved"] = entity.DateSaved;

                                dr["Area Code"] = phone.AreaCode;
                                dr["Phone"] = phone.Number;

                                dtIndividualSupplier.Rows.Add(dr);
                            }
                            break;
                        }
                        
                    }
                }
            }
            return dtIndividualSupplier;
        }
        
        private DataTable SearchLegalSupplierByDocument()
        {
            DataTable dtLegalSupplier = new DataTable();

            dtLegalSupplier.Columns.Add("Supplier's Company", typeof(string));
            dtLegalSupplier.Columns.Add("Company", typeof(string));
            dtLegalSupplier.Columns.Add("Document Type", typeof(string));
            dtLegalSupplier.Columns.Add("Document", typeof(string));
            dtLegalSupplier.Columns.Add("Date Saved", typeof(DateTime));
            dtLegalSupplier.Columns.Add("Area Code", typeof(string));
            dtLegalSupplier.Columns.Add("Phone", typeof(string));

            List<Supplier> suppliers = this.Suppliers;
            if (suppliers != null)
            {
                foreach (var entity in suppliers)
                {
                    string docNumber = Regex.Replace(entity.Documents[0].DocumentNumber.ToString(), "[^0-9a-zA-Z]", "");
                    string searchDocNumber = Regex.Replace(txtDocument.Text, "[^0-9a-zA-Z]", "");
                    if (docNumber.Contains(searchDocNumber))
                    {
                        foreach (var phone in entity.Phones)
                        {

                            DataRow dr = dtLegalSupplier.NewRow();
                            dr["Supplier's Company"] = entity.Name;
                            dr["Company"] = entity.Company.CompanyName;
                            dr["Document Type"] = DocumentTypes.CNPJ.ToString();
                            dr["Document"] = entity.Documents[0].DocumentNumber;
                            dr["Date Saved"] = entity.DateSaved;
                            dr["Area Code"] = phone.AreaCode;
                            dr["Phone"] = phone.Number;
                            dtLegalSupplier.Rows.Add(dr);
                        }
                    }
                }
            }
            return dtLegalSupplier;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
            txtDocument.Clear();
            txtSupplierName.Clear();
        }

        private void txtSupplierName_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void txtDocument_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }
        private void dtpDateSaved_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (radioFilterByDate.Checked)
            {
                dgvIndividualSuppliers.DataSource = null;
                dgvIndividualSuppliers.Refresh();
                dgvIndividualSuppliers.DataSource = SearchIndividualSupplierByDate();

                dgvSuppliers.DataSource = null;
                dgvSuppliers.Refresh();
                dgvSuppliers.DataSource = SearchLegalSupplierByDate();

            }
            else if (radioFilterBySupplierName.Checked)
            {
                dgvIndividualSuppliers.DataSource = null;
                dgvIndividualSuppliers.Refresh();
                dgvIndividualSuppliers.DataSource = SearchIndividualSupplierByName();

                dgvSuppliers.DataSource = null;
                dgvSuppliers.Refresh();
                dgvSuppliers.DataSource = SearchLegalSupplierByName();

            }
            else if (radioFilterByDocument.Checked)
            {
                dgvIndividualSuppliers.DataSource = null;
                dgvIndividualSuppliers.Refresh();
                dgvIndividualSuppliers.DataSource = SearchIndividualSupplierByDocument();

                dgvSuppliers.DataSource = null;
                dgvSuppliers.Refresh();
                dgvSuppliers.DataSource = SearchLegalSupplierByDocument();

            }
        }

        private void ClearFilters()
        {
            dgvIndividualSuppliers.DataSource = null;
            dgvIndividualSuppliers.Refresh();
            dgvIndividualSuppliers.DataSource = LoadIndividualSuppliersList();

            dgvSuppliers.DataSource = null;
            dgvSuppliers.Refresh();
            dgvSuppliers.DataSource = LoadSuppliersList();
        }

        private void radioFilterByDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFilterByDocument.Checked == false)
            {
                txtDocument.Enabled = false;
                txtDocument.Clear();
            }
            else
            {
                txtDocument.Enabled = true;
            }
        }

        private void radioFilterBySupplierName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFilterBySupplierName.Checked == false)
            {
                txtSupplierName.Enabled = false;
                txtSupplierName.Clear();
            }
            else
            {
                txtSupplierName.Enabled = true;
            }
        }

        private void radioFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFilterByDate.Checked == false)
            {
                dtpDateSaved.Enabled = false;
            }
            else
            {
                dtpDateSaved.Enabled = true;
            }
        }
    }
}
