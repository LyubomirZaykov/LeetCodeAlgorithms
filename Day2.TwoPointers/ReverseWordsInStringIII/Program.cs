// See https://aka.ms/new-console-template for more information
using System.Text;

string input = Console.ReadLine();
string str=ReverseWords(input);
Console.WriteLine(str);
string ReverseWords(string s)
{
    string[] sArr = s.Split(" ");
    for (int i = 0; i < sArr.Length; i++)
    {
        string currString= sArr[i];
        StringBuilder sb=new StringBuilder();
        for (int j = currString.Length-1; j >-1; j--)
        {
            sb.Append(currString[j]);
        }
        sArr[i] = sb.ToString();
    }
    return String.Join(" ",sArr);
}
