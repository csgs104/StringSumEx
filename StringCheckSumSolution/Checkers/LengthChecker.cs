using System;
using StringCheckSumSolution;

namespace StringCheckSumSolution.Checkers;

public class LengthChecker : Checker
{
    public override (bool, string) CheckString(string str)
    {
        if (str.Split(',').Length == 2)
        {
            if (_successor is not null)
            {
                return _successor.CheckString(str);
            }
            return (true, "Two Strings");
        }
        return (false, "Not Two Strings");
    }
}