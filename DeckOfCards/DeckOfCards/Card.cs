namespace DeckOfCards
{
    public class Card
    {
        // Enum to restrict valid card values
        public enum CardValue
        {
            Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }

        // Enum to restrict valid suits
        public enum Suits
        {
            Hearts, Diamonds, Clubs, Spades
        }

        // Properties for each card
        public CardValue Value { get; }
        public Suits Suit { get; }

        // Constructor assigns value & suit to a new card
        public Card(CardValue value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        // Override ToString to print cards in readable format
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
