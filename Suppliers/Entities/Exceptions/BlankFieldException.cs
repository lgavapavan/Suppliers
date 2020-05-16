using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Entities.Exceptions
{
    [Serializable]
    class BlankFieldException : Exception
    {
        public BlankFieldException()
        {

        }
        public BlankFieldException(string message, string fieldName)
            : base(String.Format("The following field is blank: {0}", fieldName))
        {

        }
    }
}
