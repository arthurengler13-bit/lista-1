Console.Write("Informe a quantidade de tarefas concluídas: ");
int tarefas = int.Parse(Console.ReadLine());

if (tarefas >= 50)
{
    Console.WriteLine("Meta atingida.");
    Console.WriteLine("Tarefas concluídas: " + tarefas);
}
else
{
    int faltaram = 50 - tarefas;

    Console.WriteLine("Meta não atingida.");
    Console.WriteLine("Faltaram " + faltaram + " tarefas.");
}