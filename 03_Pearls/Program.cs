using System;
using System.Security.Cryptography;
using System.Text;

using Helpers;

namespace _03_Pearls;

class Program
{
    //Klass neckless med properties från csPearl? 

    List<csPearl> neckless = new List<csPearl>();
    public enum Color { Black, White, Pink }
    public enum Shape { Round, WaterDrop }
    public enum Type { FreshWater, SaltWater }
    public class csPearl
    {
        public int size { get; init; }
        public Color eColor { get; init; }
        public Shape eShape { get; init; }
        public Type eType { get; init; }
        public csPearl(csSeedGenerator rnd)
        {
            eColor = rnd.FromEnum<Color>();
            size = rnd.Next(5, 26);
            eShape = rnd.FromEnum<Shape>();
            eType = rnd.FromEnum<Type>();
        }

        public override string ToString() => $"{Color.White} {Shape.Round} {Type.FreshWater}";
    }
    static void Main(string[] args)
    {
        var rnd = new csSeedGenerator();

        Console.WriteLine(rnd.Next(5, 26));
        Console.WriteLine(rnd.FromEnum<Color>());
        Console.WriteLine(rnd.FromEnum<Shape>());
        Console.WriteLine(rnd.FromEnum<Type>());

    }

    //Exercise:
    // 1. Modellera en pärlan i en C# class. Utmärkande för en pärla är
    //    Storlek: Diameter 5mm till 25mm
    //    Färg: Svart, Vit, Rosa
    //    Form: Rund, Droppformad
    //    Typ: Sötvatten, Saltvatten
    //
    // 2. När pärlan väl är skapad så ska man inte kunna ändra den.

    // 3. Gör om constructor csPearl(csSeedGenerator _seeder) som initierar en slumpmässig pärla

    // 4. Skapa en ToString i din pärlklass som presenterar pärlan.
    //
    // 5. Skapa ett halsband bestående av 10 pärlor av slumpmässig storlek, färg
    //    form, och typ
    //
    // 6. Skriv kod som visar vilken färg, form och typ har den minsta och den största pärlan i halsbandet?
    //
    // 7. Deklarera en contruktor som tillåter dig att själv bestämma alla csPearl public properties
    //
    // 8. Deklarera en Copy constructor.
    //
    // 9. Använd copy constructorn för att skapa ett nytt halsband som är en kopia av ursprunget
}




