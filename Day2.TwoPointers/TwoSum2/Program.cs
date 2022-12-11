// See https://aka.ms/new-console-template for more information
int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int target = int.Parse(Console.ReadLine());
int[] indices = TwoSum(numbers, target);
Console.WriteLine(String.Join(",", indices));
int[] TwoSum(int[] numbers, int target)
{
    Dictionary<int, int> required = new Dictionary<int, int>();
    int[] indices = new int[2];
    for (int i = 0; i < numbers.Length; i++)
    {
        int currNumber = numbers[i];
        if (required.ContainsKey(currNumber))
        {
            indices[0] = (required.GetValueOrDefault(currNumber)) + 1;
            indices[1] = i + 1;
            return indices;
        }
        int requiredNumber = target - currNumber;
        if (required.ContainsKey(requiredNumber))
        {
            continue;
        }
        required.Add(requiredNumber, i);
    }
    return indices;

}
