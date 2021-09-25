using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorBase, valorAltura, valorArea;
            Console.WriteLine("\n-Area do Triangulo Retangulo-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nBase: ");
            valorBase = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Altura: ");
            valorAltura = Convert.ToDouble(Console.ReadLine());

            valorArea = valorBase * valorAltura / 2;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nArea é: {valorArea}\n");
            Console.ResetColor();
        }
    }
}
