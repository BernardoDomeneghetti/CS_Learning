using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Responses
{
    public class RepositoryImportResponse<T> : BaseResponse
    {
        public List<T> importedItems { get; private set; }
          
        public RepositoryImportResponse(bool success, string message, List<T> importedItems) : base(success, message)
        {
            this.importedItems = importedItems;
        }
    }
}
