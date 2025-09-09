using System;

namespace pr1_pks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите знак операции либо введите \"stop\" для выхода из калькулятора: ");
            string sign = Console.ReadLine();

            double data = 0;
            double rez = 0;
            int flag = 0;
            while (sign != "stop")
            {
                string var1str1 = "";
                string var1str2 = "";
                double var1 = 0;
                double var2 = 0;

                switch (sign)
                {
                    case "+":
                        Console.Write("Введите первое число: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите второе число: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToDouble(var1str1);
                        var2 = Convert.ToDouble(var1str2);
                        rez = var1 + var2;
                        Console.WriteLine($"результат: {rez}");
                        break;
                    case "-":
                        Console.Write("Введите первое число: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите второе число: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToInt32(var1str1);
                        var2 = Convert.ToInt32(var1str2);
                        rez = var1 - var2;
                        Console.WriteLine($"результат: {rez}");
                        break;
                    case "sqrt":
                        Console.Write("Введите число: ");
                        var1str1 = Console.ReadLine();
                        var1 = Convert.ToDouble(var1str1);
                        rez = Math.Sqrt(var1);
                        Console.WriteLine($"результат: {rez}");
                        break;
                    case "/":
                        Console.Write("Введите первое число: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите второе число: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToInt32(var1str1);
                        var2 = Convert.ToInt32(var1str2);
                        if (var2 != 0)
                            {rez = var1 / var2;
                            Console.WriteLine($"результат: {rez}");
                        }
                        else
                            { Console.WriteLine("Ошибка: деление на ноль!"); }
                        break;
                    case "*":
                        Console.Write("Введите первое число: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите второе число: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToInt32(var1str1);
                        var2 = Convert.ToInt32(var1str2);
                        rez = var1 * var2;
                        Console.WriteLine($"результат: {rez}");
                        break;
                    case "**":
                        Console.Write("Введите основание: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите показатель: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToDouble(var1str1);
                        var2 = Convert.ToDouble(var1str2);
                        rez = Math.Pow(var1, var2);
                        Console.WriteLine($"результат: {rez}");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        break;
                    case "M+":
                        data = data + rez;
                        flag = 1;
                        break;
                    case "M-":
                        data = data - rez;
                        flag = 1;
                        break;
                    case "MR":
                        if (flag==1)
                        {
                            Console.WriteLine($"результат: {data}");
                        }
                        else
                        {
                            Console.WriteLine("Память пуста");
                        }
                        
                        break;
                    case "%":
                        Console.Write("Введите первое число: ");
                        var1str1 = Console.ReadLine();
                        Console.Write("Введите второе число: ");
                        var1str2 = Console.ReadLine();
                        var1 = Convert.ToInt32(var1str1);
                        var2 = Convert.ToInt32(var1str2);
                        if (var2 != 0)
                        {
                            rez = var1 % var2;
                            Console.WriteLine($"результат: {rez}");
                        }
                        else
                        { Console.WriteLine("Ошибка: деление на ноль!"); }
                        break;

                }

                Console.Write("\nВведите следующую операцию или \"stop\" для выхода: ");
                sign = Console.ReadLine();
            }
        }
    }
}