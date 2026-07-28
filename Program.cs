public class Program
{
    public static void Main(String[] args)
    {
        MathQuizApp App = new MathQuizApp(new UserGameInteract(),
                                          new HandleUserChoice(
                                            new QuestionGenerator(), 
                                            new HandleGame()));
        App.Run();
    }
}