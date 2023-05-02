using System;

namespace StringCheckSumSolution;

public abstract class Checker
{
    protected Checker? _successor;

    public void SetSuccessor(Checker? successor)
    {
        _successor = successor;
    }

    public abstract (bool, string) ProcessString(string str);
}