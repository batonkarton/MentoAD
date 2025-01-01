var someText = "gdfgdf234dg54gf/23oP42";

var number = string.Empty;
var number2 = string.Empty;
char operation = ' ';

for (int i = 0; i < someText.Length; i++)
{
    if (char.IsDigit(someText[i]))
    {
        number += someText[i];
    } 
    if (someText[i] == '*' || someText[i] == '+' || someText[i] == '-' || someText[i] == '/')
    {
        operation = someText[i];
        for (int j = i + 1; j < someText.Length; j++)
        {
            if (char.IsDigit(someText[j]))
            {
                number2 += someText[j];
            }
        }
        break;
    }
}

var num1 = Convert.ToInt32(number); 
var num2 = Convert.ToInt32(number2);

var sum = operation switch
{
    '+' => num1 + num2,
    '-' => num1 - num2,
    '*' => num1 * num2,
    '/' => num1 / num2,
    _ => 0
};

Console.WriteLine(sum);