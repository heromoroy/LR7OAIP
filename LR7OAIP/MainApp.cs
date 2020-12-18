using System;
using System.Dynamic;
using System.IO;

namespace LR7OAIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 31

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"romb_output.txt");
            var new_in = new StreamReader(@"romb_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Romb A2, B2;
#if !DEBUG
            A2 = Romb.GetRombFromFile();
            A2.Info();
            B2 = new Romb(5, 6);
            B2.Info();
#endif

#if DEBUG
            load.Info(ConsoleColor.Black, ConsoleColor.Red);
#endif
            
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif

        }
    }
}