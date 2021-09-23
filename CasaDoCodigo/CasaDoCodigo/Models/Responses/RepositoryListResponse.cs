using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CasaDoCodigo.Models.Responses
{
    public class RepositoryListResponse<T> : BaseResponse where T : BaseModel
    {
        public List<T> Items { get; private set; }
        public RepositoryListResponse(bool success, string message, List<T> items) : base(success, message)
        {
            Items = items;
        }
    }
}
