using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class NumberChecker : Checker
{
    public override (bool, string) CheckString(string str)
    {
        var strs = str.Split(',');

        if (int.TryParse(strs[0], out _) && int.TryParse(strs[1], out _))
        {
            if (_successor is not null)
            {
                return _successor.CheckString(str);
            }
            return (true, "Two Numbers");
        }
        return (false, "Not Two Numbers");
    }
}