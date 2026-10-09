namespace BoardGameApp1.Data.Domail
{
    public class BoardgamesSellers
    {
        public int Id { get; set; }
        public ICollection<Boardgames> Boardgames { get; set; } = new List<Boardgames>();
        public ICollection<Sellers> Sellers { get; set; } = new List<Sellers>();
    }
}
