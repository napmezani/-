using _1;

Random random = new();
Worker worker = new("Ivanov", random.Next(15000, 50000), new DateTime(random.Next(1950, DateTime.Now.Year), random.Next(1, DateTime.Now.Month), random.Next(1, DateTime.Now.Day)));
Console.WriteLine(worker.GetInfo());