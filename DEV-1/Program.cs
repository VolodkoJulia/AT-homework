using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int k = 0; k <= 100; k++)
            {
                String num = k.ToString();
                if (k % 3 == 0)
                {
                    //num=k
                    Console.Write("3*" + k / 3);
                }
                else
                {
                    Console.Write(" "+ num + " ");
                }
            }
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
