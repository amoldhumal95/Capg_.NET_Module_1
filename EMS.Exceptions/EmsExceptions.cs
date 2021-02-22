using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Exceptions
{
    public class EmsExceptions : ApplicationException
    {
        public EmsExceptions()
        {
        }

        public EmsExceptions(string message) : base(message)
        {
        }

        public EmsExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmsExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
