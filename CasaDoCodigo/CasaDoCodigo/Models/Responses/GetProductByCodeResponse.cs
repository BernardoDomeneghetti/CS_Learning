using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class GetProductByCodeResponse : BaseResponse
    {
        public Produto Instance { get; }
        public GetProductByCodeResponse(bool success, string message, Produto instance) : base(success, message)
        {
            Instance = instance;
        }
    }
}
