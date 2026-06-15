Console.Write("Informe a senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 1234)
{
    Console.WriteLine("Senha incorreta. Tente novamente.");

    Console.Write("Informe a senha: ");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso permitido.");