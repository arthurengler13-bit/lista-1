Console.Write("Informe a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 11)
{
    Console.WriteLine("Faixa etária: criança.");
}
else if (idade <= 17)
{
    Console.WriteLine("Faixa etária: adolescente.");
}
else if (idade <= 59)
{
    Console.WriteLine("Faixa etária: adulto.");
}
else
{
    Console.WriteLine("Faixa etária: idoso.");
}