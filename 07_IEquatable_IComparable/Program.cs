using Helpers;

namespace _07_IEquatable_IComparable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("07_IEquatable_IComparable");
        var rnd = new csSeedGenerator();
        var p1 = new csPearl(rnd);
        Console.WriteLine(p1);

        var p2 = new csPearl(rnd);
        Console.WriteLine(p2.GetHashCode());

        var p2_copy = new csPearl(p2);
        Console.WriteLine(p2_copy.GetHashCode());

        Console.WriteLine(p2_copy.Equals(p2));

        Console.WriteLine(p2_copy == p2);

        var n1 = new csNecklace(5, "my necklace");
        n1.ListOfPearls.Sort();
        Console.WriteLine(n1);

        var n2 = new csNecklace(5, "my necklace");
        n2.ListOfPearls.Sort();
        Console.WriteLine(n2);

        Console.WriteLine(n1.Equals(n2));

        var n3 = new csNecklace(n2);

         n3.ListOfPearls[0].Size = 50;
        //n3.ListOfPearls[0] = new csPearl(rnd);
        Console.WriteLine(n2.ListOfPearls[0]);
        Console.WriteLine(n3.ListOfPearls[0]);

        //Console.WriteLine(n2.Equals(n3));

    }
}

//Exercise:
// 1. Implementera IEquatable på csPearl
// 2. Skapa två instanser av csPearl och testa om de är lika. Tips, tänk på att
//    har en copy constructor i csPearl som enkelt skapar en kopia av instansen
// 3. Implementera operator == och != overload i csPearl och använd dessa i
//    jämförelsen
// 4. Implementera IComparable på csPearl, skapa ett halsband med 100 pärlor.
//    och sortera halsbandet först efter pärlornas storlek och sedan form 
// 5. Implementera IEqutable på csNecklace
// 6. Skapa en copy constructor i csNecklace
// 7. Skapa två instanser av csNecklace och testa om de är lika. 

// 8. Ni som är snabba gör 1 -7  med csWine och cswineCellar.
//    sortera vinerna efter distrikt och sedan pris.


