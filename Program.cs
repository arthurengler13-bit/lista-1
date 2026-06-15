Console.Write("Informe a idade do visitante: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 16)
{
 Console.WriteLine("Entrada liberada."); 
}   
 else
{
 Console.WriteLine("Entrada permitida somente com responsável.");
}   
