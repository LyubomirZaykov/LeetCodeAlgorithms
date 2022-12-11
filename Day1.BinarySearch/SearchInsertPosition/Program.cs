// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata.Ecma335;

int[] nums = Console.ReadLine().Trim().Split(',').Select(int.Parse).ToArray();
int target = int.Parse(Console.ReadLine());
int index = SearchInsert(nums, target);
Console.WriteLine(index);

int SearchInsert(int[] nums, int target)
{
    if (nums.Length == 0 || nums.Length == 1)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        else
        {
            if (target <= nums[0])
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    else if (target > nums[nums.Length - 1])
    {
        return nums.Length;
    }
    else if (target == nums[nums.Length - 1])
    {
        return nums.Length - 1;
    }
    int index = -1;
    int left = 0;
    int right = nums.Length - 1;
    int mid = right - (right - left) / 2;
    int closest = int.MaxValue;
    int closestIndex = -1;
    while (left <= right)
    {
        mid = right - (right - left) / 2;
        if (nums[mid] == target)
        {
            index = mid;
            return index;
        }
        else if (nums[mid] > target)
        {
            int closestBigger = nums[mid] - target;
            if (closestBigger < closest)
            {
                closest = closestBigger;
                closestIndex = mid;
            }
            right = mid - 1;
        }
        else
        {
            int closestSmaller = target - nums[mid];
            if (closestSmaller < closest)
            {
                closest = closestSmaller;
                closestIndex = mid+1;
            }
            {

            }
            left = mid + 1;
        }
    }

    if (index==-1)
    {
        return closestIndex;
    }
    return index;
}

