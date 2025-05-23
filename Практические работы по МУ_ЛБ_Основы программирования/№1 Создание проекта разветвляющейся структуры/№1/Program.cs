Random random = new();
double x = Double.Round(random.NextDouble(), 2);
double y;

Console.WriteLine($"x = {x}");

if(x < 0.5)
{
    y = Math.Pow(Math.Log(x), 3) + x * x / Math.Sqrt(x + 2);
}
else
{
    y =  Math.Cos(x) + (2 * Math.Pow(Math.Sin(x), 2));
}

Console.WriteLine($"y = {y}");