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
    public partial class NewCompanyForm : Form
    {
        internal List<Company> Companies { get; set; }
        internal List<Supplier> Suppliers { get; set; }
        internal List<IndividualEntity> IndividualEntities { get; set; }
        internal bool HasSaved { get; set; }
        internal NewCompanyForm(List<Company> companies, List<Supplier> suppliers, List<IndividualEntity> individualEntities)
        {
            InitializeComponent();
            this.Companies = companies;
            this.Suppliers = suppliers;
            this.IndividualEntities = individualEntities;
            this.HasSaved = false;
        }

        private void NewCompanyForm_Load(object sender, EventArgs e)
        {
            comboFederativeUnit.DataSource = Enum.GetValues(typeof(FederativeUnits));
            this.comboFederativeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void picSaveCompany_Click(object sender, EventArgs e)
        {
            if (ValidateCompany())
            {
                if (this.Companies != null)
                {
                    var companies = new List<Company>(this.Companies);
                    companies.Add(SaveCompany());
                    this.Companies = companies;                
                    this.Close();
                }
                else
                {
                    var companies = new List<Company>();
                    companies.Add(SaveCompany());
                    this.Companies = companies;
                    this.Close();
                }
            }
        }

        private Company SaveCompany()
        {
            FederativeUnits federativeUnit = new FederativeUnits();
            federativeUnit = (FederativeUnits)Enum.Parse(typeof(FederativeUnits), comboFederativeUnit.SelectedItem.ToString());

            Company company = new Company(
                txtCompanyName.Text,
                txtDocument.Text,
                DocumentTypes.CNPJ,
                federativeUnit);
            return company;
        }

        private void NewCompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Form1(this.Companies, this.Suppliers, this.IndividualEntities);
            form.Show();            
        }

        private bool ValidateCompany()
        {
            try
            {
                IsEmpty(txtCompanyName.Text, "Company's Name");
                IsEmpty(txtDocument.Text, "Document");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "All fields must be filled to save the company.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
