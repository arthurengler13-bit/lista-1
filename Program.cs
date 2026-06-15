Console.Write("Informe uma nota de 0 a 10: ");
double nota = double.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida. Informe novamente.");

    Console.Write("Informe uma nota de 0 a 10: ");
    nota = double.Parse(Console.ReadLine());
}

Console.WriteLine("Nota registrada: " + nota);