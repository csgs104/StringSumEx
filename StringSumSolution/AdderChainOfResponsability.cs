using System;
using System.IO;

namespace StringSumSolution;

public class AdderChainOfResponsability
{
    private readonly Adder _chain;

    public Adder Chain{ get => _chain; }

    public AdderChainOfResponsability()
    {
        var adder0 = new StupidAdder();
        var adder1 = new SimplePositiveAdder();
        var adder2 = new SimplePositiveCommaAdder();
        var adder3 = new PositiveCommaAdder();
        var adder4 = new PositiveAdder();
        // other adders...
        var adderFinal = new FinalAdder();

        adder0.SetSuccessor(adder1);
        adder1.SetSuccessor(adder2);
        adder2.SetSuccessor(adder3);
        adder3.SetSuccessor(adder4);
        // other adders...
        adder4.SetSuccessor(adderFinal);

        _chain = adder0;
    }
}