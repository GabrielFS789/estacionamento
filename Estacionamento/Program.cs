using Estacionamento.EstacionamentoService;

EstacionamentoService estacionamentoServices = new EstacionamentoService();

Console.WriteLine("Digite o preço inicial: ");
double valorInicial = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

Console.WriteLine("Digite o valor por hora: ");
double valorPorHora = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

Console.Clear();




while (true)
{
    Console.Clear();
    Console.WriteLine("Bem Vindo ao sistema de estacionamento!");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Listar veiculos");
    Console.WriteLine("3 - Remover veiculo");
    Console.WriteLine("4 - Visualziar Valores por hora e fixo");
    Console.WriteLine("5 - Visualziar Valor Ganho");
    Console.WriteLine("6 - Alterar valores");
    Console.WriteLine("0 - Encerrar");

    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe a placa do carro");
            string placa = Console.ReadLine();
            estacionamentoServices.AdicionaCarro(placa);
            Console.ReadKey();
            break;
        case 2:
            estacionamentoServices.ListaCarrosEstacionado();
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Informe a placa para remover");
            placa = Console.ReadLine();
            estacionamentoServices.RemoveCarroEstacionado(placa, valorPorHora, valorInicial);

            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine($"Valor Fixo: R${valorInicial}\n" +
                $"Valor por Hora: R${valorPorHora}");
            Console.ReadKey();
            break;

        case 5:
            Console.WriteLine($"Total Ganho: R${estacionamentoServices.ValorTotalGanhado}");
            Console.ReadKey(); break;

        case 6:
            Console.WriteLine("Digite o preço inicial: ");
            valorInicial = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor por hora: ");
            valorPorHora = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            break;
        case 0:
            Console.WriteLine("Encerrando");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }
}
