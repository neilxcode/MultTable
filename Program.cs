using System;

namespace MultTable
{
   class MultTable
    {
        static void Main(string[] args)
        {
            int paraMeter;

            Console.WriteLine("Parameter:");
            do 
            {
            paraMeter = Convert.ToInt32(Console.ReadLine());
            }

            while (paraMeter < 0 || paraMeter > 10);

            
            Console.WriteLine("{0}x{0} Table", paraMeter, paraMeter);
            for (int i = 1; i <= paraMeter; i++)
            {
                Console.WriteLine("\n");
                    for (int j = 1; j <= paraMeter; j++)
                    {
                        Console.Write(i * j + " ");
                    }
            }
            Console.Write("\n");  
        }
    }
}
