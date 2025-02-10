using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_program
{
    public class Logic
    {
        public static bool CheckLine(string line)
        {
            for (int i=0; i<line.Length; i++)
            {
                if (i%2==0)
                {
                    if (!int.TryParse(line[i].ToString(), out int res))
                    {
                        return false;
                    }
                }
                else
                {
                    if(line[i]!='+' && line[i]!='-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string CountLine(string line)
        {
            string outMessage = "";
            if (CheckLine(line))
            {
                int result = int.Parse(line[0].ToString());
                for(int i = 1; i < line.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (line[i-1] == '+')
                        {
                            result += int.Parse(line[i].ToString());
                        }
                        if(line[i - 1] == '-')
                        {
                            result -= int.Parse(line[i].ToString());
                        }
                    }
                }
                outMessage = result.ToString();
            }
            else
            {
                outMessage = "некорректный ввод";
            }
            return outMessage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку цифр, разделенных зхнаками + или -");
            string line = Console.ReadLine();



            Console.WriteLine(Logic.CountLine(line));
            Console.ReadKey();
        }
    }
}
