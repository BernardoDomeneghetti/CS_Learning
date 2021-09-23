using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Exceptions
{
    public class DbObjectInstanceNotFoundException : Exception
    {
        public DbObjectInstanceNotFoundException(string message) : base(message)
        {
        }
    }
}
