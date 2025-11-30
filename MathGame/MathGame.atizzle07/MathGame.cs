namespace MathGame;

public class Game
{
    public int ID {get; set;}
    public string? Player { get; set; }
    public int Num1 { get; set; }
    public int Num2 { get; set; }
    public OperationType Operation { get; set; }
    public string? Result { get; set; }
    //TODO - add in resulting points
}

public enum OperationType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

public class GameHistory
{
    public List<Game> Games { get; set; }

    public GameHistory()
    {
        Games = new List<Game>();
    }

    public void AddGameItem(Game game)
    {
        Games.Add(game);
    }

    public void ClearHistory()
    {
        Games.Clear();
    }

    public void DisplayItems()
    {
        Console.WriteLine("ID\tPlayer\tNum1\tNum2\tOperation\tResult"); //Header info
        Console.WriteLine("----\t----\t----\t----\t----\t\t----"); //Lines under headers
        foreach (var item in Games)
        {
            Console.WriteLine($"{item.ID}\t" +
                              $"{item.Player}\t" +
                              $"{item.Num1}\t" +
                              $"{item.Num2}\t" +
                              $"{item.Operation}\t" +
                              $"{item.Result}\t");
        }
    }
}