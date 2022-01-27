using CasaDoCodigo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class RepositoryUpdateInstance<T> : BaseResponse where T: BaseModel
    {
        public T Instance { get; private set; }
        public RepositoryUpdateInstance(bool success, string message, T instance) : base(success, message)
        {
            Instance = instance;
        }
    }
}