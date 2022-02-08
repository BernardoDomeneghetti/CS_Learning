using CinemaEcommerce.DataModels.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaEcommerce.DataModels.Entities
{
    public class Movie : BaseModel
    {
        public string? Title { get; set; }//Name 
        public string? Sinopose { get; set; }//Description
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TicketPrice { get; set; }
        public MovieCategoryEnum MovieCategory { get; set; }
        public string BannerPictureUrl { get; set; }

        #region RelationShips 

        public Cinema Cinema { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Producer Producer { get; set; }

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }

        public List<ActorMovie> ActorsMovies { get; set; }

        #endregion

    }
}
