namespace blackjack;
public class Deck
{
    Random random = new Random();
    
    public List<int> deckList = new List<int>();
    public void Shuffle()
    {
    deckList.AddRange(Enumerable.Range(1, 52));
    Console.WriteLine("Deck has been Shuffled.");
    }
    
    public int DrawCard()
    {
    if (deckList.Count < 1)
        {
            Shuffle();
        }
    
    int listIndex = random.Next(deckList.Count);
    int deckIndex = deckList[listIndex];
    deckList.RemoveAt(listIndex);

    return deckIndex;

    }
}