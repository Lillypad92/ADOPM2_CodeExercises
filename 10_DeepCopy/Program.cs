using System;
using System.ComponentModel;
using Helpers;

namespace DeepCopy;
class Program
{
    static void Main(string[] args)
    {
        var rnd = new csSeedGenerator();

        IPerson aFriend = new csPerson().Seed(rnd);
        Console.WriteLine(aFriend);

        //Shallow copy of a friend
        IPerson anotherFriend = aFriend;
        Console.WriteLine(anotherFriend);

        aFriend.FirstName = "Donald";
        aFriend.LastName = "Duck";
        Console.WriteLine(anotherFriend);

        //Write code for Deep copy of afriend into anotherFriend
        //Your code


        //List of persons
        csPerson[] persons = new csPerson[20];
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new csPerson().Seed(rnd);
        }

        //Shallow list copy
        csPerson[] people = new csPerson[20];
        Array.Copy(persons, people, persons.Length);

        persons[0].FirstName = "Donald";
        persons[0].LastName = "Duck";
        Console.WriteLine(persons[0]);
        Console.WriteLine(people[0]);

        //write code for Deep list copy of list
        //Your code

      }
}


//Exercises:

//1. In Person.cs, write a Seed() method that initiates a class with random data
//2. In Person.cs, Write a copy constructor
//3. In Program.cs, Make a deep copy of aFriend
//4. In Program.cs, Make a deep copy of persons

