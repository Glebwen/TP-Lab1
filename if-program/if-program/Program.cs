using System;
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
                        if ((x / 100)%10 == 1)
                        {
                            if (x / 1000 == 1)
                            {
                                outMessage = (x / 100) + " рублей ровно";
                            }
                            else
                            {
                                outMessage = (x / 100) + " рубль ровно";
                            }
                        }
                        else
                        {
                            if ((x / 100) % 10 > 4)
                            {
                                outMessage = (x / 100) + " рублей ровно";
                            }
                            else
                            {
                                if (x / 1000 == 1)
                                {
                                    outMessage = (x / 100) + " рублей ровно";
                                }
                                else
                                {
                                    outMessage = (x / 100) + " рубля ровно";
                                }
                            }
                        }

                    }
                    else
                    {
                        if ((x / 100) % 10 == 1)
                        {
                            if (x / 1000 == 1)
                            {
                                outMessage = (x / 100) + " рублей ";
                            }
                            else
                            {
                                outMessage = (x / 100) + " рубль ";
                            }
                        }
                        else
                        {
                            if ((x / 100) % 10 > 4)
                            {
                                outMessage = (x / 100) + " рублей ";
                            }
                            else
                            {
                                if (x / 1000 == 1)
                                {
                                    outMessage = (x / 100) + " рублей ";
                                }
                                else
                                {
                                    outMessage = (x / 100) + " рубля ";
                                }
                            }
                        }

                        if ((x % 100) % 10 == 1)
                        {
                            if ((x % 100)/10 == 1)
                            {
                                outMessage += (x % 100) + " копеек";
                            }
                            else
                            {
                                outMessage += (x % 100) + " копейка";
                            }
                        }
                        else
                        {
                            if ((x % 100) % 10 > 4)
                            {
                                outMessage += (x % 100) + " копеек";
                            }
                            else
                            {
                                if ((x % 100)/10 == 1)
                                {
                                    outMessage += (x % 100) + " копеек";
                                }
                                else
                                {
                                    outMessage += (x % 100) + " копейки";
                                }
                            }
                        }

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

            while (Logic.Convert(n) == "некорректный ввод" || Logic.Convert(n) == "число за пределом ОДЗ")
            {
                Console.WriteLine(Logic.Convert(n));
                Console.WriteLine("Введите натуральное число 1<=n<=9999");
                n = Console.ReadLine();
            }

            Console.WriteLine(Logic.Convert(n));
            Console.ReadKey();
        }
    }
}
