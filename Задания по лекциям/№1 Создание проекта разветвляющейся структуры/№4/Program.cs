Random random = new();

int byciclePrice = random.Next(10000, 30000);

Console.WriteLine($"Стоимость велосипеда: {byciclePrice}");

int cash = random.Next(5000, 35000);

Console.WriteLine($"Количество денег у покупателя: {cash}");

if (cash >= byciclePrice)
    Console.WriteLine("Покупатель может позволить себе велосипед");
else
    Console.WriteLine("Покупатель НЕ может позволить себе велосипед");