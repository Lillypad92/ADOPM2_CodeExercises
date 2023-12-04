using Helpers;
using System.Globalization;
namespace _04_wines;

class Program
{
    public enum enGrape { Ressling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
    public enum enWineType { Red, White, Rosé }
    public enum enCountry { Germany, France, Spain }
    public class csWine : IComparable<csWine>
    {
        private int minPrice = 50;
        private int maxPrice = 1000;
        public string Name { get; }
        public enGrape Grape { get; }
        public enWineType WineType { get; }
        public enCountry Country { get; }
        public decimal Price { get; set; }
        public csWine(csSeedGenerator seeder)
        {
            Grape = seeder.FromEnum<enGrape>();
            WineType = seeder.FromEnum<enWineType>();
            Country = seeder.FromEnum<enCountry>();
            Price = seeder.NextDecimal(minPrice, maxPrice + 1);
            Name = seeder.FirstName;
        }
        public csWine(string name, enGrape grape, enWineType winetype, enCountry country, decimal price) 
        {
            Name = name;
            Grape = grape;
            WineType = winetype;
            Country = country;
            Price = price;
        }
        public csWine(csWine wineToCopy)
        {
            Name = wineToCopy.Name;
            Grape = wineToCopy.Grape;
            WineType = wineToCopy.WineType;
            Country = wineToCopy.Country;
            Price = wineToCopy.Price;
        }
        public override string ToString() => $"Wine name: {Name}, Grape: {Grape}, winetype: {WineType}, From: {Country}, Price: {Price:#}";

        int IComparable<csWine>.CompareTo(csWine? other)
        {
            if (Country != other.Country)
            {
                return Country.CompareTo(other.Country);
            }
            else 
            {
                return Price.CompareTo(other.Price);
            }
        }
    }
    public class csWineCeller 
    {
        private decimal _minValue = int.MinValue;
        private decimal _maxValue = int.MaxValue;
        public List<csWine> Wines { get; } = new List<csWine>();
        public csWineCeller(csSeedGenerator seedGenerator)
        {
            for (int i = 0; i < 10; i++)
            {
                Wines.Add(new csWine(seedGenerator));
                
            }
        }
        public csWineCeller(csWineCeller wineCellerToCopy)  
        {
            foreach (var wine in wineCellerToCopy.Wines) 
            {
                Console.WriteLine(wine);
            }
        }
        public csWine GetCheapestWine()
        {
            decimal cheapestPrice = _maxValue;

            csWine cheapestWine = null;
            foreach (csWine wine in Wines) 
            {
                if (wine.Price < cheapestPrice) 
                {
                    cheapestPrice = wine.Price;
                    cheapestWine = wine;
                }
            }
            return cheapestWine;
        }
        public csWine GetExpensiveWine()
        {
            decimal expensivePrice = _minValue;
            csWine expensiveWine = null;
            foreach (csWine wine in Wines) 
            {
                if (wine.Price > expensivePrice) 
                {
                    expensivePrice = wine.Price;
                    expensiveWine = wine;
                }
            }
            return expensiveWine;
        }
        public decimal GetValueOfWineCeller() 
        {
            decimal totalValue = 0;
            foreach (csWine wine in Wines) 
            {
                totalValue += wine.Price;
            }
            return totalValue;
        }
    }
    static void Main(string[] args)
    {
        
        csSeedGenerator seedGenerator = new csSeedGenerator();
        csWineCeller wineCeller = new csWineCeller(seedGenerator);
        

        Console.WriteLine("The list of wines.");
        List<csWine> wineList = new List<csWine>();

        foreach (csWine wine in wineCeller.Wines) 
        {
            Console.WriteLine(wine);
        }
        Console.WriteLine();
        Console.WriteLine("The cheapiest and the most expensive wine:");
        Console.WriteLine($"Cheap wine: {wineCeller.GetCheapestWine()}");
        Console.WriteLine($"Expensive wine: {wineCeller.GetExpensiveWine()}");
        Console.WriteLine();
        Console.WriteLine("Total value of vine cellar: ");
        Console.WriteLine($"{wineCeller.GetValueOfWineCeller().ToString("C", CultureInfo.CurrentCulture)}");

        Console.WriteLine();
        Console.WriteLine("The sorted list of wines: ");
        //sort


        csWine wines = new csWine(seedGenerator);
        csWine copyWines = new csWine(seedGenerator);
        copyWines = new csWine(wines);

        Console.WriteLine("Copied wines from the original wines: ");
        
    }
}
//Exercise:
// 1. Modellera en flaska vin en C# class. Utmärkande för ett vin är
//    Druva: Reissling, Tempranillo, Chardonay, Shiraz, Cabernet Savignoin, Syrah
//    Typ: Rött, vitt, rose
//    Namn: namnet på vinet
//    Land: Tyskland, Frankrike, Spanien
//    Pris:
//
// 2. När vinet väl är skapad så ska man bara kunna ändra pris.

// 3. Gör en constructor csWine(csSeedGenerator _seeder) som initierar ett vin
//
// 3. Skapa en ToString i din vinklass som presenterar vinet.
//
// 4. Skapa en vinkällare bestående av 10 flaskor av slumpmässig Druva,
//    Typ, Namn, Land och pris
//
// 5. Vilket är det billigaste och dyraste vinet i vinkällaren?
//
// 6. Vad är värdet av vinkällaren?
//
//
// 7. Deklarera en contruktor som tillåter dig att själv bestämma alla csWine public properties
//
// 8.Deklarera en Copy constructor.
//
// 9.Använd copy constructorn för att skapa en ny lista av 10 viner med samma
//    innehåll som ursprungslistan
