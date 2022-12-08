// See https://aka.ms/new-console-template for more information

int[] nums = Console.ReadLine().Trim().Split(',').Select(int.Parse).ToArray();
int target = int.Parse(Console.ReadLine());
int index = Search(nums, target);
int Search(int[] nums, int target)
{
    int index = BinarySearch(nums, target, 0, nums.Length - 1);
    return index;
}
int BinarySearch(int[] nums, int target, int left, int right)
{

    if (left > right)
    {
        return -1;
    }
    int mid = (left + right) / 2;
    if (nums[mid] == target)
    {
        return mid;
    }
    if (target > nums[mid])
    {
        return BinarySearch(nums, target, mid+1, right);
    }
    else
    {
        return BinarySearch(nums, target, left, mid - 1);
    }
}
