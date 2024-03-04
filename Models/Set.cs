using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CardWebsite.Models
{
    public class Set
    {
        public int SetId { get; set; }
        public string Title { get; set; }

        [JsonIgnore]
        public List<Collection>? Collections { get; set; }
    }
}