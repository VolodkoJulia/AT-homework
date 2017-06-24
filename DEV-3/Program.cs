using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thr Implementation of the Fibonacci sequence

class FibonacciSequence

{
    public void FibonacciNumber(int number)
    {
        int Numb1 = 1, Numb2 = 1, NumbN = 1;
        bool checkFib = false;
        for (int i = 0; i < number; i++)
        {
            Numb1 = Numb2;
            Numb2 = NumbN;
            NumbN = Numb1 + Numb2;
            if (number == NumbN || number == 1)
            {
                checkFib = true;
                break;
            }
        }
        if (checkFib)
        {
            Console.WriteLine("This is the Fibonacci number.");
        }
        else
        {
            Console.WriteLine("This is not the Fibonacci number.");
        }
    }
}

// exclusions
namespace FibonacciNumbers
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            bool length = true;
            while (length)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("It is a negative number. Try again");
                        continue;
                    }
                    else
                    {
                        FibonacciSequence fibonacciSequence = new FibonacciSequence();
                        fibonacciSequence.FibonacciNumber(number);
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                length = false;
            }
        }
    }
}
