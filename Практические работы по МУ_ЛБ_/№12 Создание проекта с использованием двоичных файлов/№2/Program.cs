Random random = new();

string inputPathFile = "";

while (string.IsNullOrEmpty(inputPathFile))
{
    Console.WriteLine("Введите путь для исходного текстового файла: ");
    inputPathFile = Console.ReadLine();
}

/* ДЛЯ ГЕНЕРАЦИИ ЦИФР
int[] numsToWrite = new int[random.Next(1, 10)];
for (int i = 0; i < numsToWrite.Length; i++)
{
    numsToWrite[i] = random.Next(0, 1000);
}
File.WriteAllLines(inputPathFile, numsToWrite.Select(n => n.ToString()));
*/

string outputPathFile = "";

while (string.IsNullOrEmpty(outputPathFile))
{
    Console.WriteLine("Введите путь для выходного текстового файла: ");
    outputPathFile = Console.ReadLine();
}

try
{
    int[] nums = File.ReadAllText(inputPathFile)
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    int[] newNums = new int[nums.Length % 2 == 0 ? nums.Length / 2 : (nums.Length / 2) + 1];
    int count = 0;

    for(int i = 0; i < nums.Length; i += 2)
    {
        if (i + 1 >= nums.Length)
        {
            newNums[count] = nums[i] / 2;
            break;
        }

        int first = nums[i] / 2;
        int second = nums[i + 1] / 2;

        newNums[count] = Math.Min(first, second);
        count++;
    }

    File.WriteAllLines(outputPathFile, newNums.Select(n => n.ToString()));
    Console.WriteLine("Файл успешно обработан и результат записан в " + outputPathFile);
}
catch (Exception ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}