Console.Write("Informe o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (numero2 > numero1)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}