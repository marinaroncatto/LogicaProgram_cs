public class Heroi
{
    int forca;
    int life;
    int moedas;
    int tipo; //1 para cavaleiro; 2 para mago

    public Heroi(int f, int l, int m, int t)
    {
        forca = f;
        life = l;
        moedas = m;
        tipo = t;
    }

    public void atacar()
    {
        if (tipo == 1)
            Console.WriteLine("Ataque com espada!");
        else
            Console.WriteLine("Ataque com magia!");
    }

    public void sofrerDano(int dano)
    {
        life -= dano;
        if (life <= 0)
            Console.WriteLine("Herói morreu!");
    }
}