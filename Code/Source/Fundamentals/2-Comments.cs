using System;

namespace Source.Fundamentals {
    class Comments {
        public static void Run() {

            // Evite comentários desnecessários 
            Console.WriteLine("Busque sempre deixar seu código o mais claro possível");

            // Esse recurso é utilizado para documentação do seu código:
            Console.WriteLine("C# possí recurso de XML Comments: Adicionar '///' três barras");
            ///<summary>
            /// Utilizasse essa semântica para documentar o seu código
            ///</summary>
             

            // Teclas de atalho para produtividade:
            Console.WriteLine("'Ctrl + K + C': Comenta o código selecionado");
            Console.WriteLine("'Ctrl + k + U: Descomenta o código selecionado");

            // Comentários de Multiplas Linhas:
            /*
             * Adicionando barra e asterísco
             */
        }
    }
}
