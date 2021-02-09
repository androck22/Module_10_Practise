using System;

namespace Task_2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();

            while (true)
            {
                Console.WriteLine();

                try
                {
                    Console.WriteLine("Введите два числа для сложения:");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());

                    var calculator = new Calculator(Logger);

                    var result = calculator.Addition(a, b);

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException) Logger.Error("Не верный ввод!");
                    else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
                }
            }
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
    }

    public interface ICalculator
    {
        double Addition(double a, double b);
    }
}
