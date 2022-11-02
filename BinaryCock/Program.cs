// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            p1();
        }
        static void p1()
        {
            string[] s = DateTime.Now.ToString("HH:mm:ss").Split(':');
            int ora = int.Parse(s[0]);
            int minut = int.Parse(s[1]);
            int sec = int.Parse(s[2]);
            int[] v1 = new int[5];
            int[] v2 = new int[6];
            int[] v3 = new int[6];
            int n = 4;
            while(ora > 0)
            {
                v1[n--] = ora % 2;
                ora /= 2;
            }
            n = 5;
            while(minut>0)
            {
                v2[n--]=minut % 2;
                minut /= 2;
            }
            n = 5;
            while(sec>0)
            {
                v3[n--] = sec % 2;
                sec /= 2;
            }
            Console.Write("  ");
            for(int i=0;i<5;i++)
            {
                if (v1[i] == 1)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write(v1[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                if (v2[i] == 1)
                {
                    Console.Write("Y ");
                }
                else
                {
                    Console.Write(v2[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                if (v3[i] == 1)
                {
                    Console.Write("Z ");
                }
                else
                {
                    Console.Write(v3[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}