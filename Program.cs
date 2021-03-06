using System;

namespace Dz05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Nobel University! ---\n");
             Console.WriteLine("------------- Array Mark1  -------------\n");
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

            Console.WriteLine("------------- Array Mark2 -------------\n");

            int[][] arryMark = new int[2][];

            // Initialize the elements.
            arryMark[0] = new int[3] { 1, 3, 5 };
            arryMark[1] = new int[4] { 5, 8, 8, 8 };

            // Display the array elements.
            for (int i = 0; i < arryMark.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arryMark[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arryMark[i][j], j == (arryMark[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            

            Student student1 = new Student("Петя", "Петров", "Петрович", "PO2", 18, arrMark);
            student1.Print();
            Student student2 = new Student("Vasya", "Vasiliev", "Vasilevich", "PV2", 18, arryMark);
            student1.Print();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");

            System.Console.ReadKey();


        }
    }
}
