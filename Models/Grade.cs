
namespace CardWebsite.Models
{

public class Grade
{
    public int GradeId { get; set; }
    public int Score { get; set; }

    public List<Collection>? Collections { get; set; }
}
}