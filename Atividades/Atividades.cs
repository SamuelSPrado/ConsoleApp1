using System;
using System.Collections.Generic;
class Atividades
{
    internal void Exercicios(string[] args)
    {
        Atividades exercicio = new Atividades();
        exercicio.atividade1();
        exercicio.atividade2();
    }


    void atividade1()
    {
        // 1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
        Console.WriteLine("Digite a nota média: ");
        string notaMedia = Console.ReadLine();
        int notaMediaN;
        if (int.TryParse(notaMedia, out notaMediaN))
        {
            if (notaMediaN >= 5)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }

    void atividade2()
    {
        // 2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
        List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };

        // 3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
        Console.WriteLine("Primeira linguagem de programação: " + linguagens[0]);

        // 4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
        Console.WriteLine("Digite um número para a posição na lista: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n < linguagens.Count)
            Console.WriteLine($"Posição {n}: {linguagens[n]}");
        else
            Console.WriteLine("Inválido!");
    }
}

