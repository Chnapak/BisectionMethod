namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new Calculation();
            app.BisectionLoop(3);
            app.BisectionIteration(3, 0, int.MaxValue);
        }
    }
}
