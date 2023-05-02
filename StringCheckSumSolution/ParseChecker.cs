using System;

namespace StringCheckSumSolution;

public class ParseChecker : Checker
{
    public override (bool, string) ProcessString(string str)
    {
        var strs = str.Split(',');

        if (int.Parse(strs[0]) > 0 && int.Parse(strs[1]) > 0)
        {
            return (true, "Two Positive Numbers");
        }
        if (_successor is not null)
        {
            return _successor.ProcessString(str);
        }
        return (false, "Not Two Positive Numbers");
    }
}
