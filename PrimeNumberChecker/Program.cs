using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecker
{
    internal class Program
    {
        //public static bool Prime(int number)
        //{
        //    if (number == 0) return false;
        //    for (int i = 2; i<=Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        static void Main(string[] args)
        {
            int number = -1;

            while (number != 0)
            {
                Console.Write("Nhap sos can kiem tra (0 de thoat): ");
                number = Int32.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    int i = 2;
                    bool check = false;

                    while (i <= Math.Sqrt(number))
                    {
                        if (number % i == 0)
                        {
                            check = false;
                            break;
                        }
                        i++;
                    }
                    if(check)
                    {
                        Console.WriteLine("{0} la so nguyen to", number);
                    }
                    else { Console.WriteLine("{0} khong la so nguyen to", number); }
                }
            }

        }
    }
}
