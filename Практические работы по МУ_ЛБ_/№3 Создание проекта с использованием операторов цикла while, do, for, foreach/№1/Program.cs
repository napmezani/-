Random random = new();

int A = random.Next(0, 10);
int B = random.Next(A, 100);

Console.WriteLine($"Отрезок от {A} до {B}");
Console.WriteLine("Четные числа, кратные пяти:");

for(int i = A; i <= B; i++)
{
    if (i % 2 == 0 && i % 5 == 0)
        Console.WriteLine(i);
}