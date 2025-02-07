using System.Globalization;
using ConsoleApp.models;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;


await Practical();

static async Task Practical()
{
    // Create an instance of HttpClient for making HTTP requests
    using var http = new HttpClient();

    // Define the URL of the API endpoint to fetch racing data
    var url = $"https://www.sportsbet.com.au/apigw/sportsbook-racing/Sportsbook/Racing/AllRacing/{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}";

    // Make an asynchronous GET request to the API endpoint
    var response = await http.GetAsync(url);

    // Read the response content as a string
    var jsonString = await response.Content.ReadAsStringAsync();

    // Deserialize the JSON response into a Base object
    var raceInfo = JsonConvert.DeserializeObject<Base>(jsonString);

    // Create a list to hold the race data for CSV output
    var raceDataList = new List<RaceData>();

    // Iterate through the dates in the raceInfo object
    foreach (var date in raceInfo.Dates)
    {
        // Iterate through the sections within each date
        foreach (var section in date.Sections)
        {
            if (!section.DisplayName.ToLower().Equals("horses")) break;
            // Iterate through the meetings within each section
            foreach (var meeting in section.Meetings)
            {
                // Iterate through the events within each meeting
                foreach (var evnt in meeting.Events)
                {
                    // Convert Unix timestamps to DateTime objects and format them
                    DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(date.MeetingDate).DateTime;

                    DateTime dateRacing = DateTimeOffset.FromUnixTimeSeconds(evnt.startTime).DateTime; // Add the race data to the list
                    raceDataList.Add(new RaceData
                    {
                        MeetingDate = dateTime.ToString("yyyy-MM-dd"), // Format the date
                        RacingName = evnt.name,
                        RacingNumber = $"Race {evnt.raceNumber}", // Get the race number
                        RacingTime = dateRacing.ToString("hh:mm tt"), // Format the racing time
                    });
                }
            }
        }
    }

    // Create a StreamWriter to write the data to a CSV file
    using var writer = new StreamWriter("RaceInfo.csv");

    // Create a CsvWriter
    using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));

    // Write the list of race data to the CSV file
    csv.WriteRecords(raceDataList);
}
