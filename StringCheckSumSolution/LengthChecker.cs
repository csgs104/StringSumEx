using System;

namespace StringCheckSumSolution;

public class LengthChecker : Checker
{
    public override (bool, string) ProcessString(string str)
    {
        if (str.Split(',').Length == 2)
        {
            return (true, "Two Strings");
        }
        if (_successor is not null)
        {
            return _successor.ProcessString(str);
        }
        return (false, "Not Two Strings");
    }
}

