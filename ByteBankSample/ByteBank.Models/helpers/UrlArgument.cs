using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.helpers
{
    public class UrlArgument
    {
        public String Name { get; set; }
        public String Value { get; set; }

        public UrlArgument(String argumentName, String argumentValue)
        {
            Name = argumentName;
            Value = argumentValue;
        }
}
}
