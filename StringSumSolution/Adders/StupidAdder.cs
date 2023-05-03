using System;
using StringSumSolution;

namespace StringSumSolution.Adders;

public class StupidAdder : Adder
{
    public override StringSum ProcessStringSum(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return new StringSum(str, null);
        }
        if (_successor is not null)
        {
            return _successor.ProcessStringSum(str);
        }
        return new StringSum(str, null);
    }
}