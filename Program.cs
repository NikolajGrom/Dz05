using System;

namespace Dz05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Nobel University! ---\n");
            int[][] arrMark = new int[2][];

            // Initialize the elements.
            arrMark[0] = new int[5] { 1, 3, 5, 7, 9 };
            arrMark[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements.
            for (int i = 0; i < arrMark.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arrMark[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arrMark[i][j], j == (arrMark[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }

            Student student1 = new Student("Петя", "Петров", "Петрович", "2", 18, arrMark);
            student1.Print();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");

            System.Console.ReadKey();


        }
    }
}
