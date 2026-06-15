Console.Write("Informe a quantidade de clientes atendidos: ");
int quantidadeClientes = int.Parse(Console.ReadLine());

int tempoTotal = 0;

for (int i = 1; i <= quantidadeClientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine());

    tempoTotal += tempo;
}

double tempoMedio = (double)tempoTotal / quantidadeClientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");