using System;

namespace Class.Methods
{
    public class Ref
    {
        static void Invert(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Invert()
        {
            int i = 1, j = 2;
            Invert(ref i, ref j);
            Console.WriteLine($"{i} {j}");  // Output: "2 1"
        }
    }
}