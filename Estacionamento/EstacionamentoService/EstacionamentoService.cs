namespace Estacionamento.EstacionamentoService
{
    internal class EstacionamentoService
    {
        public double ValorTotalGanhado { get; private set; }
        public static List<string> carrosEstacionados = new List<string>();

        public void AdicionaCarro(string placa)
        {
            carrosEstacionados.Add(placa);
            Console.WriteLine($"Placa {placa} inclusa com sucesso.");
        }

        public void ListaCarrosEstacionado()
        {
            foreach (string placa in carrosEstacionados)
            {
                Console.WriteLine($"Placa: {placa}");
            }
        }

        public void RemoveCarroEstacionado(string placa, double valorHora, double valorFixo)
        {
            if (carrosEstacionados.Remove(placa))
            {
                Console.WriteLine("Informe quantas horas o carro ficou:");
                int quantidadeHora = Convert.ToInt32(Console.ReadLine());
                var valorACobrar = Double.Round((valorHora * quantidadeHora) + valorFixo, 2);
                Console.WriteLine($"O Carro de placa {placa} deverá pagar R${valorACobrar}");
                ValorTotalGanhado += valorACobrar;
            }
            else
                Console.WriteLine("Placa não encontrada");

        }
    }

}
