using System;

namespace Instructions
{
    class Program
    {
        static void Declarations()
        {
            int a = 1;
            int b = 2, c = 3;
            const int d = 4;
            Console.WriteLine(a + b + c + d);
        }

        static void StructIF(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Não há argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Apenas um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} arguentos");
            }
        }

        static void StructSwitch(string[] args)
        {
            int arguments = args.Length;
            switch (arguments)
            {
                case 0: Console.WriteLine("Não há argumento"); break;
                case 1: Console.WriteLine("Apenas um argumento"); break;
                default: Console.WriteLine($"{args.Length} arguentos"); break;
            }
        }

        static void StructWhile(string[] args)
        {
            int x = 0;
            while (x < args.Length)
            {
                Console.WriteLine($"{args[x]}");
                x++;
            }
        }

        static void StructDo(string[] args)
        {
            string text;
            do
            {
                text = Console.ReadLine();
                Console.WriteLine(text);
            } while (!string.IsNullOrEmpty(text));
        }

        static void StructFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void StructForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void StructBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine($"{s}");
            }
        }

        static void StructContinue(string[] args)
        {

        }


    }
}
