using Suppliers.Entities;
using Suppliers.Entities.Enums;
using Suppliers.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliers.Forms
{
    public partial class NewSupplierForm : Form
    {
        internal List<Company> Companies { get; set; }
        internal List<Supplier> Suppliers { get; set; }
        internal List<IndividualEntity> IndividualEntities { get; set; }
        internal List<Phone> Phones { get; set; }
        internal bool IsIndividualEntity { get; set; } 
        internal Company SelectedCompany { get; set; }
        internal NewSupplierForm(List<Company> companies, List<Supplier> suppliers, List<IndividualEntity> individualEntities)
        {
            InitializeComponent();
            this.Companies = companies;
            this.Suppliers = suppliers;
            this.IndividualEntities = individualEntities;
            this.Phones = new List<Phone>();
            comboDocumentType.Items.Add(DocumentTypes.CNPJ);
            comboDocumentType.Items.Add(DocumentTypes.CPF);
            this.comboCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in this.Companies)
            {
                comboCompany.Items.Add(item.CompanyName);
            }
        }

        private void picSavePhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone(byte.Parse(txtAreaCode.Text), txtPhone.Text);
            this.Phones.Add(phone);
            dgvPhones.DataSource = null;
            txtAreaCode.Clear();
            txtPhone.Clear();
            dgvPhones.DataSource = LoadPhones();
        }

        private IndividualEntity SaveIndividualEntitySupplier()
        {
            IndividualEntity individualSupplier = new IndividualEntity(
                GetCompany(),
                txtCompanyName.Text,
                SaveDocuments(),
                DateTime.Now,
                this.Phones,
                dtpBirthDate.Value
                );

            return individualSupplier;
        }
        private Supplier SaveLegalEntitySupplier()
        {
            Supplier supplier = new Supplier(
                    GetCompany(),
                    txtCompanyName.Text,
                    SaveDocuments(),
                    DateTime.Now,
                    this.Phones
                    );
           
            return supplier;
        }

        private Company GetCompany()
        {
            Company company = new Company();
            for (int i = 0; i <= this.Companies.Count-1; i++)
            {
                if (this.Companies[i].CompanyName == comboCompany.Text)
                {
                    company = this.Companies[i];
                    break;
                }
            }
            return company;
        }
        private DataTable LoadPhones()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Area Code", typeof(string));
            dt.Columns.Add("Phone Number", typeof(string));
            for (int i = 0; i <= this.Phones.Count - 1; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Area Code"] = this.Phones[i].AreaCode;
                dr["Phone Number"] = this.Phones[i].Number;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void comboDocumentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IsIndividualEntity = new bool();
            if (comboDocumentType.SelectedItem.ToString() == DocumentTypes.CPF.ToString())
            {
                lblRg.Visible = true;
                txtRg.Visible = true;
                lblBirthDate.Visible = true;
                dtpBirthDate.Visible = true;
                this.IsIndividualEntity = true;
            }
            else
            {
                lblRg.Visible = false;
                txtRg.Visible = false;
                lblBirthDate.Visible = false;
                dtpBirthDate.Visible = false;
                this.IsIndividualEntity = false;
            }
        }

        private List<Document> SaveDocuments()
        {
            List<Document> documents = new List<Document>();
            if (this.IsIndividualEntity)
            {
                Document cpf = new Document(DocumentTypes.CPF, txtDocument.Text.Trim());
                Document rg = new Document(DocumentTypes.RG, txtRg.Text.Trim());
                documents.Add(cpf);
                documents.Add(rg);
            }
            else
            {
                Document cnpj = new Document(DocumentTypes.CNPJ, txtDocument.Text.Trim());
                documents.Add(cnpj);
            }
            return documents;
        }

        private void NewSupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Form1(this.Companies, this.Suppliers, this.IndividualEntities);
            form.Show();
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Companies)
            {
                if (comboCompany.Text == item.CompanyName)
                {
                    this.SelectedCompany = item;
                }
            }
        }

        private bool ValidateSupplier()
        {
            try
            {
                IsEmpty(txtCompanyName.Text, "Suppliers Name");
                IsEmpty(comboCompany.Text, "Company");
                IsEmpty(comboDocumentType.Text, "Document Type");
                IsEmpty(txtDocument.Text, "Document");
                if (this.IsIndividualEntity)
                {
                    IsEmpty(txtRg.Text, "RG");
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "All fields must be filled to save the supplier.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void IsEmpty(string text, string fieldName)
        {
            if (text.Trim() == "")
            {
                throw new BlankFieldException("The following field is blank: {0}", fieldName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateSupplier())
            {
                if (this.IsIndividualEntity) //If it's an individual entity
                {
                    if (IndividualEntity.IsFromPR(this.SelectedCompany)) //And the company it attends is from PR
                    {
                        if (IndividualEntity.HasLegalAge(dtpBirthDate.Value.Date)) //Check if it is at least 18 y/o
                        {
                            if (this.IndividualEntities != null)
                            {
                                var individualSuppliers = new List<IndividualEntity>(this.IndividualEntities);
                                individualSuppliers.Add(SaveIndividualEntitySupplier());
                                this.IndividualEntities = individualSuppliers;
                                this.Close();
                            }
                            else
                            {
                                var individualSuppliers = new List<IndividualEntity>();
                                individualSuppliers.Add(SaveIndividualEntitySupplier());
                                this.IndividualEntities = individualSuppliers;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Individual entity suppliers must be at least 18 years old", "Supplier not old enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else //else, if it is not from PR, there's no need to be 18 years old
                    {
                        if (this.IndividualEntities != null)
                        {
                            var individualSuppliers = new List<IndividualEntity>(this.IndividualEntities);
                            individualSuppliers.Add(SaveIndividualEntitySupplier());
                            this.IndividualEntities = individualSuppliers;
                            this.Close();
                        }
                        else
                        {
                            var individualSuppliers = new List<IndividualEntity>();
                            individualSuppliers.Add(SaveIndividualEntitySupplier());
                            this.IndividualEntities = individualSuppliers;
                            this.Close();
                        }
                    }
                }
                else // else, if it is a legal entity supplier
                {
                    if (this.Suppliers != null)
                    {
                        var suppliers = new List<Supplier>(this.Suppliers);
                        suppliers.Add(SaveLegalEntitySupplier());
                        this.Suppliers = suppliers;
                        this.Close();
                    }
                    else
                    {
                        var suppliers = new List<Supplier>();
                        suppliers.Add(SaveLegalEntitySupplier());
                        this.Suppliers = suppliers;
                        this.Close();
                    }
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
