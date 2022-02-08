using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEcommerce.DataModels.Entities
{
    public class Cinema : BaseModel
    {
        public string CinemaLogoUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Relationships

        public List<Movie> Movies { get; set; }

        #endregion

    }
}
