
namespace ConsoleApp.models;

public class Event
{
    public int id { get; set; }
    public int raceNumber { get; set; }
    public int startTime { get; set; }
    public string name { get; set; }
    public bool hasBIR { get; set; }
    public bool hasBIRStarted { get; set; }
    public int sort { get; set; }
    public string statusCode { get; set; }
    public Streaming streaming { get; set; }
    public bool streamingAvailable { get; set; }
    public string availableStreamingType { get; set; }
    public bool mbsAvailable { get; set; }
    public string httpLink { get; set; }
    public string regionGroup { get; set; }
    public string type { get; set; }
    public string category { get; set; }
    public string bettingStatus { get; set; }
    public bool isInternational { get; set; }
    public string distance { get; set; }
    public string displayName { get; set; }
}
