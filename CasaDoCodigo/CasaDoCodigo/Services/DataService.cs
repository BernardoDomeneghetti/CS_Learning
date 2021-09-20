using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.Exceptions;

namespace CasaDoCodigo.Services
{
    public class DataService: IDataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void InitializeDB()
        {
            try
            {
                //if (!context.Database.EnsureCreated())
                //{
                //    throw new DatabaseAlreadyCreatedException("Database already created");
                //}
                var jsonString = File.ReadAllText("livros.json");
                new ProductService(new Repositorys.ProductRepository(context)).ProductJsonImport(jsonString);
            }
            catch (DatabaseAlreadyCreatedException) { }
        }

        

    }
}

