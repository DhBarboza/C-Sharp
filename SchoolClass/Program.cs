using System;

namespace SchoolClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] alunos = new Student[5];

            int indiceAluno = 0;

            string userOption = Options();


            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Student aluno = new Student();
                        Console.WriteLine("Nome do aluno: ");
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal notaDecimal))
                        {
                            aluno.Nota = notaDecimal;
                        } else {
                            throw new ArgumentException("O valor da Nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                userOption = Options();
            }

        }

        private static string Options()
        {
            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Calcular média Geral");
            Console.WriteLine("X - Sair\n");

            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
