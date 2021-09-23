using CasaDoCodigo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.Responses;
using CasaDoCodigo.Models.Entities;



namespace CasaDoCodigo.Repositorys
{
    public abstract class BaseRepository<T>: IBaseRepository<T> where T: BaseModel
    {
        protected readonly ApplicationContext _dbContext;

        protected BaseRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public RepositoryImportResponse<T> ImportDataFromList(List<T> items)  
        {
            try
            {
                foreach (var item in items)
                {
                    _dbContext.Set<T>().Add(item);
                }
                _dbContext.SaveChanges();

                return new RepositoryImportResponse<T>(true, "Produtos inseridos no banco de dados com sucesso!", items);
            }
            catch (Exception e)
            {
                return new RepositoryImportResponse<T>(false, $"ERROR: Items importing failed: {e.Message}", null);
            }
        }

        public RepositoryListResponse<T> ListDataFromEntity()
        {
            try
            {
                var items = new List<T>();
                items = _dbContext.Set<T>().ToList();
                return new RepositoryListResponse<T>(true, "Itens listados com sucesso!", items);
            }
            catch (Exception e)
            {
                return new RepositoryListResponse<T>(false, $"ERRO: Listagem de itens falhou: {e.Message}", null);
            }
        }
    }
}
