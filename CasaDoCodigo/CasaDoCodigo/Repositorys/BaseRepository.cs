using CasaDoCodigo.Models.Entities;
using CasaDoCodigo.Models.Exceptions;
using CasaDoCodigo.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    item.SetKey();

                    if (!_dbContext.Set<T>().Where(p => p.Id == item.Id).Any())
                    {
                        item.Id = 0;
                        _dbContext.Set<T>().Add(item);
                        _dbContext.SaveChanges();
                    }
                }

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

        public  RepositoryGetInstanceByID<T> GetInstanceById(int instanceId)
        {
            try
            {
                T instance = _dbContext.Set<T>().Where(p => p.Id == instanceId).SingleOrDefault();

                if (instance == null)
                {
                    throw new DbObjectInstanceNotFoundException($"O objeto buscado com o Id {instanceId} não foi encontrado");
                }
               
                return new RepositoryGetInstanceByID<T>(true, "Instância capturada com sucesso", instance);
            }
            catch
            {
                return new RepositoryGetInstanceByID<T>(false, "Falha ao capturar instância", null);
            }
        }
        public RepositorySetInstance<T> InsertNewInstance(T instance)
        {
            try
            {
                _dbContext.Set<T>().Add(instance);
                _dbContext.SaveChanges();
                return new RepositorySetInstance<T>(true, "Nova instância inserida com sucesso", instance);
            }
            catch
            {
                return new RepositorySetInstance<T>(false, "Falha ao inserir a nova instância", null);
            }

        }
    }
}
