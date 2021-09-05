using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLib.Models.Exceptions
{
    class CustomerResponseMisusedConstructorException : Exception
    {
        public CustomerResponseMisusedConstructorException() : base("The response constructor was used by the wrong way")
        {

        }

        public CustomerResponseMisusedConstructorException(string message) : base(message)
        {
        }
    }
}
