using System;
using StringSumSolution;

namespace StringSumSolution.Adders;

public class SimplePositiveCommaAdder : Adder
{
    public override StringSum ProcessStringSum(string str)
    {
        var nums = str.Split(',');
        if (nums.Length == 2 && int.TryParse(nums[0], out int n1) && int.TryParse(nums[1], out int n2) && n1 > 0 && n2 > 0)
        {
            return new StringSum(str, n1 + n2);
        }
        if (_successor is not null)
        {
            return _successor.ProcessStringSum(str);
        }
        return new StringSum(str, null);
    }
}