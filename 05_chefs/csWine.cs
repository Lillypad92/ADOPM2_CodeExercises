using System;
using Helpers;

namespace _05_chefs
{
    public enum enGrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
    public enum enWineType { Red, White, Rose }
    public enum enCountry { Germany, France, Spain }

    public class csWine
    {
        public string Name { get; }

        public enCountry Country { get; }
        public enWineType WineType { get; }
        public enGrapeType GrapeType { get; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            var s = $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";
            return s;
        }

        public csWine() { }
        public csWine(csSeedGenerator _seeder)
        {
            string[] _names = "Chattaux de bueff, Chattaux de paraply, PutiPuti".Split(", ");
            Name = _names[_seeder.Next(0, _names.Length)];

            GrapeType = _seeder.FromEnum<enGrapeType>();
            WineType = _seeder.FromEnum<enWineType>();
            Country = _seeder.FromEnum<enCountry>();
            Price = _seeder.Next(50, 150);
        }
        public csWine(string _name, enCountry _country, enGrapeType _grapetype,
            enWineType _wineType, decimal _price)
        {
            Name = _name;
            GrapeType = _grapetype;
            WineType = _wineType;
            Country = _country;
            Price = _price;
        }
        public csWine(csWine org)
        {
            Name = org.Name;
            GrapeType = org.GrapeType;
            WineType = org.WineType;
            Country = org.Country;
            Price = org.Price;
        }
    }
}

