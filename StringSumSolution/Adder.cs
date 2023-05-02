using System;

namespace StringSumSolution;

public abstract class Adder
{
    protected Adder? _successor;

    public void SetSuccessor(Adder successor)
    {
        _successor = successor;
    }

    public abstract StringSum ProcessStringSum(string str);
}

