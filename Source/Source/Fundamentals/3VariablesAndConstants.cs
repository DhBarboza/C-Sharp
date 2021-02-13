using System;


namespace Source.Fundamentals {
    class VariablesAndConstants {
        public static void Run() {
            // Declarar uma Váriavel:
            double radius = 5.10;

            // Declarar uma Constante:
            const double PI = 3.14;

            // Variaveis podem ter o valor alterado: 
            radius = 4.15;

            // Declarar variavies com funções aritiméticas:
            double area = PI * radius * radius;
            Console.WriteLine("Valor da area: " + area);

            // Tipos:
            // Boolean True or False:
            bool sun = true;
            Console.WriteLine("O dia está ensolarado: "  +  sun);

            // Byte são 8 bits;
            // Byte não armazena valor negativo!
            byte valueByte1 = byte.MinValue;
            byte valueByte2 = byte.MaxValue;
            Console.WriteLine("Byte armazena de " + valueByte1 + " a " + valueByte2);

            sbyte valueSByte1 = sbyte.MinValue;
            sbyte valueSByte2 = sbyte.MaxValue;
            Console.WriteLine("sbyte armazaena de " + valueSByte1 + " a " + valueSByte2);

            // Short são 2 Bytes;
            short valueShort1 = short.MinValue;
            short valueShort2 = short.MaxValue;
            Console.WriteLine("Short Armazena de " + valueShort1 + " a " + valueShort2);

            // Int são 4 Bytes;
            int valueInt1 = int.MinValue;
            int valueInt2 = int.MaxValue;
            Console.WriteLine("Int ele armazena de " + valueInt1 + " a " + valueInt2);
            uint valueUInt1 = uint.MinValue;
            uint valueUInt2 = uint.MaxValue;
            Console.WriteLine("UInt ele armazena de " + valueUInt1 + " a " + valueUInt2);

            // Long são 8 Bytes;
            long valueLong1 = long.MinValue;
            long valueLong2 = long.MaxValue;
            Console.WriteLine("Long armezana de " + valueLong1 + " a " + valueLong2);
            ulong valueULong1 = ulong.MinValue;
            ulong valueULong2 = ulong.MaxValue;
            Console.WriteLine("ULong armezana de " + valueULong1 + " a " + valueULong2);

            // Valores Reais
            // Float
            // Para declarar o float devemos utilizar caractere "f" no final do valoe, exemplo:
            // float valor = 12000.00f;
            float valueFloat1 = float.MinValue;
            float valueFloat2 = float.MaxValue;
            Console.WriteLine("Float armazena " + valueFloat1  + " a " + valueFloat2);

            // Double
            double valueDouble1 = double.MinValue;
            double valueDouble2 = double.MaxValue;
            Console.WriteLine("Double armazena " + valueDouble1 + " a " + valueDouble2);

            // Decimal
            decimal valueDecimal1 = decimal.MinValue;
            decimal valueDecimal2 = decimal.MaxValue;
            Console.WriteLine("Decimal armazena " + valueDecimal1 + " a " + valueDecimal2);

            // Characteres, para armazenar apenas um aletra use aspas simples
            char caracterer = 'a';
            Console.WriteLine("Letra: " + caracterer);

            // String para palavras:
            string word = "Uma Frase bonita";
            Console.WriteLine("Eu escrevi " + word);

        }
    }
}
