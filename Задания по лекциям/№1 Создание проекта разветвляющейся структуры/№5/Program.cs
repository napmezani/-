Random random = new();
int k = random.Next(1, 10);

if (k == 1)
    Console.WriteLine($"мы нашли {k} гриб в лесу");
else if (k < 5)
    Console.WriteLine($"мы нашли {k} гриба в лесу");
else
    Console.WriteLine($"мы нашли {k} грибов в лесу");