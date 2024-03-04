using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CardWebsite.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
         public List<Collection>? Collections { get; set; }
    }
}
