Console.WriteLine("Enter a poem in one line, separating the lines with semicolons.");

string text = Console.ReadLine().ToUpper();

var arrayResultText = text.Split(';');

for (int i = 0; i < arrayResultText.Length; i++)
{
    arrayResultText[i] = arrayResultText[i].Replace("O", "A").Replace("О", "А");
    
    foreach (var c in arrayResultText[i])
    {
        if ( !char.IsLetter(c))
        {
            Console.WriteLine("Uncorrected poem!");
            return ;
        }
    }
}

foreach (var item in arrayResultText)
{
    Console.WriteLine(item);
}
