using System.ComponentModel.DataAnnotations;

namespace MovieTicketBookingClient.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        //Relationships  Actor can have multiple movies
        public List<ActorAndMovie> ActorsAndMovies { get; set; }
    }
}
