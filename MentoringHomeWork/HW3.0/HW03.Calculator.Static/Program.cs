using HW3.HW_Calculator;


class program
{
     static void Main()
    {
        
        Console.WriteLine("Введите число:");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите число:");
        string num2 =  Console.ReadLine();
        Console.WriteLine("Введите радиус:");
        string radius = Console.ReadLine();
        Calculator.Multiplication(num1,num2);
        Calculator.Remainder(num1,num2);
        Calculator.Dividing(num1,num2);
        Calculator.Circle(radius);
        Calculator.Minus(num1,num2);
        Calculator.Plus(num1,num2);
    
    }
}