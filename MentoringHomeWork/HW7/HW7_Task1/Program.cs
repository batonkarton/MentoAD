Console.WriteLine("Enter a poem in one line, separating the lines with semicolons.");

string text = Console.ReadLine();
text.ToUpper();

string[] arrayResultText = text.Split(';');

for (int i = 0; i < arrayResultText.Length; i++)
{
    if (arrayResultText[i] == "o")
    {
        arrayResultText[i] = "a";
    }else if (arrayResultText[i] == "о")
    {
        arrayResultText[i] = "а";
    }
}

foreach (var item in arrayResultText)
{
    Console.WriteLine(item);
}
