using Helpers;

namespace _00_Persons;

public class csPerson
{
    public string FirstName { get; init; }
    public string LastName { get; set; }

    public DateTime BirthDay { get; set; }


    public override string ToString() => $"{FirstName} {LastName} was born on {BirthDay:D}";
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, 01_Friends!");

        //Create a generator, inherited from .NET Random
        var rnd = new csSeedGenerator();



        List<csPerson> _friends = new List<csPerson>();

        for (int i = 0; i < 5_000; i++)
        {
            _friends.Add(new csPerson()
            {
                FirstName = rnd.FirstName,
                LastName = rnd.LastName,
                BirthDay = rnd.DateAndTime(1970, 2020)
            });
        }

        Console.WriteLine();
        Console.WriteLine(_friends.Count);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(_friends[i]);
        }

        Console.ReadKey();

    }
}

// Exercises
// 1. Create a list of 100 000 Friends with firstname, lastname and birthays between 1970 and 2020

