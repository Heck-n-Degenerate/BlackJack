namespace blackjack;
public class Program
{
public static void Main()
{
    ProgramStart();

    void ProgramStart()
    {
        Console.WriteLine("To start a game, type 'play', for information on this program type 'info'.");
        ProgramIdle();
    }

    void ProgramIdle()
    {
        Console.Write("[BLACKJACK]: ");
        string input = Console.ReadLine().ToUpper();

        switch (input)
        {
            case "PLAY":
            Console.WriteLine("Playing...");
            StartGame();
                break;

            case "HELP":
            Console.WriteLine("Helping...");
            ProgramIdle();
                break;

            case "INFO":
            Console.WriteLine("Informing...");
            ProgramIdle();
                break;

            case "QUIT":
            Console.WriteLine("Quitting...");
            ProgramTerminate();
                break;

            default: Console.WriteLine("Invalid Command");
            ProgramIdle();
                break;
        }
    }

    void StartGame()
    {
        Game Game = new Game();
        ProgramIdle();
    }

    void ProgramTerminate() {/*ends program*/}
    
    //Method for each game state

    //ProgramStart()
        // > ProgramIdle
    //ProgramIdle()
        //  start game
        //  help
        //  quit game

    //GameStart()
        // > NewRound();    

    //PromptDraw()

    //PromptEndTurn()

    //DealersTurn()

    //RoundResult()

    //PromptStartNextRound
        //  yes > NewRound();
        // no > ProgramIdle();

    //NewRound()
}
}
