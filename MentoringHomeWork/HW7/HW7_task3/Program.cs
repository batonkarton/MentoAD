var someText = "gdfgdf234dg54gf*23oP42";

var someTextSplit = someText.Split('+','-','*','/');

var number = string.Empty;
var number2 = string.Empty;

foreach (var ch in someTextSplit[0])
{
    if (char.IsNumber(ch))
        
    {
        number += ch;
    }
}

foreach (var ch2 in someTextSplit[1])
{
    if (char.IsNumber(ch2))
    {
        number2 += ch2;
    }
}

switch (true)
{
    case bool plus when someText.Contains("+"):
        Console.WriteLine(int.Parse(number) + int.Parse(number2));
        break;
    case bool minus when someText.Contains("*"):
        Console.WriteLine(int.Parse(number) - int.Parse(number2));
        break;
    case bool multiply when someText.Contains("-"):
        Console.WriteLine(int.Parse(number) * int.Parse(number2));
        break;
    case bool divide when someText.Contains("/"):
        Console.WriteLine(int.Parse(number) / int.Parse(number2));
        break;
}