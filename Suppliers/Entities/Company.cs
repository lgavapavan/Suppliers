using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suppliers.Entities.Enums;

namespace Suppliers
{
    internal class Company
    {
        public FederativeUnits FederativeUnit { get; set; }
        public string CompanyName { get; set; }
        public string Document { get; set; }
        public DocumentTypes DocumentType { get; set; }
        public Company()
        {

        }

        public Company(string companyName, string document, DocumentTypes type, FederativeUnits fu)
        {
            this.CompanyName = companyName;
            this.Document = document;
            this.DocumentType = type;
            this.FederativeUnit = fu;
        }
    }
}
