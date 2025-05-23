namespace _2
{
    class Numbers
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Numbers(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Divide() => X / Y;
        public string GetInfo() => $"x = {X}\ny = {Y}\nЦелая часть от деления x на y = {Convert.ToInt32(Divide())}";
    }
}
