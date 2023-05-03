using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class ParseChecker : Checker
{
    public override (bool, string) CheckString(string str)
    {
        var strs = str.Split(',');

        if (int.Parse(strs[0]) > 0 && int.Parse(strs[1]) > 0)
        {
            if (_successor is not null)
            {
                return _successor.CheckString(str);
            }
            return (true, "Two Positive Numbers");
        }
        return (false, "Not Two Positive Numbers");
    }
}