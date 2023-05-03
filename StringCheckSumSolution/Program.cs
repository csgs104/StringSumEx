using StringCheckSumSolution;

Console.WriteLine("Hello.");



Console.Write("StringSum: ");
try 
{
    Console.WriteLine(CheckerHandler.StringSum("1")); 
}
catch(Exception e) {
    Console.WriteLine(e.Message);
}

Console.WriteLine($"StringSum: {}");
Console.WriteLine($"StringSum: {CheckerHandler.StringSum("1,")}");
Console.WriteLine($"StringSum: {CheckerHandler.StringSum("1,a")}");
Console.WriteLine($"StringSum: {CheckerHandler.StringSum("1,-1")}");
Console.WriteLine($"StringSum: {CheckerHandler.StringSum("1,1")}");

Console.WriteLine("Bye.");
