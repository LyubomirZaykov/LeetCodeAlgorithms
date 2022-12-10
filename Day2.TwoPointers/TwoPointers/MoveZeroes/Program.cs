// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Text;

int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
MoveZeroes(nums);
Console.WriteLine(String.Join(",", nums));
Console.ReadLine();
void MoveZeroes(int[] nums)
{
	//My simple solution to the problem using queue to temporary store numbers in their realite order
	//counter to store the numbers of zeros
	int counter = 0;
	//queue to store the nums in the array, different from zero in their relative order
	Queue<int> queue=new Queue<int>();
	//filling the queue with the nums from the array, different from 0
	for (int n = 0; n < nums.Length; n++)
	{
		if (nums[n]!=0)
		{
			queue.Enqueue(nums[n]);
        }
		else
		{
			counter++;
		}
	}
	// if any zero, fill the back of the queue with the number of zeros
	if (counter>0)
	{
        for (int i = 0; i < counter; i++)
        {
			queue.Enqueue(0);
        }
    }
	//refilling the array, following the queue, which stores the relative order to the nums, with moved zeros
	for (int i = 0; i < nums.Length; i++)
	{
		nums[i] = queue.Dequeue();
	}
}
