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

    public CheckerChainOfResponsability(LengthChecker ck0, IntegerChecker ck1, PositiveChecker ck2)
    {
        ck0.SetSuccessor(ck1);
        ck1.SetSuccessor(ck2);
        ck2.SetSuccessor(null);
        _chain = ck0;
    }

    public CheckerChainOfResponsability(IList<Checker> cks)
    {
        for (int c = 0; c < (cks.Count - 1); c++)
        {
            cks[c].SetSuccessor(cks[c + 1]);
	    }
        cks.Last().SetSuccessor(null);

        _chain = cks[0];
    }
}