using System;
namespace StringSumSolution;

public class PositiveAdder : Adder
{
    public override StringSum ProcessStringSum(string str)
    {
        var strs = str.Split(new[] {",", ";", Environment.NewLine}, StringSplitOptions.None);
        var vs = strs.Select(s => new { B = int.TryParse(s, out int n), N = n });

        if (!vs.Any(v => v.B == false || v.N < 0))
        {
            return new StringSum(str, vs.Sum(v => v.N));
        }
	    if (_successor is not null)
        {
            return _successor.ProcessStringSum(str);
        }
        return new StringSum(str, null);
    }
}