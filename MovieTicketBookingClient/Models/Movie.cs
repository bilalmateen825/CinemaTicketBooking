using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieTicketBookingClient.Data.Enums;

namespace MovieTicketBookingClient.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship  Movie has multiple actors
        public List<ActorAndMovie> Actors_Movies { get; set; }

        //One to Many relationship
        //We need to define foreign key Cinema Id
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //One to Many relationship
        //We need to define foreign key Producer Id
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
