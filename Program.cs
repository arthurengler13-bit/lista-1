Random random = new Random();

Console.WriteLine("=== FINAL DA COPA ===");
Console.WriteLine("Real Madrid 1 x 1 Barcelona");
Console.WriteLine("80 minutos.");
Console.WriteLine("Mbappé sai.");
Console.WriteLine("Você entra!");

Console.WriteLine();
Console.WriteLine("Barcelona está atacando.");

Console.WriteLine("1 - Pressionar");
Console.WriteLine("2 - Não marcar");
Console.WriteLine("3 - Dar bote");

Console.Write("Escolha: ");
int escolha = int.Parse(Console.ReadLine());

int sorte = random.Next(1, 101);

bool bolaRecuperada = false;

if (escolha == 1)
{
    if (sorte <= 50)
    {
        Console.WriteLine("Você pressionou e roubou a bola!");
        bolaRecuperada = true;
    }
    else
    {
        Console.WriteLine("O atacante escapou da marcação!");
    }
}
else if (escolha == 2)
{
    if (sorte <= 80)
    {
        Console.WriteLine("Barcelona criou uma grande chance!");
    }
    else
    {
        Console.WriteLine("Eles erraram o passe.");
        bolaRecuperada = true;
    }
}
else
{
    if (sorte <= 60)
    {
        Console.WriteLine("Bote perfeito! Bola recuperada!");
        bolaRecuperada = true;
    }
    else
    {
        Console.WriteLine("Falta perigosa cometida!");
    }
}

if (bolaRecuperada)
{
    Console.WriteLine();
    Console.WriteLine("O que fazer com a bola?");

    Console.WriteLine("1 - Tocar para Vini Jr");
    Console.WriteLine("2 - Tocar para Valverde");
    Console.WriteLine("3 - Tocar para Endrick");
    Console.WriteLine("4 - Conduzir");
    Console.WriteLine("5 - Chutar de longe");

    Console.Write("Escolha: ");
    int jogada = int.Parse(Console.ReadLine());

    sorte = random.Next(1, 101);

    if (jogada == 1)
    {
        if (sorte <= 70)
        {
            Console.WriteLine("Vini devolveu a bola. Você está na área!");
        }
        else
        {
            Console.WriteLine("Vini perdeu a bola.");
        }
    }
    else if (jogada == 2)
    {
        if (sorte <= 85)
        {
            Console.WriteLine("Valverde lançou você na cara do gol!");
        }
        else
        {
            Console.WriteLine("Passe interceptado.");
        }
    }
    else if (jogada == 3)
    {
        if (sorte <= 60)
        {
            Console.WriteLine("Tabela perfeita com Endrick!");
        }
        else
        {
            Console.WriteLine("Endrick errou o passe.");
        }
    }
    else if (jogada == 4)
    {
        if (sorte <= 50)
        {
            Console.WriteLine("Você driblou dois jogadores!");
        }
        else
        {
            Console.WriteLine("Foi desarmado.");
        }
    }
    else
    {
        if (sorte <= 15)
        {
            Console.WriteLine("GOOOOOOOL DE MUITO LONGE!");
            Console.WriteLine("REAL MADRID CAMPEÃO!");
        }
        else
        {
            Console.WriteLine("A bola foi para fora.");
        }
    }
}