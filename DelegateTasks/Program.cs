namespace DelegateTasks
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            MathOperation add = (a, b) => a + b;
            MathOperation subtract = (a, b) => a - b;
            MathOperation multiply = (a, b) => a * b;
            MathOperation divide = (a, b) => a / b;


            int a = 20;
            int b = 10;


            ProcessOperation(add, a,b );
            ProcessOperation(subtract, a, b);
            ProcessOperation(multiply, a, b);
            ProcessOperation(divide, a, b);



        }


        static void ProcessOperation(MathOperation operation, int a, int b)
        {
            int result = operation(a, b);
            Console.WriteLine($"Result: {result}");

        }    
    }
}
