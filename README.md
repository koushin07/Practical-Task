# Race Info CSV Exporter

This project fetches racing data from an API, processes it, and exports the data to a CSV file using `HttpClient`, `CsvHelper`, and `Newtonsoft.Json`.

## Prerequisites

- .NET SDK installed on your machine
- Visual Studio or any code editor of your choice

## Setup Instructions

1. **Clone the Repository**
    ```bash
    git clone <repository-url>
    cd <repository-directory>
    ```

2. **Install Required Packages**

    Use the NuGet Package Manager Console to install the following packages:
    ```bash
    Install-Package Microsoft.Extensions.Http
    Install-Package CsvHelper
    Install-Package Newtonsoft.Json
    ```

3. **Project Structure**

    Your project should have the following structure:
    ```
    ├── ConsoleApp
    │   ├── models
    │   │   ├── Base.cs
    │   │   ├── Date.cs
    │   │   ├── Section.cs
    │   │   ├── Meeting.cs
    │   │   ├── Event.cs
    │   │   ├── RaceData.cs
    │   ├── Program.cs
    │   ├── README.md
    ```

4. **Code Explanation**

    - **Base.cs**: Represents the base model for deserialization.
    - **Date.cs**: Represents the date model.
    - **Section.cs**: Represents the section model.
    - **Meeting.cs**: Represents the meeting model.
    - **Event.cs**: Represents the event model.
    - **RaceData.cs**: Represents the final CSV output model.
    - **Program.cs**: Contains the main logic for fetching data, processing it, and writing to a CSV file.


5. **Running the Application**

    Execute the program:
    ```bash
    dotnet run
    ```

    The program will fetch the racing data, process it, and export it to a `RaceInfo.csv` file in the project directory.


## License

This project is licensed under the MIT License.
