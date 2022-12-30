using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp ;
            Console.WriteLine("Enter the number to start counting");
            int num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to stop counting");
            int num2 =int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                tmp =0;
                for (int c = 1; c <= i/2; c++)
                {
                    if (i%c==0)
                    {
                        tmp += c;
                    }   
                }
                if (tmp==i)
                {
                    Console.WriteLine("the perfect number is:{0}",i);
                }
            }
        }
    }
}
