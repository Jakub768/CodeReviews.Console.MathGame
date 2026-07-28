public class Program
{
    public static void Main(String[] args)
    {
        QuestionGenerator gen = new QuestionGenerator();
        var qst = gen.GenerateQuestions(Operation.Addition);

        foreach (var q in qst)
        {
            Console.WriteLine($"{q.firstNumber} {q.secondNumber} {q.result}");
        }
    }
}