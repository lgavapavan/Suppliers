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
    public partial class CompaniesListForm : Form
    {
        internal List<Company> Companies { get; set; }
        internal CompaniesListForm(List<Company> companies)
        {
            InitializeComponent();
            this.Companies = companies;
        }

        private void CompaniesListForm_Load(object sender, EventArgs e)
        {
            dgvCompanies.DataSource = LoadCompaniesList();
        }

        private DataTable LoadCompaniesList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Company Name", typeof(string));
            dt.Columns.Add("Federative Unit", typeof(string));
            dt.Columns.Add("Document Type", typeof(string));
            dt.Columns.Add("Document", typeof(string));
            for (int i = 0; i <= this.Companies.Count-1; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Company Name"] = this.Companies[i].CompanyName;
                dr["Federative Unit"] = this.Companies[i].FederativeUnit;
                dr["Document Type"] = this.Companies[i].DocumentType;
                dr["Document"] = this.Companies[i].Document;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
