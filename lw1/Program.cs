using System;


namespace lw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "Неизвестная_ошибка";
            if (args.Length != 3)
            {
                Console.WriteLine("Неизвестная_ошибка");
                Environment.Exit(0);
            }
            bool aIsNumeric = double.TryParse(args[0], out double a);
            bool bIsNumeric = double.TryParse(args[1], out double b);
            bool cIsNumeric = double.TryParse(args[2], out double c);
            if ((aIsNumeric == false) ^ (bIsNumeric == false) ^ (cIsNumeric == false))
            {
                Console.WriteLine("Неизвестная_ошибка");
                Environment.Exit(0);
            }
            if ((a <= 0) ^ (b <= 0) ^ (c <= 0))
            {
                Console.WriteLine("Неизвестная_ошибка");
                Environment.Exit(0);
            }
            if ((a + b > c) & (a + c > b) & (b + c > a))
            {
                ans = "Обычный";
            }
            else
            {
                Console.WriteLine("Не_треугольник");
                Environment.Exit(0);
            }
            if ((a == b) ^ (a == c) ^ (b == c))
            {
                ans = "Равнобедренный";
            }

            if ((a == b) & (a == c))
            {
                ans = "Равносторонний";
            }
            Console.WriteLine(ans);
        }
    }
}