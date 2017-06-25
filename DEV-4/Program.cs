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
                    Console.Write("Entered the size of your sequence: N = ");
                    String Arrsize = Console.ReadLine();
                    int size = int.Parse(Arrsize);
                    int[] Array = new int[size];
                    string stringAr;
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
