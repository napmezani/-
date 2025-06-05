Random random = new();
double[] nums = new double[random.Next(0, 10)];

Console.WriteLine("Изначальный массив:");
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = random.Next(-10, 10);
    Console.Write(nums[i] + "\t");
}

Console.WriteLine("\nИзмененный массив:");
for (int i = 0; i < nums.Length; i++)
{
    if (i % 2 != 0)
    {
        try
        {
            if (nums[i] < 0)
                throw new ArgumentException($"У отрицательных чисел корень отсутствует");
            nums[i] = Math.Round(Math.Sqrt(nums[i]), 2);
            Console.WriteLine(nums[i]);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Пропуск элемента {nums[i]}: {ex.Message}");
        }
    }
    else
        Console.WriteLine(nums[i]);
}