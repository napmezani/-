Random random = new();
int year = random.Next(1900, 2025);
string animal;
int animalIndex = (year - 4) % 12;

switch (animalIndex)
{
    case 0:
        animal = "Крыса";
        break;
    case 1:
        animal = "Бык";
        break;
    case 2:
        animal = "Тигр";
        break;
    case 3:
        animal = "Кролик";
        break;
    case 4:
        animal = "Дракон";
        break;
    case 5:
        animal = "Змея";
        break;
    case 6:
        animal = "Лошадь";
        break;
    case 7:
        animal = "Коза";
        break;
    case 8:
        animal = "Обезьяна";
        break;
    case 9:
        animal = "Петух";
        break;
    case 10:
        animal = "Собака";
        break;
    case 11:
        animal = "Свинья";
        break;
    default:
        animal = "Неизвестно";
        break;
}

Console.WriteLine($"Год {year} ({animal})");