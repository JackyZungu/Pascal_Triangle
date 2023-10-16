using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("Enter the number of rows of the Pascal triangle to print:");
                
            int rows = int.Parse(Console.ReadLine());
                {

                    if (rows < 1)
                    {
                        Console.WriteLine("The number of rows must be at least 1.");
                        return;
                    }
                    PrintPascalTriangle(rows);
                    /*Console.Write(" ");
                    Console.WriteLine("Enter another row number");
                    PrintPascalTriangle(rows);*/
                }
            }
                 catch
            {
                Console.WriteLine("Invalid entry");
                Console.ReadLine();
            }
        }
        static void PrintPascalTriangle(int rows)

        {
            try
            {
                // Create a jagged array to store the Pascal triangle.
                int[][] pascalTriangle = new int[rows][];

                pascalTriangle[0] = new int[] { 1 };

                for (int i = 1; i < rows; i++)
                {
                    pascalTriangle[i] = new int[i + 1];
                    pascalTriangle[i][0] = 1;
                    pascalTriangle[i][i] = 1;
                    for (int j = 1; j < i; j++)
                    {
                        pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int b = 1; b < rows - i; b++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < pascalTriangle[i].Length; j++)
                    {
                        Console.Write(pascalTriangle[i][j] + " ");
                        
                    }
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}

      
 

