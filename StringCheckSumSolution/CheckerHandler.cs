using System;

namespace StringCheckSumSolution;

public static class CheckerHandler
{
    public static int Sum(string[] strs)
    {
        var ck = (new CheckerChainOfResponsability().Chain).CheckString(strs);
        return ck.Item1 ? strs.Sum(s => int.Parse(s)) : throw new Exception(ck.Item2);
    }

    public static int Sum(string str, string separator = ",")
    {
        return Sum(str.Split(separator));
    }
}