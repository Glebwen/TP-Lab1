using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_program
{
    public class Logic
    {
        public static string Convert(string n)
        {
            string outMessage;
            if (!int.TryParse(n, out int x))
            {
                outMessage = "некорректный ввод";
            }
            else
            {
                if (x < 1 || x > 9999)
                {
                    outMessage = "число за пределом ОДЗ";
                }
                else
                {
                    if (x % 100 == 0)
                    {
                        outMessage = (x / 100) + " рублей ровно";
                    }
                    else
                    {
                        outMessage = x / 100 + " рублей " + x % 100 + " копеек";
                    }
                }

            }
            return outMessage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число 1<=n<=9999");
            string n = Console.ReadLine();


            Console.WriteLine(Logic.Convert(n));
            Console.ReadKey();
        }
    }
}
