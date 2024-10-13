namespace MentoringHomeWork.HW2;

/// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        StreamReader textReader = new StreamReader(@"/Users/lexadior/Documents/MentoAD/MentoringHomeWork/HW2/HW2.0/image.txt", true);
        string textReaderResult = textReader.ReadToEnd();
        string[] arrayOfTextResult = textReaderResult.Split(' ');
        textReader.Dispose();
        byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
        for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
        {
            byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
            imageBytes[i] = binary;
        }
        File.WriteAllBytes(@"/Users/lexadior/Documents/MentoAD/MentoringHomeWork/HW2/HW2.0/image100.png", imageBytes);
    }
}