using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_pks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число: ");
            string var1str = Console.ReadLine();
            Console.WriteLine("введите знак операции: ");
            string sign = Console.ReadLine();
            Console.WriteLine("введите число: ");
            string var2str = Console.ReadLine();
            int var1 = Convert.ToInt32(var1str);
            int var2 = Convert.ToInt32(var1str);
            int summa = 23;
            switch (sign)
            {
                case "+":
                    summa = var1 + var2;
                    break;

            }

            Console.WriteLine("результат: ", summa);
        }
    }
}
