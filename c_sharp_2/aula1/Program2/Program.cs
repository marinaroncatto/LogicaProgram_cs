namespace Program2;

class Program
{
    static void Main(string[] args)
    {
        //média de 3 notas

        //1 - coleta de dados

        Boletim boletim = new Boletim();
        Tela tela = new Tela();
        NotasAluno notas = new NotasAluno();

        Console.WriteLine("--PROGRAMA DE MÉDIA --");
       notas.Nota1 = tela.PedirNota("Informe a nota 01");
       notas.Nota2 = tela.PedirNota("Informe a nota 02");
       notas.Nota3 = tela.PedirNota("Informe a nota 03");           

        //2 - Resolução do problema

        double media = boletim.CalcularMedia(notas);
        String situacao = boletim.VerificarSituacao(media);
        
        //3 - apresentação do resultado

        tela.Exibir(media, situacao);

    }

}


