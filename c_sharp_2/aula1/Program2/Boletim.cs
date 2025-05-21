class Boletim
{
     public double CalcularMedia(NotasAluno notas)
    {
        double media = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3.0;
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

  
}