class Boletim
{

    //variáveis de entrada e saída
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    //variáveis de saída
    public double Media { get; private set; }
    public String Situacao { get; private set; }


    public void CalcularBoletim()
    {
        this.Media = CalcularMedia();
        this.Situacao = VerificarSituacao();
    }

    private double CalcularMedia()
    {
        double media = (this.Nota1 + this.Nota2 + this.Nota3) / 3.0;        
        return media;
        
    }

    private string VerificarSituacao()
    {

        String situacao = " ";

        if (this.Media >= 6)
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