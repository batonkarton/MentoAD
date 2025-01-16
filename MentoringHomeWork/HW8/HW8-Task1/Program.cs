using System.Text;
var exampleText = "1a!2.3!!.. 4.!.?6 7! ..";

StringBuilder sn = new StringBuilder(exampleText);

for (int i = 0; i < sn.Length; i++)
{
    if (sn[i] != '?')
    {
        if (sn[i] == '!' || sn[i] == '.')
        {
            sn.Remove(i, 1);
            i--;
        }
    }
    else
    {
        for (int j = i + 1; j < sn.Length; j++)
        {
            if (sn[j] == ' ')
            {
                sn[j] = '_';
            }
        }
        break;
    }
}

Console.WriteLine(sn.ToString());