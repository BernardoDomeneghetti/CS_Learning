using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.Entities { 
    public class BaseModel
    {
        public int Id { get; protected set; }
    }
}
