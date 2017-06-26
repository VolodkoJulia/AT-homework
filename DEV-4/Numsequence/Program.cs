using System;
namespace Numsequence
{
    class Numericalsequence
    {
        static void Main(string[] args)
        {
            bool length = true;
            while (length)
            {
                try
                {
                    Allactions input = new Allactions();
                    int[] Array = input.NumberInput();
                    int size = Array.Length;
                    //use method NumberInput from class Allactions
                    string stringAr;
                    //format output
                    if (size == 1)
                    {
                        Console.WriteLine("This is not sequence.");
                        continue;
                    }
                    else
                    {
                        for (int k = 0; k < size; k++)
                        {
                            Console.Write("Enter the number of sequence [" + (k + 1) + "] = ");
                            stringAr = Console.ReadLine();
                            Array[k] = int.Parse(stringAr);
                        }
                        Console.Write("Your sequence is : ");
                        for (int k = 0; k < size; k++)
                        {
                            Console.Write(Array[k] + " ");
                        }
                        //use method Result from class Allactions
                        input.Result(size, Array);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The entered data is not a number. You can try once again.");
                    continue;
                }
                length = false;
                Console.ReadKey();
            }
        }
    }
}
