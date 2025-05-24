public class GerenciarEstoque
{
    Livro[] livros = new Livro[0];
    public void Adicionar(Livro novo)
    {
        Livro[] aux = new Livro[livros.Length + 1];
        for (int pos = 0; pos < livros.Length; pos++)
        {
            aux[pos] = livros[pos];
        }
        aux[livros.Length] = novo;

        livros = aux;
    }

    public void Listar()
    {
        Console.WriteLine("\n-- LIVROS REGISTRADOS --");
        int pos = 1;
        foreach (Livro item in livros)
        {
            Console.WriteLine($" {pos++}. {item.Nome} R$ {item.Preco} - {item.Estoque} estoque");
        }
    }

    public void EntradaEstoque(int pos, int qtd)
    {
        Livro livro = livros[pos - 1];
        livro.Estoque += qtd;
        
    }
}