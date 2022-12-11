// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

int n = int.Parse(Console.ReadLine());
int bad=int.Parse(Console.ReadLine());
int fault = FirstBadVersion(n);
Console.WriteLine(fault);
int FirstBadVersion(int n)
{
    int low = 1, high = n;
    int lastGood = 0;
    while (low<high)
    {
        int mid = low + (high - low) / 2;
        if (isBadVersion(mid))
        {
            high = mid - 1;
            if (!isBadVersion(mid-1))
            {
                return mid;
            }
        }
        else if (!isBadVersion(mid))
        {
            lastGood= mid;
            low = mid + 1;
        }
    }
    return lastGood + 1;
}

bool isBadVersion(int n)
{
    int badVersion = bad;
    if (n>=badVersion)
    {
        return true;
    }
    else
    {
        return false;
    }
}