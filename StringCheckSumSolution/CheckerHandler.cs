using System;

namespace StringCheckSumSolution;

public static class CheckerHandler
{
    public static int StringSum(string[] strs)
    {
        var ck = (new CheckerChainOfResponsability().Chain).CheckString(strs);
        return ck.Item1 ? strs.Sum(s => int.Parse(s)) : throw new Exception(ck.Item2);
    }

    public static int StringSum(string str, string separator = ",")
    {
        return StringSum(str.Split(separator));
    }
}