using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class IntegerChecker : Checker
{
    public override (bool, string) CheckString(string[] strs)
    {
        if (int.TryParse(strs[0], out _) && int.TryParse(strs[1], out _))
        {
            if (_successor is not null)
            {
                return _successor.CheckString(strs);
            }
            return (true, "Two Numbers");
        }
        return (false, "Not Two Numbers");
    }
}