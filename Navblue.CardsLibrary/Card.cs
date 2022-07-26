public class Card : IComparable<Card>
{
    public Card(Rank rank, Suit suit, IComparer<Card> comparer)
    {
        Rank = rank;
        Suit = suit;
        Comparer = comparer;
    }

    public Rank Rank { get; set; }
    public Suit Suit { get; set; }
    public IComparer<Card> Comparer { get; set; }

    public int CompareTo(Card? other)
        => Comparer.Compare(this, other);
}