StartProgram();

void StartProgram()
{
    DeleteTheLongestWord();
    SwapLongWithShortWord();
    GetLetterAndPunctuationCount();
    SortsTheArrayFromLargestToSmallest();
}

void DeleteTheLongestWord()
{
    var someText = "Hello World my friend";

    var arrayText = someText.Split(' ');

    var maxCount = 0;
    var indexOfLongestWord = 0;

    for (int j = 0; j < arrayText.Length; j++)
    {
        var count = arrayText[j].Length;

        if (count > maxCount)
        {
            maxCount = count;
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

    var arrayText = someText.Split(' ');

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

void GetLetterAndPunctuationCount()
{
    var someText = "Hello,World,my friend";

    var lines = someText.ToArray();

    var count = 0;

    foreach (var t in lines)
    {
        if (char.IsLetter(t))
        {
            count++;
        }

        if (char.IsPunctuation(t))
        {
            count++;
        }
    }

    Console.Write($"Number of letters and punctuation : {count}\n");
}


void SortsTheArrayFromLargestToSmallest()
{
    var someText = "Hello World my friend ";

    var arrayText = someText.Split(" ");

    for (int i = 0; i < arrayText.Length - 1; i++)
    {
        for (int j = i + 1; j < arrayText.Length; j++)
        {
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

