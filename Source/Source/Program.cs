using System;
using System.Collections.Generic;

using Source.Fundamentals;

namespace Source {
    class Program {
        static void Main(string[] args) {
            var central = new ExerciseCenter(new Dictionary<string, Action>() {
                {"FirstProgram - Fundamentals", FirstProgram.Run},
                {"Comments - Fundamentals", Comments.Run},
                {"Variables and Constants - Fundamentals", VariablesAndConstants.Run},
            });

            // Método "Selecionar e Executar" do arquivo "CentralDeExercicios.cs":
            central.SelectAndExecute();
        }
    }
}