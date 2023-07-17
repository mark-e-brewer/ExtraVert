// See https://aka.ms/new-console-template for more information
String greeting = "Hello, Welcome to my plant store";
Console.WriteLine(greeting);

List<Plant> plants = new List<Plant>()
{
    new Plant()
    { 
        Species = "sunflower", 
        LightNeeds = 4,
        City = "Dallas",
        Zip = 83248,
        AskingPrice = "3.99",
        Sold = false
    },
    new Plant() 
    { 
        Species = "iris", 
        LightNeeds = 2,
        City = "Dallas",
        Zip = 83248,
        AskingPrice = "7.99",
        Sold = true
    },
        new Plant() 
    { 
        Species = "draggon plant", 
        LightNeeds = 3,
        City = "Dallas",
        Zip = 32542,
        AskingPrice = "18.99",
        Sold = false
    },
            new Plant() 
    { 
        Species = "cactus", 
        LightNeeds = 5,
        City = "Dallas",
        Zip = 32542,
        AskingPrice = "10.69",
        Sold = false
    },
                new Plant() 
    { 
        Species = "Vines", 
        LightNeeds = 1,
        City = "Apex",
        Zip = 27502,
        AskingPrice = "5.99",
        Sold = true
    }
};

Console.WriteLine("plants:");

for (int i = 0; i < plants.Count; i++)
{
  Console.WriteLine($"{i + 1}. {plants[i].Species}");
}
