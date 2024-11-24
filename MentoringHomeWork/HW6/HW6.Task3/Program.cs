int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < arrayInt.Length / 2; i++)
{
    var saveNumber = arrayInt[i];
    arrayInt[i] = arrayInt[arrayInt.Length - 1 - i];
    arrayInt[arrayInt.Length - 1 - i] = saveNumber;
}

foreach (var t in arrayInt)
{
    Console.Write(t + " ");
}