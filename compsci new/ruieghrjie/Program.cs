using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ruieghrjie
{
    internal class Program
    {
        static void Print(int[,] Array, int[] col, int[] row)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != col[1] && i != row[5])
                    {
                        Console.Write(Array[i, j]); 
                    }
                    else if (j != col[1] && i == row[5])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Array[i, j]);
                    }
                    else if (i != row[5] && j == col[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(Array[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Array[i, j]);
                    }
                    Console.ResetColor();
                    Console.Write('|');
                }
                Console.Write(row[i] + "\n");
            }
        }

        static void Setup(ref int[,] Array)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Array[i, j] = rnd.Next(10, 100);
                }
            }
        }

        static void Sum(ref int[] col, ref int[] row, int[,] Array)
        {
            int sumtotal = 0; int highest = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sumtotal += Array[i, j];
                }
                row[i] = sumtotal;
                if (row[i] > highest)
                {
                    highest = row[i];
                    row [5] = i;
                }
                sumtotal = 0;
            }
            sumtotal = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sumtotal += Array[j, i];
                }
                if (sumtotal > col[0])
                {
                    col[0] = sumtotal;
                    col[1] = i;
                }
                sumtotal = 0;
            }
        }

        static void Main(string[] args)
        {
            int[] col = new int[2]; int[] row = new int[6];
            int[,] Array = new int[5,5]; 
            Setup(ref Array);
            Sum(ref col, ref row, Array);
            Print(Array, col, row);
            Console.ReadKey();
        }
    }
}
