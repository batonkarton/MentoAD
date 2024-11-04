namespace HW03.Calculator.Static.HW_Calculator;

public static class Calculator
{
  public static void Plus(string num1, string num2)
  {

    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    var result = number1 + number2;

    Console.WriteLine("Plus result:" + result);
  }

  public static void Minus(string num1, string num2)
  {
    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    
    var result = number1 - number2;
    
    Console.WriteLine("Minus result:" + result);
  }

  public static void Multiply(string num1, string num2)
  {
    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    
    var result = number1 * number2;
    
    Console.WriteLine("Multiplication result:" + result);
  }

  public static void Divide(string num1, string num2)
  {
    var number1 = int.Parse(num1);
    var number2 = int.Parse(num2);
    
    var result = number1 / number2;
    
    Console.WriteLine("Dividing result:" + result);
  }

  public static void CalculateTheRemainder(string num1, string num2)
  {
    var number1 = int.Parse(num1);
    var number2 = int.Parse(num2);
    
    var result = number1 % number2;
    
    Console.WriteLine("Remainder result:" + result);
  }

  public static void CalculateTheCircle(string radius)
  {
    var parsedRadius = int.Parse(radius);
    var result = Math.PI * parsedRadius * parsedRadius;
    
    Console.WriteLine("Circle result:" + result);
  }
}