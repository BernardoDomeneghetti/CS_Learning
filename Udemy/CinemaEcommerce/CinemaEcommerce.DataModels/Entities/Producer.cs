using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEcommerce.DataModels.Entities
{
    public class Producer : BaseModel
    {
        public string ProfilePictureUrl { get; set; }
        public string Fullname { get; set; }
        public string Bio { get; set; }

        #region Relationship

        public List<Movie> Movies { get; set; }

        #endregion
    }
}
