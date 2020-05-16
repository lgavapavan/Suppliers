using Suppliers.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities
{
    internal class Document
    {
        internal DocumentTypes DocumentType { get; set; }
        internal string DocumentNumber { get; set; }

        public Document(DocumentTypes documentTypes, string documentNumber)
        {
            this.DocumentType = documentTypes;
            this.DocumentNumber = documentNumber;
        }
    }
}
