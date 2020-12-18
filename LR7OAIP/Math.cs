using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace LR7OAIP
{
    class Romb
    {

        public double A1, B1; // первое число - горизонтальная диагональ, второе - вертикальная диагональ

        public Romb() { }

        public Romb(double a, double b)
        {
            A1 = a;
            B1 = b;
        }

        

        public void Load()
        {
            A1 = Convert.ToInt32(Console.ReadLine());
            B1 = Convert.ToInt32(Console.ReadLine());
        }
 
        public static Romb GetRombFromFile()
        {
            double AA1 = Convert.ToDouble(Console.ReadLine());
            double BB1 = Convert.ToDouble(Console.ReadLine());
            return new Romb(AA1, BB1);
        }

        public void RombPic()
        {
            
        }

        public double SofRomb()
        {
            return (A1 * B1 * 0.5);
        }
        public double RofRomb()
        {
            return (Math.Sqrt((A1 / 2) * (A1 / 2) + (B1 / 2) * (B1 / 2)));
        }

        public void Info()
        {
#if DEBUG
            Console.WriteLine("введите данные A и B:");
#endif

#if DEBUG
            Console.WriteLine();
#endif
            String str =
                "******* *******\n" +
                "*****     *****\n" +
                "***         ***\n" +
                "*     Ромб    *\n" +
                "***         ***\n" +
                "*****     *****\n" +
                "******* *******\n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format(
                "Горизональная диагональ = {0:0.00}, вертикальная диагональ = {0:0.00}", A1, B1));
            Console.WriteLine("Периметр = {0:0.00} ", RofRomb());
            Console.WriteLine("Площадь = {0:0.00} ", SofRomb());
            Console.WriteLine();
        }

#if DEBUG
        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();

        }
#endif
    }
}