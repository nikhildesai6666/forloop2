using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop2
{
    internal class fibnosis
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < num; i++) ;
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3);
            }
            
                
        }
}
