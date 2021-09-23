using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Entities;

namespace CasaDoCodigo.Repositorys
{
    public interface IBaseRepository<T> where T: BaseModel
    {
        RepositoryImportResponse<T> ImportDataFromList(List<T> items);

        RepositoryListResponse<T> ListDataFromEntity();

        RepositorySetInstanceByID<T> InsertNewInstance(T instance);

        RepositoryGetInstanceByID<T> GetInstanceById(int instanceId);


    }
}
