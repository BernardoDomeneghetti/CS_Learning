using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankLib.Models.Exceptions
{
    class CustomerPromotionLimitExcededException : Exception
    {
        public CustomerPromotionLimitExcededException()
        {
        }

        public CustomerPromotionLimitExcededException(string message) : base(message)
        {
        }
    }

    class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException()
        {
        }

        public CustomerNotFoundException(string message) : base(message)
        {
        }
    }
}
