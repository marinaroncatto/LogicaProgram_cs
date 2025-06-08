public class Dragao
{
    int mordida;
    int bolaFogo;
    int life;
    int recompensa;

    public Dragao(int m, int b, int l, int r)
    {
        mordida = m;
        bolaFogo = b;
        life = l;
        recompensa = r;
    }

    public void morder()
    {
        Console.WriteLine("Mordida!");
    }

    public void lancarFogo()
    {
        Console.WriteLine("Lançar bola de fogo!");
    }

    public void sofrerDano(int dano)
    {
        life -= dano;
        if (life <= 0)
            Console.WriteLine("Dragão derrotado!");
    }
}