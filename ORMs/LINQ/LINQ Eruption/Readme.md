# Core Assignment: LINQ Eruption!

### Learning Objectives:

- Create a console application for querying data using the data provided.
- Pull data from a data set using LINQ queries.
- Verify correct data is pulled by rendering queried data to the console.
##
### Directions
Follow the "Project Set Up" steps, and then use LINQ to complete the tasks listed below.

### Project Set Up:
1. Create a new console app. Just in case you've forgotten, the command to do this is:

```md
dotnet new console -o YourProjectName
````
2. Create a file named Eruption.cs, then copy and paste the code below to create your "Eruption" class:
```md
public class Eruption
{
    public string Volcano { get; set; }
    public int Year { get; set; }
    public string Location { get; set; }
    public int ElevationInMeters { get; set; }
    public string Type { get; set; }
    public Eruption(string volcano, int year, string location, int elevationInMeters, string type)
    {
        Volcano = volcano;
        Year = year;
        Location = location;
        ElevationInMeters = elevationInMeters;
        Type = type;
    }
    
    // This method overrides the original ToString method built into C#
    // So we can get a specialized response!
    public override string ToString()
    {
        return $@"
            Name: {Volcano}
            Year: {Year}
            Location: {Location}
            Elevation: {ElevationInMeters} meters
            Type: {Type}
            ";
    }
}
````
3. Copy and paste the following code snippet into your Program.cs
```md
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
````
Source: National Geophysical Data Center / World Data Service (NGDC/WDS): NCEI/WDS Global Significant Volcanic Eruptions Database. NOAA National Centers for Environmental Information. [doi:10.7289/V5JW8BSH](http://dx.doi.org/10.7289/V5JW8BSH). Accessed on 05/20/2022.

Now complete the queries listed below. You can make use of the ToString() and PrintEach() methods provided by the starter code to help you visualize the data. If you would prefer to add more visuals to the assignment, you are free to create a new web or MVC project and render your results to a View. The choice is yours!

- [x] Use LINQ to find the first eruption that is in Chile and print the result.

- [x] Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."

- [x] Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."

- [x] Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.

- [x] Find all eruptions where the volcano's elevation is over 2000m and print them.

- [x] Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.

- [x] Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)

- [x] Use the highest elevation variable to find and print the name of the Volcano with that elevation.

- [x] Print all Volcano names alphabetically.

- [x] Print the sum of all the elevations of the volcanoes combined.

- [x] Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)

- [x] Find all stratovolcanoes and print just the first three (Hint: look up Take)

- [x] Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.

- [x] Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.