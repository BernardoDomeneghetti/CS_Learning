using System;
using System.Runtime.Serialization;

namespace CasaDoCodigo.Models.Exceptions
{
    public class DatabaseAlreadyCreatedException : Exception
    {
        public DatabaseAlreadyCreatedException(string message) : base(message)
        {
        }
    }
}
