using System.Collections.Generic;

namespace CardWebsite.Models
{
    public class Set
    {
        public int SetId { get; set; }
        public string Title { get; set; }

        public List<Collection>? Collections { get; set; }
    }
}