Console.Write("Informe o saldo inicial: ");
double saldo = double.Parse(Console.ReadLine());

int operacao;

do
{
    Console.Write("Escolha a operação: ");
    operacao = int.Parse(Console.ReadLine());

    if (operacao == 1)
    {
        Console.Write("Informe o valor da movimentação: ");
        double valor = double.Parse(Console.ReadLine());

        saldo += valor;

        Console.WriteLine("Entrada registrada. Saldo atual: R$ " + saldo);
    }
    else if (operacao == 2)
    {
        Console.Write("Informe o valor da movimentação: ");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine("Saída registrada. Saldo atual: R$ " + saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

} while (operacao != 3);

Console.WriteLine("Saldo final: R$ " + saldo);