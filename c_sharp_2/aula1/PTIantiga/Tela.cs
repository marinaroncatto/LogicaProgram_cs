public class Tela
{

    public int ExibirMenu()
    {
        Console.WriteLine("-- ESTOQUE LIVRARIA --");
        Console.WriteLine("1. Novo Livro");
        Console.WriteLine("2. Listar Livros");
        Console.WriteLine("3. Remover Livro");
        Console.WriteLine("4. Entrada Estoque");
        Console.WriteLine("5. Saída Estoque");
        Console.WriteLine("0. Sair");
        return Convert.ToInt32(Console.ReadLine());
    }
    public string PedirTexto(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }

    public int PedirInt(string msg)
    {
        Console.WriteLine(msg);
        return Convert.ToInt32(Console.ReadLine());
    }

    public double PedirDouble(string msg)
    {
        Console.WriteLine(msg);
        return Convert.ToDouble(Console.ReadLine());
    }
}