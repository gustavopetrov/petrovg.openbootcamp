internal class Program
{
    private static void Main(string[] args)
    {
        string hora = DateTime.Now.ToString("hh:mm:s");
        Console.WriteLine($"Son las: {hora}.");
    }
}