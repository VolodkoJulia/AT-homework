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
                    num = "Tutti";
                }
                if (k % 5 == 0)
                {
                    num = "Frutti";
                }
                if ((k % 3 == 0) && (k % 5 == 0))
                {
                    num = "Tutti - Frutti";
                }
                Console.Write(" " + num + " ");
            }
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}

