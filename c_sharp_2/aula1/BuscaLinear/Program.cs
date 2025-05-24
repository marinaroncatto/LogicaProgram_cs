namespace BuscaLinear;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Método de Busca Linear");

        public int buscar(int[] elementos, int valor)
    {
        for (int i = 0; i < elementos.Length; i++)
        {
            if (elementos[i] == valor)
                return i;
        }
    }
        return -1;
    }
}
