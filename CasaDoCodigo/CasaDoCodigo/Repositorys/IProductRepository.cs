using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CasaDoCodigo.Repositorys
{
    public interface IProductRepository: IBaseRepository<Produto>
    {
    }
}
