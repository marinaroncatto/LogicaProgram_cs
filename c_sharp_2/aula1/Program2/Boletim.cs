class Boletim
{
    public double PedirNota(string msg)
    {
        Console.WriteLine(msg);
        double nota = Convert.ToDouble(Console.ReadLine());
        return nota;
    }

    public double CalcularMedia(double n1, double n2, double n3)
    {
        double media = (n1 + n2 + n3) / 3.0;
        return media;
    }

    public string VerificarSituacao(double media)
    {

        String situacao = " ";

        if (media >= 6)
        {
            situacao = "Aprovado";
        }
        else
        {
            situacao = "Reprovado";
        }

        return situacao;
    }

    public void Exibir(double media, string situacao)
    {
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Situação: {situacao}");
    }
}