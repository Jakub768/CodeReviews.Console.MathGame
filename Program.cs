public class Program
{
    public static void Main(String[] args)
    {

        IGameHistory gameHistory = new GameHistory();
        
        MathQuizApp App = new MathQuizApp(new UserGameInteract(),
                                          new HandleUserChoice(
                                            new QuestionGenerator(
                                                gameHistory), 
                                            new HandleGame(
                                                new ScoreHandler()),
                                            gameHistory));
        App.Run();
    }
}