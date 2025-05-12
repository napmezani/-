Random random = new();

int[] nums = new int[random.Next(5, 10)];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = random.Next(-100, 100);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();

int firstIndex = -1;
int secondIndex = -1;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < 0)
    {
        firstIndex = i;
        break;
    }
}

if (firstIndex != -1)
{
    for (int i = firstIndex + 1; i < nums.Length; i++)
    {
        if (nums[i] < 0)
        {
            secondIndex = i;
            break;
        }
    }
}

if (firstIndex != -1 && secondIndex != -1)
{
    int count = 0;
    for (int i = firstIndex + 1; i < secondIndex; i++)
    {
        count += nums[i];
    }

    Console.WriteLine($"Сумма элементов между первым и вторым отрицательными элементами: {count}");
}
else
{
    Console.WriteLine("В массиве недостаточно отрицательных элементов");
}