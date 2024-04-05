
//List<string> listaBandas = new List<string> { "U2", "Black Sabbath", "Iron Maiden", "Kiss" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); //Criando dicionário vazio
bandasRegistradas.Add("U2", new List<int> { 10, 9, 5, 3, 8 });
bandasRegistradas.Add("Link Park", new List<int>());

void Logo()
{
    string msg = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
    Console.WriteLine(msg);
    Thread.Sleep(1000);
}

void Load()
{
    Console.WriteLine("\nCarregando menu de opções...\n");
    Thread.Sleep(3000);
    Console.Clear();
}

void Menu()
{
    Logo();
    Console.WriteLine("BEM VINDO Á SCREEN SOUND!\n");
    Console.WriteLine("1. Registrar: ");
    Console.WriteLine("2. Bandas: ");
    Console.WriteLine("3. Avaliar: ");
    Console.WriteLine("4. Média Avaliação: ");
    Console.WriteLine("5. Sair: ");

    Console.WriteLine("\nDigite sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoN = int.Parse(opcao);
    switch (opcaoN)
    {
        case 1: Registrar(); break; 
        case 2: ListaBandas(); break;
        case 3: Console.WriteLine("Opção escolhida: " + opcaoN); break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoN); break;
        case 5: Console.WriteLine("Opção escolhida: " + opcaoN); break;
        default: Console.WriteLine("Opção inválida!"); break;
    }
}

void Registrar()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda desejada: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"Banda {nomeBanda} registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

void ListaBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibição das Bandas");
    /*
    for (int banda = 0; banda < listaBandas.Count; banda++)
    {
        Console.WriteLine($"Banda: {listaBandas[banda]}");
    }
    */
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\n-- Voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Menu();
}


void Avaliar()
{

}

void MediaAvaliacao()
{

}

void Sair()
{
    Console.WriteLine(Menu + "\nSaindo do programa...");
    Thread.Sleep(3000);
    
}

void ExibirTituloDaOpcao(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos + "\n" + titulo + "\n" + asteriscos + "\n");
}

Menu();


// Resolvendo ...

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par
        Console.WriteLine(numeros[i]);
}

foreach (int numero in numeros)
{
    if (numero % 2 == 0) Console.WriteLine(numero);
}