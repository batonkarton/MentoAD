using System;

namespace HW3.HW_Calculator;

public class Calculator
{
  public void Plus(string num1, string num2)
  {

    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    var result = number1 + number2;

    Console.WriteLine("result:" + result);
  }

  public void Minus(string num1, string num2)
  {
    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    var result = number1 - number2;
    Console.WriteLine("result:" + result);
  }

  public void Multiplication(string num1, string num2)
  {
    var number1 = Convert.ToInt32(num1);
    var number2 = Convert.ToInt32(num2);
    var result = number1 * number2;
    Console.WriteLine("result:" + result);
  }

  public void Dividing(string num1, string num2)
  {
    var number1 = int.Parse(num1);
    var number2 = int.Parse(num2);
    var result = number1 / number2;
    Console.WriteLine("result:" + result);
  }

  public void Remainder(string num1, string num2)
  {
    var number1 = int.Parse(num1);
    var number2 = int.Parse(num2);
    var result = number1 % number2;
    Console.WriteLine("result:" + result);
  }

  public void Circle(string radius)
  {
    var result = int.Parse(radius);
    double area = Math.PI * result * result; 
  }
}
 