namespace Task1.Calculate;

public class Calculator
{
     public void Plus()
     {
         Console.WriteLine("Please enter a number: ");

         if (int.TryParse(Console.ReadLine(), out var number))
         {
             Console.WriteLine("Please enter a number: ");

             if (int.TryParse(Console.ReadLine(), out var number2))
             {
                 var result = number + number2;
                 Console.WriteLine("Result: " + result);
             }
             else
             {
                 Console.WriteLine("Error,incorrect number");
                 Plus();
             }
         }
         else
         {
             Console.WriteLine("Error,incorrect number");
             Plus();
         }
     }
}

