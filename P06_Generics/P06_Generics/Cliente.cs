using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Generics
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object reference: {base.ToString()} Cliete.id: {Id} Cliente.Name: {Name}";
        }
        
    }
}
