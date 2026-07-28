public class QuestionGenerator
{
    private static readonly Dictionary<Operation, Func<BaseOperation>> operation = new Dictionary<Operation, Func<BaseOperation>>()
    {
        [Operation.Addition] = () => new AdditionOperation(),
        [Operation.Subtraction] = () => new SubtractionOperation(),
        [Operation.Multiplication] = () => new MultiplicationOperation(),
        [Operation.Division] = () => new DivisionOperation(),
    };
    public List<BaseOperation> GenerateQuestions(Operation chosenOp)
    {
        if (!operation.TryGetValue(chosenOp, out var createOperation))
        {
            throw new Exception("specified function is not there");
        }

        List<BaseOperation> questions = new List<BaseOperation>();
        for (int i = 0; i < 5; i++)
        {
            questions.Add(createOperation());
        }

        return questions;
    }
}