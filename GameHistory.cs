
public interface IGameHistory
{
    List<BaseOperation> savedQuestions { get; set; }

    void SaveQuestions(List<BaseOperation> Questions);
}

public class GameHistory : IGameHistory
{
    public List<BaseOperation> savedQuestions { get; set; } = new List<BaseOperation>();

    public void SaveQuestions(List<BaseOperation> Questions)
    {
        foreach (var q in Questions)
        {
            savedQuestions.Add(q);
        }
    }

    public override string ToString()
    {
        return string.Join("\n", savedQuestions.Select(qstn => $"{qstn.firstNumber} {qstn.operatorSymbol} {qstn.secondNumber} = {qstn.result}"));
    }
}