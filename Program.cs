using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário para escolher uma função
            Console.WriteLine("Digite um número de 1 a 6 para selecionar uma função:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Usa switch case para chamar a função correspondente
                switch (number)
                {
                    case 1:
                        Function1();
                        break;
                    case 2:
                        Function2();
                        break;
                    case 3:
                        Function3();
                        break;
                    case 4:
                        Function4();
                        break;
                    case 5:
                        Function5();
                        break;
                    case 6:
                        Function6();
                        break;
                    default:
                        Console.WriteLine("Número fora do intervalo (1 a 6).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            // Mantém a janela do console aberta até que o usuário pressione uma tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private static void Function1()
        {
            List<int> lstNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    lstNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    i--; // Repete a entrada atual
                }
            }

            int sum = 0;
            foreach (int num in lstNumbers)
            {
                sum += num;
            }

            Console.WriteLine("A soma dos números digitados é: " + sum);
        }

        private static void Function2()
        {
            List<string> diasDaSemana = new List<string>
            {
                "Segunda-feira",
                "Terça-feira",
                "Quarta-feira",
                "Quinta-feira",
                "Sexta-feira",
                "Sábado",
                "Domingo"
            };

            Console.WriteLine("Digite um número de 1 a 7 para verificar o dia da semana correspondente:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= 7)
                {
                    Console.WriteLine("O dia da semana correspondente é: " + diasDaSemana[number - 1]);
                }
                else
                {
                    Console.WriteLine("Número fora do intervalo (1 a 7).");
                }
            }
        }

        private static void Function3()
        {
            // Declaração de variáveis
            int soma = 0;
            int[] numeros = new int[100]; // Define um vetor com tamanho inicial (100 é um exemplo)
            int count = 0; // Conta o número de elementos armazenados no vetor

            while (true)
            {
                Console.WriteLine("Digite um número, só não pode digitar números negativos hihihi...");
                
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    Console.WriteLine("Você digitou: " + number);
                    soma += number;

                    // Adiciona o número ao vetor
                    if (count >= numeros.Length)
                    {
                        // Se o vetor está cheio, cria um vetor maior e copia os elementos
                        Array.Resize(ref numeros, numeros.Length * 2);
                    }
                    numeros[count++] = number; // Adiciona o número ao vetor e incrementa o contador
                }
                else
                {
                    Console.WriteLine($"Eu te avisei sem negativos, a soma de todos os números é: {soma}");

                    // Exibe todos os números armazenados
                    Console.WriteLine("Números digitados:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(numeros[i]);
                    }

                    break;
                }
            }
        }

        private static void Function4()
        {
            int[] numeros = new int[5];
            int count = 0;
            int maiorNumero = int.MinValue;

            while (count < 5)
            {
                Console.WriteLine($"Digite o {count + 1}º número:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numeros[count] = number;
                    if (number > maiorNumero)
                    {
                        maiorNumero = number;
                    }
                    count++;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }

            Console.WriteLine($"O maior número é: {maiorNumero}");
        }

        private static void Function5()
        {
            string[] caracteres = new string[5];
            int contadorVogais = 0;

            Console.WriteLine("Digite cinco caracteres:");

            // Ler 5 caracteres do usuário
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º caractere: ");
                caracteres[i] = Console.ReadLine();
            }

            // Contar quantos caracteres são vogais
            foreach (string caractere in caracteres)
            {
                if (caractere.Length > 0) // Verifica se o caractere não está vazio
                {
                    char primeiraLetra = char.ToLower(caractere[0]); // Converte o primeiro caractere para minúsculo
                    switch (primeiraLetra)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            contadorVogais++;
                            break;
                    }
                }
            }

            // Imprimir o resultado
            Console.WriteLine($"Número de vogais digitadas: {contadorVogais}");
        }

        private static void Function6()
        {
            int[] numeros = new int[8];
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Digite 8 números inteiros:");

            for (int i = 0; i < 8; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros[i] = numero;
                    
                    if (numero % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    i--; // Decrementa o índice para que o usuário tenha a chance de corrigir a entrada
                }
            }

            // Imprimir o número total de pares e ímpares
            Console.WriteLine($"Número total de pares: {pares}");
            Console.WriteLine($"Número total de ímpares: {impares}");
        }
    }
}
