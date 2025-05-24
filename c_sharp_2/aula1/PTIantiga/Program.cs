namespace PTIantiga;

class Program
{
    static void Main(string[] args)
    {
        Tela tela = new Tela();
        GerenciarEstoque ger = new GerenciarEstoque();

        int menu = tela.ExibirMenu();

        while (menu != 0)
        {
            switch (menu)
            {
                case 1:
                    Livro novo = new Livro();
                    novo.Nome = tela.PedirTexto("\nInforme o nome:");
                    novo.Autor = tela.PedirTexto("\nInforme o autor:");
                    novo.Preco = tela.PedirDouble("\nInforme o preço:");

                    ger.Adicionar(novo);
                    Console.WriteLine("Livro adicionado");
                    break;
                case 2:
                    ger.Listar();
                    break;
                case 3:
                    //Remover
                    break;
                case 4:
                    int pos = tela.PedirInt("\nInforme o núm. do livro");
                    int qtd = tela.PedirInt("\nInforme a qtd de livros");

                    ger.EntradaEstoque(pos, qtd);
                    break;
                case 5:
                    //Saída
                    break;
            }

            menu = tela.ExibirMenu();            
        }

    }
}
