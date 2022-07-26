Library contains files:
Game.cs - abstract class, which should be used to creating new instance of game. There is a possibility to shuffle cards, deal cards between players, start game and sort cards. In start game, we can iterate between game stages. 

Card.cs - class that represents Card, with possibility to compare between cards with different comparers

Player.cs - player represents players with name and cards on hands

Rank.cs and Suit.cs - enums that represent each values of Rank and Suit

Stage.cs - stage represents different stages that are presented during game

there is an example implementation

var game = new WarGame(
    new List<Player> { new("Sebastian") },
    new List<Stage> { new(new Stage2Comparer()) },
    new List<Card>
    {
        new(Rank.Queen, Suit.Club, new CardComparer()),
        new(Rank.Ace, Suit.Club, new CardComparer()),
        new(Rank.King, Suit.Club, new CardComparer()),
    },
    new CardComparer());

game.Shuffle();
game.DealCards();
game.StartGame();

public class WarGame : Game
{
    public WarGame(
        IReadOnlyCollection<Player> players,
        IReadOnlyCollection<Stage> stages,
        IReadOnlyCollection<Card> cards,
        IComparer<Card> cardComparer) 
        : base(players, stages, cards, cardComparer)
    {
    }

    public override void Shuffle()
    {
        // place logic to shuffle cards
        // example
        // var random = new Random();
        // Cards = Cards.OrderBy(i => random.Next()).ToList();
    }

    public override void DealCards()
    {
        //place logic to deal cards
        //example
        // const int numberOfCardsOnHand = 4;
        // var counter = 0;
        // foreach (var player in Players)
        // {
        //     player.Cards = Cards
        //         .Skip(counter)
        //         .Take(numberOfCardsOnHand)
        //         .ToList();
        //     counter++;
        // }
    }

    public override void StartGame()
    {
        //place logic to handle entire game and use provided functionality
        SortCards(CardComparer);
        // foreach (var stage in Stages)
        // {
        //     
        // }
    }
}
public class CardComparer : Comparer<Card>
{
    public override int Compare(Card x, Card y)
    {
        // if (x.Rank == Rank.Ace && y.Rank is Rank.King or Rank.Queen or Rank.Jack)
        //     return 1;
        //
        // return 0;
        throw new NotImplementedException();
    }
}

public class Stage1Comparer : Comparer<Card>
{
    public override int Compare(Card x, Card y)
    {
        // if (x.Rank == Rank.Ace && y.Rank is Rank.King or Rank.Queen or Rank.Jack)
        //     return 1;
        //
        // return 0;
        throw new NotImplementedException();
    }
}

public class Stage2Comparer : Comparer<Card>
{
    public override int Compare(Card x, Card y)
    {
        // if (x.Rank == Rank.Ace && y.Rank is Rank.King or Rank.Queen or Rank.Jack)
        //     return 1;
        //
        // return 0;
        throw new NotImplementedException();
    }
}