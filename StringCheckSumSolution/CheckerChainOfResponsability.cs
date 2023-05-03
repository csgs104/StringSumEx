using System;
using StringCheckSumSolution.Checkers;

namespace StringCheckSumSolution;

public class CheckerChainOfResponsability
{
    private readonly Checker _chain;

    public Checker Chain { get => _chain; }

    public CheckerChainOfResponsability()
    {
        var checker0 = new LengthChecker();
        var checker1 = new IntegerChecker();
        var checker2 = new PositiveChecker();

        checker0.SetSuccessor(checker1);
        checker1.SetSuccessor(checker2);
        checker2.SetSuccessor(null);

        _chain = checker0;
    }
}