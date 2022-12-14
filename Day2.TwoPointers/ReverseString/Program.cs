// See https://aka.ms/new-console-template for more information
using System.Text;

char[] charArr = Console.ReadLine().Split(",").Select(char.Parse).ToArray();
ReverseString(charArr);
Console.WriteLine(string.Join(",", charArr));
Console.ReadLine();
void ReverseString(char[] s)
{
    StringBuilder sb = new StringBuilder();
    for (int j = s.Length-1; j > -1; j--)
    {
        sb.Append(s[j]);
    }
    for (int i = 0; i < sb.Length; i++)
    {
        s[i] = sb[i];
    }
}
