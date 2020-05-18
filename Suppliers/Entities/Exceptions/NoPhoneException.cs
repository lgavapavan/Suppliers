using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities.Exceptions
{
    [Serializable]
    class NoPhoneException : Exception
    {
        public NoPhoneException()
        {

        }
        public NoPhoneException(string message)
            : base(String.Format("No phones saved for this supplier"))
        {

        }
    }
}
