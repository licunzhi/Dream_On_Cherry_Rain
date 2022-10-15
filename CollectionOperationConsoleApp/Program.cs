// See https://aka.ms/new-console-template for more information
using CollectionOperationConsoleApp;

Console.WriteLine("Hello, World!");

// Create a new list to add
var salmons = new List<string>();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

foreach (var salmon in salmons)
{
    Console.WriteLine(salmon);
}


// Create and init
var list01 = new List<string> { "01", "02", "03" };
foreach (var salmon in list01)
{
    Console.Write(salmon);
}

// Remove object
list01.Remove("01");
// Remove by index
list01.RemoveAt(1);
Console.WriteLine("after remove some objects:");
foreach (var salmon in list01)
{
    Console.Write(salmon);
}
Console.WriteLine();

// Also can remove all
list01.RemoveAll(data => list01.Contains(data));
Console.WriteLine("after remove all objects:");
foreach (var salmon in list01)
{
    Console.Write(salmon);
}

var theGalaxies = new List<Galaxy> 
{
    new Galaxy() { Name="Tadpole", MegaLightYears=400},
    new Galaxy() { Name="Pinwheel", MegaLightYears=25},
    new Galaxy() { Name="Milky Way", MegaLightYears=0},
    new Galaxy() { Name="Andromeda", MegaLightYears=3}
};

foreach (Galaxy theGalaxy in theGalaxies)
{
    Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
}