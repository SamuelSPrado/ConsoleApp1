
//List<string> listaBandas = new List<string> { "U2", "Black Sabbath", "Iron Maiden", "Kiss" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>
{
    { "U2", new List<int> { 10, 9, 5, 3, 8 } },
    { "Link Park", new List<int>() }
};

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
static void Carregamento(string nomeCarregamento, int qntTempo)
{
    Console.WriteLine(nomeCarregamento);
    Thread.Sleep(qntTempo);
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
        case 3: Avaliar(); break;
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
    Carregamento($"Banda {nomeBanda} registrada com sucesso!", 3000);
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

    Carregamento("\n-- Voltar ao menu principal", 2000);
    Menu();
}

void Avaliar()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalie sua banda!");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Atribua uma nota de 1 à 10 para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota < 0 || nota > 10)
        {
            Carregamento("\"Nota inválda! Deve ser entre 0 à 10\"", 2000);
            Avaliar();
        }
        else
        {
            bandasRegistradas[nomeBanda].Add(nota);
            Carregamento($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}", 3000);
            Menu();
        }
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada no registro. Deseja registrar?\n");
        Console.WriteLine("1 - Sim\n2 - Ver Bandas Registradas\n3 - Voltar ao Menu principal");
        string opcao = Console.ReadLine()!;
        int opcaoN = int.Parse(opcao);
        switch (opcaoN)
        {
            case 1: Registrar(); break;
            case 2: ListaBandas(); break;
            case 3: Menu(); break;
            default: Console.WriteLine("Opção inválida!"); break;
        }
    }

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

// Exercícios
void VerificaPar()
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] % 2 == 0) // Verifica se o número é par
            Console.WriteLine(numeros[i]);
    }

    foreach (int numero in numeros)
    {
        if (numero % 2 == 0) Console.WriteLine(numero);
    }
} // Resolvendo ...

void TirarMedia()
{
    Dictionary<string, List<double>> alunoNotas = new Dictionary<string, List<double>>
        {
            { "João", new List<double> { 7.5, 8.0, 9.5 } },
            { "Maria", new List<double> { 6.0, 7.0, 8.0 } },
            { "Pedro", new List<double> { 9.0, 9.5, 9.0 } }
        };

    foreach (var aluno in alunoNotas)
    {
        double media = aluno.Value.Average();
        Console.WriteLine($"Média de notas de {aluno.Key}: {media}");
    }
} // Resolvendo 2 ...

static void Estoque()
{
    // Dicionário para armazenar produtos e suas quantidades em estoque
    Dictionary<string, int> estoque = new Dictionary<string, int>
        {
            { "cerveja", 254 },
            { "biscoito", 159 }
        };

    // Solicitar ao usuário o nome do produto
    Console.Write("Digite o nome do produto: ");
    string nomeProduto = Console.ReadLine()!;

    // Verificar se o produto está no estoque e exibir sua quantidade 'Dictionary<TKey, TValue>'
    if (estoque.ContainsKey(nomeProduto))
    {
        int quantidade = estoque[nomeProduto];
        Console.WriteLine($"Quantidade em estoque de {nomeProduto}: {quantidade}");
    }
    else
    {
        Console.WriteLine($"O produto '{nomeProduto}' não está em estoque.");
    }
}

// Executando
Estoque();