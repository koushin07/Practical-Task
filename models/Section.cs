
namespace ConsoleApp.models;

public class Section
{
    public string DisplayName { get; set; }
    public int DisplayOrder { get; set; }
    public string RaceType { get; set; }
    public List<Meeting> Meetings { get; set; }
}
