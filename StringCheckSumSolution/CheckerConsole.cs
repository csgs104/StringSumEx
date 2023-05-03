using System;

namespace StringCheckSumSolution;

public static class CheckerConsole
{
    public static void WriteLine(string str) 
    {
        Console.Write("StringSum: ");
        try
        {
            Console.WriteLine(CheckerHandler.Sum(str));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}