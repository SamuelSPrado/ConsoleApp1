using System;
using System.Collections.Concurrent;

class Jogo
{
    static void Main(string[] args)
    {
        //Gerar um número aleatório entre 1 a 100
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativa;
        int tentativasFeitas = 0;
        bool acertou = false;

        Console.WriteLine(@"
█▄▄ █▀▀ █▀▄▀█ ▄▄ █░█ █ █▄░█ █▀▄ █▀█   ▄▀█ █▀█   ░░█ █▀█ █▀▀ █▀█   █▀▄ █▀▀
█▄█ ██▄ █░▀░█ ░░ ▀▄▀ █ █░▀█ █▄▀ █▄█   █▀█ █▄█   █▄█ █▄█ █▄█ █▄█   █▄▀ ██▄

▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ ▄▀█ █▀▀ ▄▀█ █▀█ █
█▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ █▀█ █▄▄ █▀█ █▄█ ▄");

        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        // Loop do-while para permitir múltiplas tentativas
        do
        {
            Console.WriteLine("Tentativa: ");
            tentativa = Convert.ToInt32(Console.ReadLine());
            tentativasFeitas++; // Incrementar o contador de tentativas

            //Verificar se a tratativa está correta
            if (tentativa == numeroAleatorio)
                acertou = true;
            else if (tentativa < numeroAleatorio)
                Console.WriteLine("Tente um numero maior!");
            else
                Console.WriteLine("Tente um numero menor!");

        } while (!acertou);

        Console.Clear();
        Console.WriteLine($"PARABÉNS! VOCÊ ACERTOU APÓS {tentativasFeitas} TENTATIVAS");

        Console.WriteLine($"Fim do jogo.");
    }
}