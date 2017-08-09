using System;
namespace Numsequence
{
    class Allactions
    {
        public int[] NumberInput()
        {
            Console.Write("Entered the size of your sequence: N = ");
            String Arrsize = Console.ReadLine();
            int size = int.Parse(Arrsize);
            int[] Array = new int[size];
            return Array;

        }

        public void Result(int size, int[] Array)
        {
            int number = 0;
            for (int k = 1; k < size; k++)
            {
                if (Array[k] >= Array[k - 1])
                {
                    number++;
                }
            }
            if (number == 0)
            {
                Console.WriteLine("\n Your sequence is decreasing. ");
            }
            else
            {
                Console.WriteLine("\n Your sequence is increasing. ");
            }
            Console.ReadKey();
        }

    }
}
