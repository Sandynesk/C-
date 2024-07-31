using System;

class Program
{
    static void Main()
    {
        const int numeroPessoas = 4; // Número de pessoas
        const int numeroNotas = 4; // Número de notas por pessoa
        const double notaMinima = 6.0; // Nota mínima para aprovação

        // Cria um array para armazenar as notas de cada pessoa
        int[,] notasPorPessoa = new int[numeroPessoas, numeroNotas];

        // Coleta as notas de cada pessoa
        for (int i = 0; i < numeroPessoas; i++)
        {
            Console.WriteLine($"Digite as {numeroNotas} notas para a pessoa {i + 1}:");

            for (int j = 0; j < numeroNotas; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                notasPorPessoa[i, j] = nota; // Armazena a nota no array
            }
        }

        // Processa as notas e exibe a média e o resultado
        for (int i = 0; i < numeroPessoas; i++)
        {
            int soma = 0;

            for (int j = 0; j < numeroNotas; j++)
            {
                soma += notasPorPessoa[i, j]; // Calcula a soma das notas
            }

            double media = soma / (double)numeroNotas; // Calcula a média
            Console.WriteLine($"\nMédia das notas da pessoa {i + 1}: {media:F2}");

            if (media >= notaMinima)
            {
                Console.WriteLine("Parabéns! Você foi aprovado.");
            }
            else
            {
                Console.WriteLine("Infelizmente, você foi reprovado.");
            }
        }
    }
}
