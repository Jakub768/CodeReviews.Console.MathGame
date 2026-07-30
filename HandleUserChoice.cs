public class HandleUserChoice
{
    QuestionGenerator _questionGenerator;
    HandleGame _gameHandler;
    IGameHistory _gameHistory;

    public HandleUserChoice(QuestionGenerator questionGenerator, HandleGame gameHandler, IGameHistory gamehistory)
    {
        _questionGenerator = questionGenerator;
        _gameHandler = gameHandler;
        _gameHistory = gamehistory;
    }
    public void displayHistory()
    {
        Console.WriteLine(_gameHistory.ToString());
    }

    public void initGame(Operation op)
    {
        List<BaseOperation> questions = _questionGenerator.GenerateQuestions(op);
        _gameHandler.Play(questions);
    }
}