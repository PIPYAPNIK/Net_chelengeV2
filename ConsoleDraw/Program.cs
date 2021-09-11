using System;

namespace ConsoleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 50;
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Console.Write(
                        Math.Pow(i + j, 2) > Math.Pow(i - j, 4) ? "# " : ". "
                        //Math.Sqrt(i + j) >= Math.Sqrt(j - i) ? "# " : ". "
                        );

                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
