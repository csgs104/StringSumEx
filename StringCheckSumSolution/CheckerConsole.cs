using System;

namespace StringCheckSumSolution;

public static class CheckerConsole
{
    public static void WriteLine(string str) 
    {
        Console.Write("StringSum: ");
        try
        {
            Console.WriteLine(CheckerHandler.StringSum(str));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}