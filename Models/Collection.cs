using System.Text.Json.Serialization;

namespace CardWebsite.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public int CardId { get; set; }
        public int SetId { get; set; }
        public int GradeId { get; set; }

        [JsonIgnore]
        public Card Card { get; set; }

        [JsonIgnore]
        public Set Set { get; set; }

        [JsonIgnore]
        public Grade Grade { get; set; }

        [JsonIgnore]
        public Deck Deck { get; set; }
        
    }
}