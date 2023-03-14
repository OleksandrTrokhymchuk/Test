using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            int height;
            int width;
            Random random = new Random();
            Console.Write("Heigth = ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Width = ");
            width = int.Parse(Console.ReadLine());
            int[,] Array1 = new int[height,width];
            Console.Write("Main Array:\n");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write((Array1[y, x] = random.Next(10, 50)) + "\t");
                }
                Console.WriteLine("\t");
                Console.WriteLine();
            }
            
            int a = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int c = Array1[y, x];            
                    if (c > 30)
                    {
                        a += c;
                    }                             
                }               
            }
            Console.WriteLine("Sum of elements greater 30 = " + a);
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}