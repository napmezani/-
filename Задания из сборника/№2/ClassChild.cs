namespace _2
{
    class NumbersChild : Numbers
    {
        public double Z { get; set; }

        public NumbersChild(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
        public new string GetInfo() => $"x = {X}\ny = {Y}\nz = {Z}\nРезультат выражения: {FindExpression()}";
        public double FindExpression() => (X / Z) + (Y / Z);
    }
}
