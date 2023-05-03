using System;

namespace StringCheckSumSolution;

public interface IChecker
{
    public (bool, string) CheckString(string str);
}