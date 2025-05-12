string[] arr =
{
    "немного осмысленный текст для проверки",
    "совсем малость осмммысленннный текст для проверки",
    "праккктически точно осмысленный текст для проверки",
    "определлллленно осмысленный текст для проверки",
    "текст. (для проверки)",
};

Random random = new();
string str = arr[random.Next(0, 5)];

Console.WriteLine($"Предложение: \n{str}");
Console.WriteLine($"Самая длинная подстрока = {FindSubstring(str)}");
string FindSubstring(string str)
{

    string substr = str[0].ToString();
    for(int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == str[i + 1])
        {
            string newsubstr = str[i].ToString() + str[i + 1].ToString();

            for (int j = i + 1; j < str.Length; j++)
            {
                if (j + 1 == str.Length) continue;

                if (str[j] == str[j + 1])
                    newsubstr += str[j + 1].ToString();
                else
                    break;
            }

            substr = newsubstr.Length > substr.Length ? newsubstr : substr;
        }
    }

    return substr;
}