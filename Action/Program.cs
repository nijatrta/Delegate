namespace Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> salamAz = name =>
                                  Console.WriteLine($"Salam {name}");
            Action<string> salamTr = name =>
                                   Console.WriteLine($"Merhaba {name}");
            Action<string> salamEn = name =>
                                  Console.WriteLine($"Hello {name}");

            salamAz("MirMovsumAga");
            salamTr("Serkan");
            salamEn("Scoot");
        }
    }
}
