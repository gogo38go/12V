namespace BoardGameApp1.Models.Domail
{
    public class BoardgamesSellers
    {
        public ICollection<Boardgames> Boardgames { get; set; } = new List<Boardgames>();
        public ICollection<Sellers> Sellers { get; set; } = new List<Sellers>();
    }
}
