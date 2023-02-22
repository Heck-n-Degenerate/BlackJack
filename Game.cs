namespace blackjack;
public class Game
{
public Game()
{
    Deck Deck = new Deck();
    Deck.Shuffle();

    List<Card> PlayerHand = new List<Card>();
    DrawFor(PlayerHand);

    List<Card> DealerHand = new List<Card>();
    DrawFor(DealerHand);


    DisplayHand(PlayerHand);
    Console.WriteLine("Hand value is: " + EvaluateHand(PlayerHand));
    PromptDraw();

    void PromptDraw()
    {
        Console.Write("Would you like to draw another card? [y/N]: ");
        string input = Console.ReadLine().ToUpper();
        switch (input)
        {
            case "Y": DrawFor(PlayerHand); PromptDraw(); break;
            default:     
                DisplayHand(PlayerHand);
                Console.WriteLine("Hand value is: " + EvaluateHand(PlayerHand));
            break;
        }
    }

//Internal Methods
void DrawFor(List<Card> Hand)
    {
    Hand.Add(new Card(Deck.DrawCard()));
    }
}
void DisplayHand(List<Card> Hand)
    {
    Console.WriteLine("Cards in Hand: ");
        foreach (Card element in Hand)
        {
            Console.WriteLine("\t~" + element.name);
        }
    }
int EvaluateHand(List<Card> Hand)
    {
        int bestValue = 0;
        bool hasAce = false;

        foreach (Card element in Hand) {
            if (element.value == "A") {
                hasAce = true;
            }
        }

        if (hasAce == true)
        {
        return -1;
        }
        else
        {
        foreach (Card element in Hand)
        {
            bestValue = bestValue + Convert.ToInt32(element.value);
        }
        return bestValue;
        }
    }
}
