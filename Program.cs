using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSolution;
class Program
{
   
    public static void Main(string[] args)
    {
        Logger Logger = new Logger();

        Calculator calculator = new Calculator(Logger);

        string sA, sB;
        int intA, intB;
        try
        {
            Console.WriteLine("Введите первое целое число");
            sA = Console.ReadLine();


            if (int.TryParse(sA, out intA))
            {
                Console.WriteLine("Введите второе целое число");
                sB = Console.ReadLine();
                if (int.TryParse(sB, out intB))
                {
                    int c = calculator.Sum(intA, intB);
                    Console.WriteLine();                   
                }
                else
                {
                    Logger.Error("Вы ввели не целое число!");
                    throw new MyException("Вы ввели не целое число!");
                }
            }
            else
            {
                Logger.Error("Вы ввели не целое число!");
                throw new MyException("Вы ввели не целое число!");
            }
        }
        catch (Exception ex)
        { Console.WriteLine(ex.ToString()); }
        finally
        {
            Logger.Event("Программа завершилась.");
        } 
    }

   

    

}