using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            Console.WriteLine("Enter the number to start counting");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to stop counting");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    if (i % c == 0)
                    {
                        tmp++;
                    }
                }

                if (tmp == 2)
                {

                    Console.WriteLine("the prime number is:{0}",i) ;
                    tmp = 0;    
                }
                else
                {
                    tmp = 0;
                }
            }
        }
    }
}




            
        

    

