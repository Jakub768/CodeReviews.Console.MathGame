public interface IScoreManager
{
    int score {get; set;}
}

public class ScoreHandler : IScoreManager
{
    public int score { get; set;}
}