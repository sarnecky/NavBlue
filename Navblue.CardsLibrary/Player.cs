public class Player
{
    private readonly string _name;
    public IReadOnlyCollection<Card> Cards { get; set; }
    public Player(string name)
    {
        _name = name;
    }

}