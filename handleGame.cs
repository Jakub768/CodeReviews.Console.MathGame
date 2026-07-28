
using System.Formats.Asn1;

public class HandleGame
{
    private const int QUESTION_AMOUNT = 5;
    private IScoreManager _scoreHandler;

    public HandleGame(IScoreManager scoreHandler)
    {
        _scoreHandler = scoreHandler;
    }
    public void Play(List<BaseOperation> questions)
    {
        int rounds = 0;

        while (rounds < QUESTION_AMOUNT)
        {
            Console.WriteLine($"{questions[rounds].firstNumber} {questions[rounds].operatorSymbol} {questions[rounds].secondNumber}");

            if (!int.TryParse(Console.ReadLine(), out int answer))
            {
                Console.WriteLine("Invalid input, please enter your answer as a number");
            } 

            if (answer == questions[rounds].result)
            {
                Console.WriteLine("correct you get a point!");
                _scoreHandler.score++;
            }
            else
            {
                Console.WriteLine("Incorrect, you do not get a point.");
            }

            rounds++;
        }

        Console.WriteLine($"That's the end of the game! you scored: {_scoreHandler.score}");
    }
}