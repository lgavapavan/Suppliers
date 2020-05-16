using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities
{
    internal class IndividualEntity : Supplier
    {
        internal DateTime BirthDate { get; set; }

        internal IndividualEntity()
        {
        }

        internal IndividualEntity(Company company, string name, List<Document> documents, DateTime dateSaved, List<Phone> phones, DateTime birthDate)
        {
            this.Company = company;
            this.Name = name;
            this.Documents = documents;
            this.DateSaved = dateSaved;
            this.Phones = phones;
            this.BirthDate = birthDate;
        }

        static internal bool HasLegalAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
                return true;
            else
                return false;
        }

        static internal bool IsFromPR(Company company)
        {
            if (company.FederativeUnit == Enums.FederativeUnits.PR)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
