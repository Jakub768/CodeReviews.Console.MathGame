public class GameHistory
{
    public static List<BaseOperation>? savedQuestions { get; set; }

    public void SaveQuestions(List<BaseOperation> Questions)
    {
        foreach (var q in Questions)
        {
            savedQuestions?.Add(q);
        }
    }
}