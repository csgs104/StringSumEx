using System;
using StringSumSolution;

namespace StringSumSolution.Adders;

public class SimplePositiveAdder : Adder
{
    public override StringSum ProcessStringSum(string str)
    {
        if (int.TryParse(str, out int res) && res > 0)
        {
            return new StringSum(str, res);
        }
        if (_successor is not null)
        {
            return _successor.ProcessStringSum(str);
        }
        return new StringSum(str, null);
    }
}