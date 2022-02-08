using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEcommerce.DataModels.Entities
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
