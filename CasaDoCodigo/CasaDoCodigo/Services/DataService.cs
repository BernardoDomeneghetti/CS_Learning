using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;

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
                if (!context.Database.EnsureCreated())
                {
                    throw new Exception("Database already created");
                }
                var jsonString = File.ReadAllText("livros.json");
                new ProductService(new Repositorys.ProductRepository(context)).ProductJsonImport(jsonString);
            }
            catch(Exception e)
            {
                //This exception means the database is already created and doesn't needs to be treathed 
            }
            
        }

        

    }
}

