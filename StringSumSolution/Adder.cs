namespace StringSumSolution;

public abstract class Adder : IAdder
{
    protected Adder? _successor;

    public void SetSuccessor(Adder successor)
    {
        _successor = successor;
    }

    public abstract StringSum ProcessStringSum(string str);
}