using System.Security;

namespace Task3.Sum3;

public class Sum3
{
    public void Task3()
    {
        var result = 0;
        Getnumber();
        CheckSum();
        return;
        
        void Getnumber()
        {
            Console.WriteLine("Please enter the first number: ");

            if (int.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine("Please enter the second number: ");

                if (int.TryParse(Console.ReadLine(), out var number2))
                {
                    result = number + number2;
                }
                else
                {
                    Console.WriteLine("Error, incorrect input for the second number. Please try again.");
                    Task3();
                }
            }
            else
            {
                Console.WriteLine("Error, incorrect input for the first number. Please try again.");
                Task3();
            }
        }

        void CheckSum()
        {
            Console.WriteLine("What do you think the sum is? ");
            if (int.TryParse(Console.ReadLine(), out var resultSum))
            {
                if (resultSum < result)
                {
                    Console.WriteLine("There should be more");
                    CheckSum();
                }
                else if (resultSum > result)
                {
                    Console.WriteLine("There should be less");
                    CheckSum();
                }
                else if (result != resultSum)
                {
                    Console.WriteLine("Incorrect, please try again.");
                    Task3(); 
                }
                else
                {
                    Console.WriteLine("Correct! The result is: " + result);
                }
                
            }
            else
            {
                Console.WriteLine("Error, incorrect input for the sum. Please try again.");
                Task3(); 
            }
        }
    }
}