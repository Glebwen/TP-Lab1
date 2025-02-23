using System;
namespace For_program
{
    public class Logic
    {
        public static string IncreaseMonthCount(string a, string b, string c)
        {
            string aAnswer;
            if (!float.TryParse(a, out float floatA) || !float.TryParse(b, out float floatB) || !float.TryParse(c, out float floatC))
            {
                aAnswer = "некорректный ввод";
            }
            else
            {
                floatA = float.Parse(a);
                floatB = float.Parse(b);
                floatC = float.Parse(c);
                if (!(floatA >= 0 && floatB >= 0 && floatC >= 0))
                {
                    aAnswer = "числа за пределами ОДЗ";
                }
                else
                {
                    float incr = 0;
                    int aMonth = -1;
                    for (int i = 1; incr <= floatB; i++)
                    {
                        incr = floatA / 50;
                        floatA += incr;
                        if (incr > floatB && aMonth == -1)
                        {
                            aMonth = i;
                        }
                    }
                    aAnswer = aMonth.ToString();
                }
            }
            return aAnswer;
        }
        public static string DepositMonthCount(string a, string b, string c)
        {
            string bAnswer;
            if (!float.TryParse(a, out float floatA) || !float.TryParse(b, out float floatB) || !float.TryParse(c, out float floatC))
            {
                bAnswer = "некорректный ввод";
            }
            else
            {
                floatA = float.Parse(a);
                floatB = float.Parse(b);
                floatC = float.Parse(c);
                if (!(floatA >= 0 && floatB >= 0 && floatC >= 0))
                {
                    bAnswer = "числа за пределами ОДЗ";
                }
                else
                {
                    float incr;
                    int bMonth = -1;
                    for (int i = 1; floatA <= floatC; i++)
                    {
                        incr = floatA / 50;
                        floatA += incr;
                        if (floatA > floatC && bMonth == -1)
                        {
                            bMonth = i;
                        }
                    }
                    bAnswer = bMonth.ToString();
                }
            }
            return bAnswer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите сумму, вложенную при открытии вклада");
            var a = Console.ReadLine();
            Console.WriteLine("Введите интересующий размер увеличения вклада");
            var b = Console.ReadLine();
            Console.WriteLine("Введите ожидаемую сумму на счету");
            var c = Console.ReadLine();
            while (Logic.IncreaseMonthCount(a, b, c) == "некорректный ввод" || Logic.IncreaseMonthCount(a, b, c) == "числа за пределами ОДЗ")
            {
                Console.WriteLine(Logic.IncreaseMonthCount(a, b, c));
                Console.WriteLine("Введите сумму, вложенную при открытии вклада");
                a = Console.ReadLine();
                Console.WriteLine("Введите интересующий размер увеличения вклада");
                b = Console.ReadLine();
                Console.WriteLine("Введите ожидаемую сумму на счету");
                c = Console.ReadLine();
            }
            Console.WriteLine("a) Небходимое число месяцев: " + Logic.IncreaseMonthCount(a,b,c));
            Console.WriteLine("b) Небходимое число месяцев: " + Logic.DepositMonthCount(a,b,c));
            Console.ReadKey();
        }
    }
}
