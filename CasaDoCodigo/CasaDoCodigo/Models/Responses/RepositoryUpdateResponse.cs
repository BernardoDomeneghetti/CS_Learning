using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class RepositoryUpdateResponse<T> : BaseResponse where T : BaseModel
    {

        public T Entity { get; set; }
        public RepositoryUpdateResponse(bool success, string message, T entity) : base(success, message)
        {
            Entity = entity;
        }
    }
}
