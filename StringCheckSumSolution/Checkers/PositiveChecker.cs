using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class ParseChecker : Checker
{
    public override (bool, string) CheckString(string[] strs)
    {
        if (int.Parse(strs[0]) > 0 && int.Parse(strs[1]) > 0)
        {
            if (_successor is not null)
            {
                return _successor.CheckString(strs);
            }
            return (true, "Two Positive Numbers");
        }
        return (false, "Not Two Positive Numbers");
    }
}