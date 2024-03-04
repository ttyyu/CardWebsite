namespace CardWebsite.Models
{

public class Deck
{
    public int DeckId { get; set; }
    public string Name { get; set; }

    public List<Collection>? Collections { get; set; }
}
}