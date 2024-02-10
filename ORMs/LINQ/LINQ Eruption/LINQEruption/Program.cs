List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Taupo", 1810, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Aira", 2000, "Japan", 1000, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

Eruption firstEruptionChile = eruptions.OrderBy(e => e.Year).FirstOrDefault(c => c.Location == "Chile");
Console.WriteLine("first eruption that is in Chile.");
Console.WriteLine(firstEruptionChile);
Console.WriteLine();

Eruption? firstEruptionHawaiian = eruptions.OrderBy(e => e.Year).FirstOrDefault(c => c.Location == "Hawaiian Is");
Console.WriteLine("first eruption from the Hawaiian Is");
if (firstEruptionHawaiian != null)
{
    Console.WriteLine(firstEruptionHawaiian);
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found");
}
Console.WriteLine();

Eruption? firstEruptionGreenland = eruptions.OrderBy(e => e.Year).FirstOrDefault(c => c.Location == "Greenland");
Console.WriteLine("first eruption from the Greenland");
if (firstEruptionGreenland != null)
{
    Console.WriteLine(firstEruptionGreenland);
}
else
{
    Console.WriteLine("No Greenland Eruption found");
}
Console.WriteLine();


Eruption? firstEruptionZealand = eruptions.FirstOrDefault(c => c.Location == "New Zealand" && c.Year > 1900);
Console.WriteLine("first eruption from the New Zealand");
if (firstEruptionZealand != null)
{
    Console.WriteLine(firstEruptionZealand);
}
else
{
    Console.WriteLine("No New Zealand Eruption found");
}
Console.WriteLine();

IEnumerable<Eruption> eruptionsElevationInMeters = eruptions.Where(c => c.ElevationInMeters > 2000);
PrintEach(eruptionsElevationInMeters, "Find all eruptions where the volcano's elevation is over 2000m.");
Console.WriteLine();

IEnumerable<Eruption> eruptionsVolcano = eruptions.Where(c => c.Volcano.Substring(0, 1) == "L");
PrintEach(eruptionsVolcano, "eruptions where the volcano's name starts with L.");
Console.WriteLine(eruptionsVolcano.Count());
Console.WriteLine();


int highestElevationInMeters = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine("Find the highest elevation, and print only that integer.");
Console.WriteLine(highestElevationInMeters);
Console.WriteLine();

// PrintEach(highestElevationInMeters, "Find the highest elevation, and print only that integer.");
Eruption? highestEruption = eruptions.OrderByDescending(e => e.ElevationInMeters).FirstOrDefault();
Console.WriteLine("Use the highest elevation variable to find and print the name of the Volcano with that elevation.");
Console.WriteLine(highestEruption.Volcano);
Console.WriteLine();

IEnumerable<Eruption> Eruptions = eruptions.OrderBy(e => e.Volcano);
Console.WriteLine("Print all Volcano names alphabetically.");

foreach (Eruption item in Eruptions)
{
    Console.WriteLine(item.Volcano.ToString());
}
Console.WriteLine();


int sumElevationInMeters = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine("Print the sum of all the elevations of the volcanoes combined.");
Console.WriteLine(sumElevationInMeters);
Console.WriteLine();


IEnumerable<Eruption> Eruption20s = eruptions.Where(e => e.Year == 2000);
PrintEach(Eruption20s, "Print whether any volcanoes erupted in the year 2000");
// Eruption? Eruption20s = eruptions.FirstOrDefault(e => e.Year == 2000);
// Console.WriteLine("Print whether any volcanoes erupted in the year 2000");
// Console.WriteLine(Eruption20s);
Console.WriteLine();


IEnumerable<Eruption> EruptionStratovolcanoTop3 = eruptions.Where(e => e.Type == "Stratovolcano").Take(3);
PrintEach(EruptionStratovolcanoTop3, "Find all stratovolcanoes and print just the first three.");
Console.WriteLine();

IEnumerable<Eruption> Eruption1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
PrintEach(Eruption1000, "Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.");
Console.WriteLine();

Console.WriteLine("Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.");

foreach (Eruption item in Eruption1000)
{
    Console.WriteLine(item.Volcano.ToString());
}
Console.WriteLine();

// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}



