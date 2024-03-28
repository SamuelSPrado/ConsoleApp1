void msg()
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
}

void menu()
{
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
        case 1: Console.WriteLine("Opção escolhida: " + opcaoN);
            break; 
        case 2: Console.WriteLine("Opção escolhida: " + opcaoN);
            break;
        case 3: Console.WriteLine("Opção escolhida: " + opcaoN);
            break;
        case 4: Console.WriteLine("Opção escolhida: " + opcaoN);
            break;
        case 5: Console.WriteLine("Opção escolhida: " + opcaoN);
            break;
        default: Console.WriteLine("Opção inválida!");
            break;

    }
}

