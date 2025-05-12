Random random = new();

int numX = random.Next(-10, 10);
int numY = random.Next(-10, 10);

Console.WriteLine($"X = {numX}");
Console.WriteLine($"Y = {numY}");
if ((numX * numX) + (numY * numY) < (10 * 10) && numY > -numX)
    Console.WriteLine("Да");
else if ((numX * numX) + (numY * numY) > (10 * 10) || numY < -numX)
    Console.WriteLine("Нет");
else
    Console.WriteLine("На границе");
