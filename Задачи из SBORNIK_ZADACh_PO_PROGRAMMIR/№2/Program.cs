using _2;

Random random = new();
double x = random.Next(1, 100);
double y = random.Next(1, 100);
double z = random.Next(1, 10);

NumbersChild nums = new(x, y, z);
Console.WriteLine(nums.GetInfo());

