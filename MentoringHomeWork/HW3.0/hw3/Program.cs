// See https://aka.ms/new-console-template for more information

using HW3.HW_Calculator;

var calc = new Calculator();

Console.WriteLine("Please enter a NUMBER:");
string num1 = Console.ReadLine();

Console.WriteLine("Please enter a NUMBER:");
string num2 = Console.ReadLine();

Console.WriteLine("Please enter a NUMBER for Radius:");
string radius = Console.ReadLine();
calc.Plus(num1, num2);
calc.Minus(num1, num2);
calc.Dividing(num1, num2);
calc.Multiplication(num1, num2);
calc.Remainder(num1, num2);
calc.Circle(radius);