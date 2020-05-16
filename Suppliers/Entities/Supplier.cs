using Suppliers.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities
{
    internal class Supplier
    {
        public Company Company { get; set; }
        public string Name { get; set; }
        public List<Document> Documents { get; set; }
        public DateTime DateSaved { get; set; }
        public List<Phone> Phones { get; set; }
        internal Supplier()
        {

        }

        internal Supplier(Company company, string name, List<Document> documents, DateTime dateSaved, List<Phone> phones)
        {
            this.Company = company;
            this.Name = name;
            this.Documents = documents;
            this.DateSaved = dateSaved;
            this.Phones = phones;
        }
    }
}
