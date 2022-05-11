using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSolution2;
class Program
{
    public delegate decimal Operation(decimal a, decimal b);
    public static void Main(string[] args)
    {
        Logger Logger = new Logger();

        MyCalculator mcalculator = new MyCalculator(Logger);

        Operation operation = mcalculator.Add;
        operation -= mcalculator.Add;

        char[] signs = new char[] { '+', '-', '/', '*', 'в', 'В' };

        decimal a = 0;
        decimal b = 0;

        char operate;

        bool check = true;
        decimal? result;

        Logger.Info("Для работы введите два числа, затем операцию (+,-,*,/), для выхода нажмите 'в' !");
        do
        {
            try
            {
                Logger.Info("Введите первое число: ");
                a = decimal.Parse(Console.ReadLine());

                Logger.Info("Введите второе число: ");
                b = decimal.Parse(Console.ReadLine());

                operate = CheckOperate(signs, Logger);

                switch (operate)
                {
                    case '+': { operation = mcalculator.Add; break; }
                    case '-': { operation = mcalculator.Subtract; break; }
                    case '*': { operation = mcalculator.Multiply; break; }
                    case '/': { operation = mcalculator.Divide; break; }
                    case 'в': { check = false; break; }
                    case 'В': { check = false; break; }
                }

                if (check)
                {
                    result = operation?.Invoke(a, b);                    
                }
                else
                    Logger.Event("Программа завершена!");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
        while (check);

        Console.ReadKey();
    }
    public static char CheckOperate(char[] signs, Logger Logger)
    {
        char[] input;
        string? inputstr = string.Empty;
        bool check = false;
        int i;
        char sign = 'в';

        do
        {
            Logger.Info("Введите операцию (+,-,*,/), для выхода нажмите 'в': ");
            inputstr = Console.ReadLine();
            if (inputstr.Length > 0)
            {
                input = inputstr.ToCharArray();
                sign = input[0];
                for (i = 0; i < 6; i++)
                {
                    if (signs[i] == sign)
                        return sign;
                }

                if (i > 5)
                {
                    Logger.Error("Не правильно введена операция, попробуйте еще раз ввести.");

                }
            }
            else
                Logger.Error("Операция не может быть пустой.");
        }
        while (!check);

        return sign;
    }

}