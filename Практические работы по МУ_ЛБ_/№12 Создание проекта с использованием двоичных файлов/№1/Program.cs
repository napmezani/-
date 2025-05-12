Random random = new();

double[] numsToRead = new double[12];

try
{
    string pathFile = "";
    while (string.IsNullOrEmpty(pathFile))
    {
        Console.WriteLine("Введите путь до файла bin");
        pathFile = Console.ReadLine().Trim();
    }
    /*
     * ДЛЯ ЗАПОЛНЕНИЯ ФАЙЛА
    double[] numsToWrite = new double[12];
    for (int i = 0; i < numsToWrite.Length; i++)
    {
        numsToWrite[i] = Math.Round(random.NextDouble() * random.Next(-10, 10), 2);
    }

    using (BinaryWriter writer = new BinaryWriter(File.Open(pathFile, FileMode.Open)))
    {
        foreach (double num in numsToWrite)
        {
            writer.Write(num);
        }
    }
    */

    using (BinaryReader reader = new BinaryReader(File.Open(pathFile, FileMode.Open)))
        {
            for (int i = 0; i < 12; i++) 
            {
                numsToRead[i] = reader.ReadDouble();
            }
        }

        Console.WriteLine("Считанные числа:");
        foreach (double num in numsToRead)
        {
            Console.WriteLine(num);
        }
    
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}