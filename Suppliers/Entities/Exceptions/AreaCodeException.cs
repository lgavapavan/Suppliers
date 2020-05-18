using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities.Exceptions
{
    [Serializable]
    class AreaCodeException : Exception
    {
        public AreaCodeException()
                    : base(String.Format("The area code is in the wrong format. It's either out of range or contains special characters."))
        {

        }
    }
}
