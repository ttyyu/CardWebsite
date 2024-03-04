using System.Collections.Generic;

namespace CardWebsite.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }

        public List<Collection>? Collections { get; set; }
    }
}
