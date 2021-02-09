using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите два числа для сложения:");
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());

                    ICalculator calculator = new Calculator();
                    var result = calculator.Addition(a, b);

                    Console.WriteLine($"Сумма чисел равна: {result}");
                }
                catch (Exception ex)
                {
                    if (ex is FormatException) Console.WriteLine("Не верный ввод!");
                    else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
                }
            }
        }
    }

    public interface ICalculator
    {
        double Addition(double a, double b);
    }

    public class Calculator : ICalculator
    {
        public double Addition(double a, double b)
        {

            return a + b;
        }
    }
}
