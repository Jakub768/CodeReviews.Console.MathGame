public class HandleUserChoice
{
    QuestionGenerator _questionGenerator;
    HandleGame _gameHandler;

    public HandleUserChoice(QuestionGenerator questionGenerator, HandleGame gameHandler)
    {
        _questionGenerator = questionGenerator;
        _gameHandler = gameHandler;
    }
    public void displayHistory()
    {
        // display history of games from class GameHistory
    }

    public void initGame(Operation op)
    {
        List<BaseOperation> questions = _questionGenerator.GenerateQuestions(op);
        _gameHandler.Play(questions);
    }
}