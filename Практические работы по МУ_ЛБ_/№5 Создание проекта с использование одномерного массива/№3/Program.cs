Random random = new();
int[] students = new int[40];

for (int i = 0; i < students.Length; i++)
{
    students[i] = random.Next(20, 40);
    Console.Write(students[i] + " ");
}
Console.WriteLine();

bool confirm = false;
int minNum = 0;
for (int i = 0; i < students.Length; i++)
{
    if (confirm == false)
    {
        confirm = true;
        minNum = students[i];
    }
    else if (minNum > students[i])
    {
        minNum = students[i];
    }
}

confirm = false;
int maxNum = 0;
for (int i = 0; i < students.Length; i++)
{
    if (confirm == false)
    {
        confirm = true;
        maxNum = students[i];
    }
    else if (maxNum < students[i])
    {
        maxNum = students[i];
    }
}

if (maxNum - minNum > 10)
    Console.WriteLine($"Верно, в самой многочисленной группе ({maxNum}) учится на 10 учащихся больше, чем в самой малочисленной ({minNum})");
else
    Console.WriteLine($"Неверно, в самой многочисленной группе ({maxNum}) НЕ учится на 10 учащихся больше, чем в самой малочисленной ({minNum})");