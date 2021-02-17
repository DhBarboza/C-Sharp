using System;


namespace Source.Fundamentals {
    class Inference {
        public static void Run() {
            // Podenmos declarar váriaveis utilizando "var", C# reconhece o tipo
            var name = "Douglas";
            Console.WriteLine(name);

            var age = 34;
            Console.WriteLine(age);

            var typeName = name.GetType();
            var typeAge = age.GetType();

            Console.WriteLine("A variavel name é do tipo: " + typeName);
            Console.WriteLine("A variavel age é do tipo: " + typeAge);
        }
    }
}
