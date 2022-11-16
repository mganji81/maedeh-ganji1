//برنامه ای بنویسید که دو عدد از ورودی خوانده و در دو متود جداگانه بزگترین مقسوم علیه مشترک و کوچکترین مضرب مشترک را نمایش دهد
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int biggest_number = number2 > number1 ? number2 : number1;
            int gcd = 1;
            for(int i = biggest_number; i>=1;i--)
            {
                if(number2 % i==0 && number2 % i == 0) { gcd = i; break; }
            }
            Console.WriteLine("gcd:" + gcd.ToString());
            int icm = number1 * number2 / gcd;
            Console.WriteLine("icm:" + icm.ToString());


        }
    }
}
