namespace ExRPG;

class Program
{
    static void Main(string[] args)
    {
        //Criação dos objetos
        Heroi cavaleiro = new Heroi(80, 100, 0, 1);
        Heroi mago = new Heroi(60, 100, 0, 2);
        Dragao dragaoVermelho = new Dragao(70, 110, 100, 30);

        //Cavaleiro ataca dragão
        cavaleiro.atacar();
        //dragão sofre dano do cav.
        dragaoVermelho.sofrerDano(80);
        //dragão ataca cav
        dragaoVermelho.lancarFogo();
        //cav sofre dano do dragao (morre)
        cavaleiro.sofrerDano(110);
        //mago ataca dragão
        mago.atacar();
        //Dragão sofre dano do mago(morre)
        dragaoVermelho.sofrerDano(60);
    }
}
