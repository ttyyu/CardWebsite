namespace CardWebsite.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public int CardId { get; set; }
        public int SetId { get; set; }

        public Card Card { get; set; }
        public Set Set { get; set; }
    }
}