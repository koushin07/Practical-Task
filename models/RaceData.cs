
using CsvHelper.Configuration.Attributes;

namespace ConsoleApp.models;


public class RaceData
{
    [Name("Meeting Date")]
    public string MeetingDate { get; set; }
    [Name("Racing Name")]
    public string RacingName { get; set; }
    [Name("Racing Number")]
    public string RacingNumber { get; set; }
    [Name("Racing Time")]
    public string RacingTime { get; set; }
}
