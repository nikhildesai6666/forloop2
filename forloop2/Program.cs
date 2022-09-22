using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num/2; i++)
            {
                if(num%2 == 0)
                {
                    Console.WriteLine($"number is not primr , {num}");
                }
                else
                {
                    Console.WriteLine($" number is primr , {num}");
                }
            }
          
        }
    }
}
