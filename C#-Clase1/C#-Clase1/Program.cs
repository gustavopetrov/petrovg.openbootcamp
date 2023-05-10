internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre por favor.");
        string? nombre = Console.ReadLine();
        Console.WriteLine($"Bienvenido,{nombre}.");
    }
}