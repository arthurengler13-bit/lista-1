double soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Informe o " + i + "º valor: ");
    double valor = double.Parse(Console.ReadLine());

    soma += valor;
}

double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);