public class Stage
{
    public IComparer<Card> CardComparer { get; set; }
    public Stage(IComparer<Card> cardComparer)
    {
        CardComparer = cardComparer;
    }

    public void Play()
    {

    }
}