// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int[] inputArr = Console.ReadLine()
    .Split(",")
    .Select(int.Parse)
    .ToArray();
inputArr = SortedSquares(inputArr);
string output=String.Join(",", inputArr);
Console.WriteLine(output);

int[] SortedSquares(int[] nums)
{
    int[] squareArray= new int[nums.Length];
    bool isMiddle=false;
    int middleIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (isMiddle)
        {
            break;
        }
        if (nums[i] < 0)
        {
            middleIndex++;
            continue;
        }
        
        else
        {
            isMiddle= true;
            middleIndex = i;
        }
    }

    if (!isMiddle) 
    {
        for (int i = nums.Length-1,j=0; i > -1; i--,j++)
        {

            squareArray[j] = nums[i] * nums[i];
        }
        return squareArray;
    }
    for (int i = middleIndex,j=middleIndex-1,k=0; k < nums.Length;k++)
    {  
        if (j>=0&&i>=middleIndex)
        {
            int currNegativeNum = nums[j]*(-1);
            int currPositiveNum = int.MaxValue;

            if (isMiddle&&i<nums.Length)
            {
                currPositiveNum = nums[i];
            }
            if (currNegativeNum>currPositiveNum)
            {
                squareArray[k] = currPositiveNum * currPositiveNum;
                i++;
            }
            else if (currNegativeNum<currPositiveNum)
            {
                squareArray[k] = currNegativeNum * currNegativeNum;
                j--;
            }
            else
            {
                squareArray[k] = currPositiveNum * currPositiveNum;
                k++;
                j--;
                i++;
                squareArray[k] = currPositiveNum * currPositiveNum;
            }
            
        }
        else if (i > middleIndex)
        {
            if (i<nums.Length)
            {
                int currNum = nums[i];
                i++;
                squareArray[k] = currNum * currNum;
            }
            else
            {
                break;
            }
        }
        else
        {
            int currNum = nums[i];
            i++;
            squareArray[k] = currNum * currNum;
        }
    }
    Console.WriteLine("Done");
    return squareArray;
}