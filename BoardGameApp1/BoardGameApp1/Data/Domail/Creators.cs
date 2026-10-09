using System.Collections.Generic;

namespace BoardGameApp1.Data.Domail
{
    public class Creators
    {
    public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection <Boardgames> Boardgames { get; set; }=new List<Boardgames>();    

    }
}
