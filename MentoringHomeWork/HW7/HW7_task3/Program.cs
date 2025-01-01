var someText = "gdfgdf234dg54gf*23oP42";

var number = string.Empty;
var number2 = string.Empty;
var sum = 0;

for (int i = 0; i < someText.Length; i++)
{
    if (char.IsDigit(someText[i]))
    {
        number = number + someText[i];
    }
    else if (someText[i] == '*')
    {
        for (int j = i + 1; j < someText.Length; j++)
        {
            if (char.IsDigit(someText[j]))
            {
                number2 = number2 + someText[j];
            }
        }
        break;
    }
}

sum = Convert.ToInt32(number) * Convert.ToInt32(number2);
Console.WriteLine(sum);