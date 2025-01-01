StartProgram();

void StartProgram()
{
    DeleteTheLongestWord();
    SwapLongWithShortWord();
    Count();
    SortsTheArrayFromLargestToSmallest();
}

void DeleteTheLongestWord()
{
    var someText = "Hello World my friend";

    string[] arrayText = someText.Split(' ');

    var maxCount = 0;
    string longestWord = "";
    var indexOfLongestWord = 0;

    for (int j = 0; j < arrayText.Length; j++)
    {
        var count = arrayText[j].Length;
        
        if (count > maxCount)
        {
            maxCount = count;
            longestWord = arrayText[j];
            indexOfLongestWord = j;
        }
    }

    for (int i = 0; i < arrayText.Length; i++)
    {
        if (indexOfLongestWord != i)
        {
            Console.Write("{0} ", arrayText[i]);
        }
    }
}

void SwapLongWithShortWord()
{
    var someText = "Hello World my friend";

    string[] arrayText = someText.Split(' ');
    
    var longestWordIndex = 0;
    var shortWordIndex = 0;
    var maxCount = 0;
    
    for (int i = 0; i < arrayText.Length; i++)
    {
        var count = arrayText[i].Length;

        if (count > maxCount)
        {
            maxCount = count;
            longestWordIndex = i;
        }

        if (count < maxCount)
        {
            shortWordIndex = i;
        }
    }

    var temp = arrayText[shortWordIndex];
    arrayText[shortWordIndex] = arrayText[longestWordIndex];
    arrayText[longestWordIndex] = temp;
    
    foreach (var i in arrayText)
    {
        Console.Write(i + " ");
    }
}

void Count()
{
    var someText = "Hello,World,my friend";
    
    char[] lines = someText.ToArray();
    
    var count = 0;
    
    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i] == ' ')
        {
            continue;
        }

        count++;
    }

    Console.WriteLine(count);
}

void SortsTheArrayFromLargestToSmallest()
{
    var someText = "Hello World my friend ";

    string[] arrayText = someText.Split(" ");

    for (int i = 0; i < arrayText.Length - 1; i++)
    {
        for (int j = i + 1; j < arrayText.Length; j++)
        {
            
            var value = arrayText[i];
            var value2 = arrayText[j];
            var check = string.Empty;
            
            if (arrayText[i].Length < arrayText[j].Length)
            {
                check = arrayText[i];
                arrayText[i] = arrayText[j];
                arrayText[j] = check;
            }
        }
    }

    foreach (var i in arrayText)
    {
        Console.Write(i);
    }
}