Random random = new();
int num = random.Next(100, 999);

Console.WriteLine(num);

if (num % 100 % 10 > num / 10 % 10)
    Console.WriteLine($"Последнее число ({num % 100 % 10}) больше чем второе число ({num / 10 % 10})");
else if (num / 10 % 10 > num % 100 % 10)
    Console.WriteLine($"Второе число ({num / 10 % 10}) больше чем последнее число({num % 100 % 10})");
else
    Console.WriteLine("Числа равны");