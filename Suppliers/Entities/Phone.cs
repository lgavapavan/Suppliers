using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities
{
    class Phone
    {
        public byte AreaCode { get; set; }
        public string Number { get; set; }

        public Phone(byte areaCode, string number)
        {
            this.AreaCode = areaCode;
            this.Number = number;
        }
    }
}
