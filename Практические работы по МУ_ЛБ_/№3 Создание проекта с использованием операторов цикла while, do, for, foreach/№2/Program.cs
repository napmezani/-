Random random = new();

int a = random.Next(1, 10);
int b = random.Next(a, 100);
int k = random.Next(3, 15);

Console.WriteLine($"Отрезок от {a} до {b}");
Console.WriteLine($"Целые числа, у которых количество делителей {k}");

for(int i = a; i <= b; i++)
{
    int count = 1; //т.к. число является делителем для самого себя, и в цикл не попадает, сразу его учитываю
    for (int j = 1; j <= i / 2; j++)
    {
        if (i % j == 0)
            count++;
    }
    if (count == k)
        Console.WriteLine(i);
}