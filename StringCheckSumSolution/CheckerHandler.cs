using System;

namespace StringCheckSumSolution;

public static class CheckerHandler
{
    public static int? StringSum(string str)
    {
        var checker = new CheckerChainOfResponsability().Chain;
	    var check = checker.CheckString(str);

        if (!check.Item1) 
	    {
            Console.WriteLine(check.Item2);
            return null;
            // throw new Exception(check.Item2); 
        }

        return str.Split(',').Select(s => int.Parse(s)).Sum();
    }
}