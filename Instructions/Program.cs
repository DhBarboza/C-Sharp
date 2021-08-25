using System;

namespace Instructions
{
    class Program
    {
        // Declarar variáveis e constantes:
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
            for (int z = 0; z < args.Length; z++)
            {
                if (args[z].StartsWith("/"))
                {
                    continue;
                }

                Console.WriteLine($"{args[z]}");
            }
        }

        static void StructReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine($"{Somar(1, 2)}");
            Console.WriteLine($"{Somar(4, 7)}");
            Console.WriteLine($"{Somar(8, 9)}");
            return;
        }

        static void StructTryCatchFinallyThrow(string[] args)
        {
            double Divider(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe dois números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine($"{Divider(x, y)}");

            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine($"{e.Message}");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Erro generico {e.Message}");
            }

            finally
            {
                Console.WriteLine($"Bye!");
            }
        }

        static void StructUsing(string[] args)
        {

            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
