namespace FuncTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, bool> isPositive = x => x > 0;

            for (int i = -5; i <= 5; i++)
            {
                Console.WriteLine($"{i} is even: {isEven(i)}, is positive: {isPositive(i)}");
            }
        }
    }
}
