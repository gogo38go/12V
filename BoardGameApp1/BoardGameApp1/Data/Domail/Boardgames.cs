using System.ComponentModel.DataAnnotations;

namespace BoardGameApp1.Data.Domail
{
    public class Boardgames
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string Name { get; set; }

        [Required]
        [Range (1.10,00)]
        public double Rating { get; set; }

        [Required]
        public string YearPublished { get; set; }

        [Required]
        public string CategoryType { get; set; }


       public string Mechanics { get; set; }

        [Required]
        public string CreatorId { get; set; }

        public ICollection<BoardgamesSellers> BoardgamesSellers { get; set; } = new List<BoardgamesSellers>();
        public ICollection<Creators> Creators { get; set; } = new List<Creators>();

    }
}
