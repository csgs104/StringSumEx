using StringSumSolution;

Console.WriteLine("Hello.");

var div = "--- --- --- --- --- --- --- --- ---";

var adder = new AdderChainOfResponsability().Chain;

Console.WriteLine(div);

Console.WriteLine("TEST1");

var ss0 = "";
var ss1 = "1";
var ss2 = "1,2";
var ss3 = "1,2,3";
var ss4 = "1,2\n3;4";

var ss0r = adder.ProcessStringSum(ss0);
var ss1r = adder.ProcessStringSum(ss1);
var ss2r = adder.ProcessStringSum(ss2);
var ss3r = adder.ProcessStringSum(ss3);
var ss4r = adder.ProcessStringSum(ss4);

Console.WriteLine($"case 0: {ss0r}");
Console.WriteLine($"case 1: {ss1r}");
Console.WriteLine($"case 2: {ss2r}");
Console.WriteLine($"case 3: {ss3r}");
Console.WriteLine($"case 4: {ss4r}");

Console.WriteLine(div);

Console.WriteLine("TEST2");

var ssf0 = "a";
var ssf1 = "1,";
var ssf2 = "1,a";
var ssf3 = "1,-2";
var ssf4 = "1,2/3";

var ssf0r = adder.ProcessStringSum(ssf0);
var ssf1r = adder.ProcessStringSum(ssf1);
var ssf2r = adder.ProcessStringSum(ssf2);
var ssf3r = adder.ProcessStringSum(ssf3);
var ssf4r = adder.ProcessStringSum(ssf4);

Console.WriteLine($"case 0: {ssf0r}");
Console.WriteLine($"case 1: {ssf1r}");
Console.WriteLine($"case 2: {ssf2r}");
Console.WriteLine($"case 3: {ssf3r}");
Console.WriteLine($"case 4: {ssf4r}");

Console.WriteLine(div);

Console.WriteLine("TEST3");

Console.WriteLine(div);

Console.WriteLine("Bye.");