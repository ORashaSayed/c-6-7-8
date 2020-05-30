namespace CSharp8
{
    class Switch_Experssions
    {
        public static double DoMath(double x, double y, MathType math) => math switch
        {
            MathType.Add => x + y,
            MathType.Sub => x - y,
            MathType.multiplay => x * y,
            MathType.divid => x / y,
            _ => throw new System.NotImplementedException()
        };
    }

    public enum MathType
    {
        Add,
        Sub,
        multiplay,
        divid
    }
}
