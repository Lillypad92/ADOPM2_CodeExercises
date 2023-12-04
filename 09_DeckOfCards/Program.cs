using DeckOfCards;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notice on how I use IDeckOfCards and IPlayingCard

            //Start with testing PlayingCard
            //IPlayingCard card1 = null;  //Allows compilation
            //IPlayingCard card2 = null;  //Allows compilation

            //Once PlayingCard is implemented, create an instance instead of null
            IPlayingCard card1 = new PlayingCard { Suit = PlayingCardSuit.Clubs, Value = PlayingCardValue.Ace };
            IPlayingCard card2 = new PlayingCard { Suit = PlayingCardSuit.Hearts, Value = PlayingCardValue.Ten };
            Console.WriteLine("Two playing cards:");
            Console.WriteLine(card1);
            Console.WriteLine(card2);


            //Now test DeckOfCards
            //IDeckOfCards myDeck = null; //Allows compilation

            //Once DeckOfCards is implemented, create an instance instead of null
            IDeckOfCards myDeck = new DeckOfCards();  
            Console.WriteLine($"\nFreshly created deck:");
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nSorted deck:");
            //myDeck.Sort();                  //OK once implemented
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nShuffled deck:");
            //myDeck.Shuffle();               //OK once implemented
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nCreate a hand of 5 cards:");
            IHandOfCards aHand = new HandOfCards();       //IHandOfCards aHands is fine

            //aHand.Add(myDeck.DealOne());    //OK once implemented
            //aHand.Add(myDeck.DealOne());    //OK once implemented
            //aHand.Add(myDeck.DealOne());    //OK once implemented
            //aHand.Add(myDeck.DealOne());    //OK once implemented
            //aHand.Add(myDeck.DealOne());    //OK once implemented
            Console.WriteLine(aHand);

            Console.WriteLine($"\nSorted hand of cards:");
            //aHand.Sort();                   //OK once implemented
            Console.WriteLine(aHand);

            Console.WriteLine($"\nShuffled hand of cards:");
            //aHand.Shuffle();                //OK once implemented
            Console.WriteLine(aHand);
        }
    }
}


/* Exercises
 * 
1. Modellera ett Spelkort
- Skapa ett spelkort
- Ett skapat spelkort ska inte kunna �ndras
- Skriva ut i konsolen spelkortet, typ 
  - Two of Spades, King of Hearts, Queen of Clubs, Ten of Diamonds

2. Modellera en kortlek
- Skapa en initierad kortlek med 52 kort
- Blanda korten i kortleken
- Sortera korten i kortleken
- Skriva ut alla korten i kortleken

3. Modellera en korthand
- Implemententra en class HandOfCards som implementerar IHandOfCards och �rver fr�n class DeckOfCards
- Ge 5 kort till en instans av HandOfCards och skriv ut
- Sortera korten på handen och skriv ut.
- Blanda korten på handen och skriv ut.
- Utmaning: Lägg till en metod IsQuads som returnerar true ifall handen inheh�ller 4 kort med samma v�rde (fyrtal)

*/