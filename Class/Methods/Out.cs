using System;

namespace Class.Methods
{
    public class Out
    {
        static void Divider(int x, int y, out int result, out int rest)
        {
            result = x / y;
            rest = x % y;
        }

        public static void Divider()
        {
            Divider(15, 3, out int result, out int rest);
            Console.WriteLine($"{0} {1}", result, rest); // Outut: 5 1
    
        }
    }
}