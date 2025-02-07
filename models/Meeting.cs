
namespace ConsoleApp.models;

public class Meeting
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<GeoLocation> GeolocationExclusion { get; set; }
    public int ClassId { get; set; }
    public bool IsInternational { get; set; }
    public string ClassName { get; set; }
    public string RegionName { get; set; }
    public bool StreamingAvailable { get; set; }
    public string AvailableStreamingType { get; set; }
    public bool MbsAvailable { get; set; }
    public List<Event> Events { get; set; }
}
