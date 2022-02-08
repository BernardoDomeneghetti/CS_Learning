using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEcommerce.DataModels.Entities
{
    public class Actor : BaseModel
    {
        public string? ProfilePictureUrl{ get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        #region Relationships

        public List<ActorMovie> ActorsMovies { get; set; }

        #endregion

    }
}
