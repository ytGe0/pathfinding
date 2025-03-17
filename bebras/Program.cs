using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebras
{
    internal class Program
    {
        static void Encode(char[,] chars, int i)
        {
            string encoded = "";
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int i3 = 0; i3 < i; i3++)
                {
                    string c = chars[i3, i2].ToString();
                    Console.Write(c.ToUpper());
                }
            } 
        }
        static void Main(string[] args)
        {
            string endec = Console.ReadLine();
            string toendec = Console.ReadLine();
            int i = toendec.Length / 4;
            if (toendec.Length % 4 != 0)
            {
                i += 1;
            }
            int count = 0;
            char[,] chars = new char[i, 4];
            for (int i2 = 0; i2 < i; i2++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    try
                    {
                        chars[i2, i3] = toendec[count];
                        count++;
                    }
                    catch
                    {
                        chars[i2, i3] = 'X';
                    }
                }
            }
            if (endec == "encode")
            {
                Encode(chars, i);
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
