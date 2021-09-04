using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLib.Models.Exceptions
{
    class AccountResponseMisusedConstructorException : Exception
    {
        public AccountResponseMisusedConstructorException():base("The response constructor was used by the wrong way")
        {
            
        }

        public AccountResponseMisusedConstructorException(string message) : base(message)
        {
        }
    }
}
