Random random = new();

int[] nums = new int[random.Next(1, 10)];

for(int i = 0; i < nums.Length; i++)
{
    nums[i] = random.Next(-100, 100);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
bool confirm = false;
int minNum = 0;

for(int i = 0; i < nums.Length; i++)
{
    if (confirm == false)
    {
        confirm = true;
        minNum = nums[i];
    }
    else if (minNum > nums[i])
    {
        minNum = nums[i];
    }
}
Console.WriteLine($"Минимальное число: {minNum}");
