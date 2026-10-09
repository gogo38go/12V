using System.ComponentModel.DataAnnotations;

namespace BoardGameApp1.Data.Domail
{
    public class Sellers
    {
     public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public string Country { get; set; }

        [Required]
        public string Website { get; set; }

        public ICollection<BoardgamesSellers> BoardgamesSellers { get; set; } = new List<BoardgamesSellers>();
    }
}
