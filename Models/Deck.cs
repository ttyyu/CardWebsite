using System.Text.Json.Serialization;

namespace CardWebsite.Models
{

public class Deck
{
    public int DeckId { get; set; }
    public string Name { get; set; }


    [JsonIgnore]
    public List<Collection>? Collections { get; set; }
}
}