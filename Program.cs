Console.OutputEncoding = System.Text.Encoding.UTF8;


DesenharTela();
ExecutarLogin();

static void DesenharTela()
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("         Fila Zero - Login           ");
    Console.WriteLine("=====================================");
}

static void ExecutarLogin()
{
    Console.Write("Digite seu nome de usuário: ");
    string username = Console.ReadLine() ?? "";

    Console.Write("Digite sua senha: ");
    string password = Console.ReadLine() ?? "";

    // 🔄 Simula processamento (melhora UX)
    Console.Write("\n[VALIDANDO]");
    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(400);
        Console.Write(".");
    }

    if (username == "admin" && password == "senha123")
    {
        Console.WriteLine("\n");

        // 🟣 Ícone roxo separado
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("🟣 ");

        // ✔ Texto verde
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✔ Login bem-sucedido! Bem-vindo, admin.");

        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Erro: Nome de usuário ou senha incorretos.");

        Console.ResetColor();
    }
}