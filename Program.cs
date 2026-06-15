Console.Write("Informe o valor total da compra: ");
double valorOriginal = double.Parse(Console.ReadLine());

double desconto = 0;

if (valorOriginal >= 200)
{
    desconto = valorOriginal * 0.10;
}

double valorFinal = valorOriginal - desconto;

Console.WriteLine("Valor original: R$ " + valorOriginal);
Console.WriteLine("Desconto aplicado: R$ " + desconto);
Console.WriteLine("Valor final: R$ " + valorFinal);