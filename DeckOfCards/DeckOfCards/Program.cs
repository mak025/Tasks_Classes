using System;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create an array for 52 cards
            Card[] deck = new Card[52];
            // Step 2: Get all possible values from enums
            Card.Suits[] suits = (Card.Suits[])Enum.GetValues(typeof(Card.Suits));
            Card.CardValue[] values = (Card.CardValue[])Enum.GetValues(typeof(Card.CardValue));
            // Step 2.2 Create random generator object
            Random r = new Random();

            // Step 3: Generate all 52 cards
            int counter = 0;
            for (int i = 0; i < values.Length; i++)  // Loop through values (2 - Ace)
            {
                for (int j = 0; j < suits.Length; j++)  // Loop through suits (Hearts - Spades)
                {
                    deck[counter] = new Card(values[i], suits[j]); // Create new card
                    counter++; // Increase counter
                }
            }
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = r.Next(0, i + 1);
                (deck[i], deck[j]) = (deck[j], deck[i]);
            }
            // Step 4: Print all cards
            foreach (Card card in deck)
            {
                Console.WriteLine(card);
            }
        }
    }
}
