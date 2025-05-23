using System.Text;
using System.IO;

Random random = new();
int k = random.Next(0, 5);

try
{
    string pathFile = "";
    while (string.IsNullOrEmpty(pathFile))
    { 
        Console.WriteLine("Введите путь до текстового файла");
        pathFile = Console.ReadLine().Trim();
    }
    string result = "";
    string[] lines = File.ReadAllLines(pathFile);

    foreach (string line in lines)
    {
        if (line.Length > k)
            result += line[k];
    }
    Console.WriteLine("Номер символа - {0}", k);
    Console.WriteLine($"Результат: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}