using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Requests
{
    public class UpdateProductAmountRequest
    {
        public int ProductCode { get; set; }
        public int Amount { get; set; }
    }
}
