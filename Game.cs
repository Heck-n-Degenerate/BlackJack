namespace blackjack;

public class Game
{
public Game()
{
    Deck Deck = new Deck();
    Deck.Shuffle();

    List<Card> PlayerHand = new List<Card>();
    PlayerHand.Add(new Card(Deck.DrawCard()));


    List<Card> DealerHand = new List<Card>();
    DealerHand.Add(new Card(Deck.DrawCard()));

    DisplayHand(PlayerHand);

    

    
}
void DisplayHand(List<Card> Hand)
    {
    int i = 0;
    Console.WriteLine("Cards in Hand: ");
        foreach (Card cards in Hand)
        {
            Console.WriteLine("\t" + Hand[i].name);
            i++;
        }
    }

int EvaluateHand(List<Card> Hand)
    {
        int bestValue = 0;
        return bestValue;
    }

}