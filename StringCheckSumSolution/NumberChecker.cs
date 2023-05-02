using System;

namespace StringCheckSumSolution;

public class NumberChecker : Checker
{
    public override (bool, string) ProcessString(string str)
    {
        var strs = str.Split(',');

        if (int.TryParse(strs[0], out _) && int.TryParse(strs[1], out _))
        {
            return (true, "Two Numbers");
        }
        if (_successor is not null)
        {
            return _successor.ProcessString(str);
        }
        return (false, "Not Two Numbers");
    }
}
