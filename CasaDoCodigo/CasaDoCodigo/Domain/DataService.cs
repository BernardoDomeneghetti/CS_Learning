using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.Exceptions;
<<<<<<< HEAD:CasaDoCodigo/CasaDoCodigo/Services/DataService.cs
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> Home:CasaDoCodigo/CasaDoCodigo/Domain/DataService.cs

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
<<<<<<< HEAD:CasaDoCodigo/CasaDoCodigo/Services/DataService.cs
                //if (!context.Database.EnsureCreated())
                //{
                //    throw new DatabaseAlreadyCreatedException("Database already created");
                //}
=======
                //context.Database.Migrate();
>>>>>>> Home:CasaDoCodigo/CasaDoCodigo/Domain/DataService.cs
                var jsonString = File.ReadAllText("livros.json");
                new ProductService(new Repositorys.ProductRepository(context)).ProductJsonImport(jsonString);

            }
<<<<<<< HEAD:CasaDoCodigo/CasaDoCodigo/Services/DataService.cs
            catch (DatabaseAlreadyCreatedException) { }
=======
            catch (Exception e)
            {
                if(!e.Message.Contains("already"))
                {
                    throw;
                }
            }
>>>>>>> Home:CasaDoCodigo/CasaDoCodigo/Domain/DataService.cs
        }

        

    }
}

