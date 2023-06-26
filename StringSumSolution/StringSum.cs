namespace StringSumSolution;

public class StringSum
{
    private readonly string? _numbers;
    private readonly int? _sum;

    public string? Numbers { get => _numbers; }
    public int? Sum { get => _sum; }

    public StringSum(string? numbers, int? sum)
    {
        _numbers = numbers;
        _sum = sum;
    }

    public override string ToString() => $"{nameof(Numbers)}: {Numbers} => {nameof(Sum)}: {Sum}";
}