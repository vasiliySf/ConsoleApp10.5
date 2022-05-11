using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSolution2
{
   public class MyCalculator:ICalculator
    {
        public Logger Logger { get; }
        public MyCalculator(Logger logger)
        {
            Logger = logger;
        }
        public decimal Add(decimal a, decimal b)
        {
            decimal c = a + b;
            Logger.Event($" {a} + {b} = {c}.");
            return (c);
        }

        public decimal Divide(decimal a, decimal b)
        {   if (b==0)
            {
                Logger.Error($"На ноль делить нельзя!");
                return (0);
            }
                
            else
            {
                decimal c = a / b;
                Logger.Event($" {a} / {b} = {c}.");
                return (c);
            }

            
        }

        public decimal Multiply(decimal a, decimal b)
        {
            decimal c = a * b;
            Logger.Event($" {a} * {b} = {c}.");
            return (c);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            decimal c = a - b;
            Logger.Event($" {a} - {b} = {c}."); 
            return (c);
        }
        
    }
}
