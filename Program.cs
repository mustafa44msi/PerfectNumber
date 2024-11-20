using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace PerfectNumber
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int num = int.Parse(Console.ReadLine());
            int perfectNum = num;
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == perfectNum)
            {
                Console.WriteLine("Girilen sayı Mükkemmel bir sayıdır");
            }
            else if (sum != perfectNum)
            {
                Console.WriteLine("Girilen sayı Mükemmel bir sayı değildir");
            }

        }

    }
}