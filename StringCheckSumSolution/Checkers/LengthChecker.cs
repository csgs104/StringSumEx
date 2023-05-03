using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class LengthChecker : Checker
{
    public override (bool, string) CheckString(string[] strs)
    {
        if (strs.Length == 2)
        {
            if (_successor is not null)
            {
                return _successor.CheckString(strs);
            }
            return (true, "Two Strings");
        }
        return (false, "Not Two Strings");
    }
}