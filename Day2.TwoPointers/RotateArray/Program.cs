// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

int[] nums=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int steps = int.Parse(Console.ReadLine());
Rotate(nums, steps);
Console.WriteLine(String.Join(",",nums));
void Rotate(int[] nums, int k)
{
    //***************   Solution 3  ********************
    // Still best solution from the three. Happy with it.
    //With queue and for loop. Memory consumption is very low (beats 96.47%), but the runtime is very big
    //beats only (17.1%)
    //Probably the issue is with the Array class. 
    //With the for cycle at the end, instead of the Array class, the runtime is very good (beats 86.68%),
    //but the memory consumption increases (beats only 20.85%)
    Queue<int> queue = new Queue<int>();
    while (k >= nums.Length)
    {
        k = k - nums.Length;
    }
    
    for (int i = nums.Length-k; i <nums.Length; i++)
    {
        queue.Enqueue(nums[i]);
    }
    for (int i = 0; i < nums.Length - k; i++)
    {
        queue.Enqueue(nums[i]);
    }
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = queue.Dequeue();
    }
    //Array.Clear(nums);
    //Array.Copy(queue.ToArray(), nums, nums.Length);

    //***************   Solution 2  ********************
    //With list and Array library. Work just fine, LeetCode likes it, but is a bit slow.


    //while (k >= nums.Length)
    //{
    //    k = k - nums.Length;
    //}
    //List<int> list = nums.ToList();
    //List<int> secondList= list.GetRange(list.Count - k, k);
    //list.InsertRange(0, secondList);
    //list.RemoveRange(list.Count - k, k);
    //Array.Clear(nums);
    //Array.Copy(list.ToArray(),nums,list.Count);



    //***************   Solution 1  ********************
    //With arrays. It worked fine, but LeetCode throws an exception for too big runtime

    //while (k >= nums.Length)
    //{
    //    k = k - nums.Length;
    //}
    //int currNum = nums[0];
    //int lastNum = nums[0];
    //int counter = 0;
    //while (counter < k)
    //{
    //    for (int i = 0; i < nums.Length; i++)
    //    {

    //        if (i < nums.Length - 1)
    //        {
    //            lastNum = nums[i + 1];
    //            nums[i + 1] = currNum;
    //            currNum = lastNum;
    //        }
    //        else
    //        {
    //            nums[0] = lastNum;
    //        }

    //    }
    //    counter++;
    //}

}
