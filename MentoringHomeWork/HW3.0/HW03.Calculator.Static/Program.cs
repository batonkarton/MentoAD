using HW03.Calculator.Static.HW_Calculator;

Console.WriteLine("Please enter a NUMBER:");
string num1 = Console.ReadLine();

Console.WriteLine("Please enter a NUMBER:");
string num2 = Console.ReadLine();

Console.WriteLine("Please enter a NUMBER for Radius:");
string radius = Console.ReadLine();

Calculator.Multiply(num1, num2);
Calculator.CalculateTheRemainder(num1, num2);
Calculator.Divide(num1, num2);
Calculator.CalculateTheCircle(radius);
Calculator.Minus(num1, num2);
Calculator.Plus(num1, num2);