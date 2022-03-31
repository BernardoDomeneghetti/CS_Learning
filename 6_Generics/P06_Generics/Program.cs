using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Generics
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> teste = new List<int>();
            teste.AddSet(1, 4, 2, 3, 3, 2, 4, 1);

            teste.Sort();

            foreach (int item in teste)
            {
                Console.WriteLine(item);
            }


            var namesList = new List<string>() { "Eduarda", "Bernardo" };
            namesList.Sort();
            foreach (string item in namesList)
            {
                Console.WriteLine(item);
            }

            var clientes = new List<Client>()
            {
                new Client(02,"Bernardo"),
                new Client(01,"Eduarda"),
                null,
                null
            };



            var vClientesOrdenados = clientes
                .Where(cliente => cliente != null)
                .OrderBy(cliente => cliente.Id);
            

            foreach (Client item in vClientesOrdenados)
            {
                if(item == null)
                {
                    Console.WriteLine("Null reference");
                }
                else { Console.WriteLine(item.ToString()); }
                
            }
        }

        public static void AddSet<T>(this List<T> items, params T[] values)
        {
            items.AddRange(values);
        }
    }
}
