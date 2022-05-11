using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSolution
{
   public class Calculator:ICalculator
    {
        public Logger Logger { get; }
        public Calculator(Logger logger)
        {
            Logger = logger;
        } 
        public int Sum(int a, int b)
        {
            Logger.Event($"Сумма чисел {a} и {b} равна {a+b}.");
            return (a + b);
        }
    }
}
