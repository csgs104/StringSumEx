namespace StringSumSolution.Adders;

public class FinalAdder : Adder
{
    public override StringSum ProcessStringSum(string str)
    {
        var strs = str.Split(new[] { ",", ";", Environment.NewLine }, StringSplitOptions.None);
        var vs = strs.Select(s => new { B = int.TryParse(s, out int n), N = n });

        if (strs.Length == 0)
        {
            Console.WriteLine("Not Spittable String Exception");
            throw new Exception("Not Spittable String Exception");
        }

        if (vs.Any(v => v.B == false))
        {
            Console.WriteLine("Not Parsable String Exception");
            throw new Exception("Not Parsable String Exception");
        }

        if (vs.Any(v => v.N < 0))
        {
            Console.WriteLine("Not Positive Number Exception");
            throw new Exception("Not Positive Number Exception");
        }

        return new StringSum(str, null);
    }
}