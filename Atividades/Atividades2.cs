using System;

namespace Atividades
{
    class Atividades2
    {
        static void Main(string[] args)
        {
            //exercicio 1
            ExibirOperacoesBasicas(10.5, 5.5);

            //Exercicio 2
            List<string> bandasPrediletas = new List<string>();
            AdicionarBandas(bandasPrediletas, "Led Zeppelin");
            AdicionarBandas(bandasPrediletas, "AC / DC");
            AdicionarBandas(bandasPrediletas, "Metálica");

            // Exercicio 3
            Console.WriteLine("Minhas bandas prediletas:");
            for (int i = 0; i < bandasPrediletas.Count; i++) { Console.WriteLine(bandasPrediletas[i]); }
 
            // Exercicio 4
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            int soma = CalcularSoma(numeros);
            Console.WriteLine($"A soma de todos os elementos inteiros na lista é: {soma}");
        }

        //Exercicio 1
        static void ExibirOperacoesBasicas(double a, double b)
        {
            // Adição
            Console.WriteLine($"Adição: {a} + {b} = {a + b}");

            // Subtração
            Console.WriteLine($"Subtração: {a} - {b} = {a - b}");

            // Divisão
            if (b != 0)
                Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
            else
                Console.WriteLine("Não é possível dividir por zero!");

            // Multiplicação
            Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");
        }

        //Exercicio 2
        static void AdicionarBandas(List<string> listaDeBandas, string banda)
        {
            listaDeBandas.Add(banda);
        }

        //Exercicio 4
        static int CalcularSoma(List<int> lista)
        {
            int soma = 0;
            foreach (int numero in lista)
            {
                soma += numero;
            }
            return soma;
        }
    }
}
