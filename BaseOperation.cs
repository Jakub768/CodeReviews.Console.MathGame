public abstract class BaseOperation
{
    protected static readonly Random _Random = new Random();
    public int firstNumber {get; protected set;}
    public int secondNumber {get; protected set;}
    public abstract int result { get; }
    public abstract string operatorSymbol { get; }

    public BaseOperation()
    {
        firstNumber = _Random.Next(1,11);
        secondNumber = _Random.Next(1,11);
    }
    
}

public class AdditionOperation : BaseOperation
{
    public override string operatorSymbol => "+";
    public override int result => firstNumber + secondNumber;
}

public class SubtractionOperation : BaseOperation
{
    public override string operatorSymbol => "-";
    public override int result => firstNumber - secondNumber;
}

public class MultiplicationOperation : BaseOperation
{
    public override string operatorSymbol => "*";
    public override int result => firstNumber * secondNumber;
}

public class DivisionOperation : BaseOperation
{
    public override int result => firstNumber / secondNumber;
    public override string operatorSymbol => "/";

    public DivisionOperation()
    {
        secondNumber = _Random.Next(1,11);
        int quotient = _Random.Next(1,11);

        firstNumber = secondNumber * quotient;
    }

}