public abstract class Game
{
    protected IReadOnlyCollection<Player> Players;
    protected IReadOnlyCollection<Stage> Stages;
    protected IReadOnlyCollection<Card> Cards;
    protected IComparer<Card> CardComparer;

    protected Game(
        IReadOnlyCollection<Player> players,
        IReadOnlyCollection<Stage> stages,
        IReadOnlyCollection<Card> cards,
        IComparer<Card> cardComparer)
    {
        Players = players;
        Stages = stages;
        Cards = cards;
        CardComparer = cardComparer;
    }

    public abstract void Shuffle();

    public abstract void DealCards();

    public abstract void StartGame();

    public void SortCards(IComparer<Card> sortComparer) =>
        Cards = Cards
            .OrderBy(i => i, sortComparer)
            .ToList();
}