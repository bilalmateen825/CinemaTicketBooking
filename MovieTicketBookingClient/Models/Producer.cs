using System.ComponentModel.DataAnnotations;

namespace MovieTicketBookingClient.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship   Producer can have multiple movies
        public List<Movie> Movies { get; set; }
    }
}
