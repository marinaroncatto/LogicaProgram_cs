class Tela
{
       public double PedirNota(string msg)
    {
        Console.WriteLine(msg);
        double nota = Convert.ToDouble(Console.ReadLine());
        return nota;
    }
      public void Exibir(double media, string situacao)
    {
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Situação: {situacao}");
    }
}