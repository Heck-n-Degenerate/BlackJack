namespace blackjack;
public class Card
{
    public int rawIndex;
    public string suit;
    public string type;
    public string name;
    public string value;
    public Card(int x)
    {
        rawIndex = x;

        int rawSuit = 1;

        while (rawIndex > 13)
        {
            rawSuit++;
            rawIndex = rawIndex - 13;
        }
            int rawType = rawIndex;

        switch (rawSuit)
        {
            case 1: suit = "Clubs";
                break;

            case 2: suit = "Hearts";
                break;

            case 3: suit = "Spades";
                break;

            case 4: suit = "Diamonds";
                break;

            default: Console.WriteLine("Error, switch suit defaulted.");
                break;
        }

        switch (rawType)
        {
            case 1:     value = "A";    type = "Ace";
                break;
            case 2:     value = "2";    type = "Two";
                break;
            case 3:     value = "3";    type = "Three";
                break;
            case 4:     value = "4";    type = "Four";
                break;
            case 5:     value = "5";    type = "Five";
                break;
            case 6:     value = "6";    type = "Six";
                break;
            case 7:     value = "7";    type = "Seven";
                break;
            case 8:     value = "8";    type = "Eight";
                break;
            case 9:     value = "9";    type = "Nine";
                break;
            case 10:     value = "10";    type = "Ten";
                break;
            case 11:     value = "10";    type = "Jack";
                break;
            case 12:     value = "10";    type = "Queen";
                break;
            case 13:     value = "10";    type = "King";
                break;
            default:    Console.WriteLine("Error, switch type defaulted.");
                break;
        }

        name = type + " of " + suit + ".";
    }
}
