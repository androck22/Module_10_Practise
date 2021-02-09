using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public double Addition(double a, double b)
        {
            Logger.Event("Сума двух чисел равна:");
            return a + b;
        }
    }
}
