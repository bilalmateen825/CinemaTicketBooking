using System.ComponentModel.DataAnnotations;

namespace MovieTicketBookingClient.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship  Cinema can have multiple movies
        public List<Movie> Movies { get; set; }
    }
}
