namespace ExerciciosDeFundamentos.RPGStruct;
public class RGPStruct
{
    public static void Main(string[] args)
    {
        Tela();
    }

    public static void Tela()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao RGP");
        Thread.Sleep(2000);
        Console.WriteLine("Informe a classe que você deseja jogar: ");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Arqueiro");
        Console.WriteLine("3 - Assassino");
        Console.WriteLine("4 - Mago");
        Console.WriteLine("0 - Exit");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0: Environment.Exit(0); break;
            case 1: StartWithGuerreiro(); break;
            case 2: StartWithArqueiro(); break;
            case 3: StartWithAssassino(); break;
            case 4: StartWithMago(); break;
            default: Tela(); break;
        }
    }

    public static void StartWithGuerreiro()
    {
        Console.Clear();
        //Instanciando o Heroi
        var Guerreiro = new Heroi("Guerreiro", 1000, 100);
        //Invocando o vilao
        var vilao = InvocarVilao();
        //Inicio do game
        Console.WriteLine("Você escolheu a classe: Guerreiro");
        Console.WriteLine($"Seus atributos: Vida = {Guerreiro.Vida}, PoderDeAtaque = {Guerreiro.PoderDeAtaque}");
        Thread.Sleep(2000);
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
        Thread.Sleep(5000);
        //Inicio da batalha
        Batalha(Guerreiro, vilao);
    }
    public static void StartWithArqueiro()
    {
        Console.Clear();
        //Instanciando o Heroi
        var Arqueiro = new Heroi("Arqueiro", 500, 100);
        //Invocando o vilao
        var vilao = InvocarVilao();
        //Inicio do game
        Console.WriteLine("Você escolheu a classe: Arqueiro");
        Console.WriteLine($"Seus atributos: Vida = {Arqueiro.Vida}, PoderDeAtaque = {Arqueiro.PoderDeAtaque}");
        Thread.Sleep(2000);
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
        Thread.Sleep(5000);
        //Inicio da batalha
        Batalha(Arqueiro, vilao);
    }
    public static void StartWithAssassino()
    {
        Console.Clear();
        //Instanciando o Heroi
        var Assassino = new Heroi("Assassino", 400, 150);
        //Invocando o vilao
        var vilao = InvocarVilao();
        //Inicio do game
        Console.WriteLine("Você escolheu a classe: Assassino");
        Console.WriteLine($"Seus atributos: Vida = {Assassino.Vida}, PoderDeAtaque = {Assassino.PoderDeAtaque}");
        Thread.Sleep(2000);
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
        Thread.Sleep(5000);
        //Inicio da batalha
        Batalha(Assassino, vilao);
    }
    public static void StartWithMago()
    {
        Console.Clear();
        //Instanciando o Heroi
        var Mago = new Heroi("Mago", 350, 200);
        //Invocando o vilao
        var vilao = InvocarVilao();
        //Inicio do game
        Console.WriteLine("Você escolheu a classe: Mago");
        Console.WriteLine($"Seus atributos: Vida = {Mago.Vida}, PoderDeAtaque = {Mago.PoderDeAtaque}");
        Thread.Sleep(2000);
        Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
        Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
        Thread.Sleep(5000);
        //Inicio da batalha
        Batalha(Mago, vilao);
    }
    public static Vilao InvocarVilao()
    {
        var ReiGoblin = new Vilao("Rei goblin", 1000, 10);
        var Slime = new Vilao("Slime", 50, 5);
        var AranhaGigante = new Vilao("Aranha Gigante", 2000, 15);
        var Ladrao = new Vilao("Ladrao", 1500, 12);

        var numAleatorio = new Random();
        int chefeInvocado = numAleatorio.Next(1, 4);

        if (chefeInvocado == 1)
        {
            return ReiGoblin;
        }
        if (chefeInvocado == 2)
        {
            return Slime;
        }
        if (chefeInvocado == 3)
        {
            return AranhaGigante;
        }
        if (chefeInvocado == 4)
        {
            return Ladrao;
        }

        return InvocarVilao();
    }

    public static void Batalha(Heroi heroi, Vilao vilao)
    {
        Console.Clear();
        Console.WriteLine($"Atributos Heroi: Vida = {heroi.Vida}, PodeDeAtaque = {heroi.PoderDeAtaque}");
        Console.WriteLine($"Atributos Vilão: Vida = {vilao.Vida}, PodeDeAtaque = {vilao.PoderDeAtaque}");
        Console.WriteLine();
        Movimento(heroi.PoderDeAtaque, heroi.Vida, vilao.PoderDeAtaque, vilao.Vida);
    }

    public static void Movimento(double heroiPoderDeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
    {
        Console.Clear();
        Console.WriteLine("Faça um movimento:");
        Console.WriteLine("1- Atacar");
        Console.WriteLine("2- Esquivar");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Atacar(heroiPoderDeAtaque,  heroiVida,  vilaoPoderDeAtaque,  vilaoVida); break;
            case 2: Esquivar(heroiPoderDeAtaque,  heroiVida,  vilaoPoderDeAtaque,  vilaoVida); break;
            default: Movimento( heroiPoderDeAtaque,  heroiVida,  vilaoPoderDeAtaque,  vilaoVida); break;
        }
    }

    public static void Atacar(double heroiPoderDeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
    {
        Console.WriteLine("Você atacou!!");
        vilaoVida -= heroiPoderDeAtaque;
        Console.WriteLine($"Atributos Vilão: Vida = {vilaoVida}, PodeDeAtaque = {vilaoPoderDeAtaque}");
        if (vilaoVida <= 0)
        {
            Console.WriteLine("Você conseguiu derrotar o chefe!");
            Thread.Sleep(5000);
            Tela();
        }
        Thread.Sleep(2000);
        
        Console.WriteLine("O vilão atacou!!");
        heroiVida -= vilaoPoderDeAtaque;
        Console.WriteLine($"Seus atributos: Vida = {heroiVida}, PodeDeAtaque = {heroiPoderDeAtaque}");
        if (heroiVida <= 0)
        {
            Console.WriteLine("Você morreu!");
            Thread.Sleep(5000);
            Tela();
        }
        Thread.Sleep(2000);
        Movimento(heroiPoderDeAtaque, heroiVida, vilaoPoderDeAtaque, vilaoVida);
    }

    public static void Esquivar(double heroiPoderDeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
    {
        var numAleatorio = new Random();
        var sorte = numAleatorio.Next(1, 3);

        if (sorte == 1)
        {
            Console.WriteLine("O vilão atacou!!");
            Console.WriteLine("Você consegui esquivar por pouco e causou um pequeno dano no vilão");
            heroiVida -= (vilaoPoderDeAtaque / 2);
            vilaoVida -= (heroiPoderDeAtaque / 5);
            Console.WriteLine($"Seus atributos: Vida = {heroiVida}, PodeDeAtaque = {heroiPoderDeAtaque}");
            Console.WriteLine($"Seus atributos: Vida = {vilaoVida}, PodeDeAtaque = {vilaoPoderDeAtaque}");
            if (vilaoVida <= 0)
            {
                Console.WriteLine("Você conseguiu derrotar o vilão!");
                Thread.Sleep(5000);
                Tela();
            }
            if (heroiVida <= 0)
            {
                Console.WriteLine("Você morreu!");
                Thread.Sleep(5000);
                Tela();
            }
            Thread.Sleep(2000);
            Movimento(heroiPoderDeAtaque, heroiVida, vilaoPoderDeAtaque, vilaoVida);
        }

        if (sorte == 2)
        {
            Console.WriteLine("O vilão atacou!!");
            Console.WriteLine("Você não consegui esquivar");
            heroiVida -= vilaoPoderDeAtaque;
            Console.WriteLine($"Seus atributos: Vida = {heroiVida}, PodeDeAtaque = {heroiPoderDeAtaque}");
            if (heroiVida <= 0)
            {
                Console.WriteLine("Você morreu!");
                Thread.Sleep(5000);
                Tela();
            }
            Thread.Sleep(2000);
            Movimento(heroiPoderDeAtaque, heroiVida, vilaoPoderDeAtaque, vilaoVida);
        }
    }
}

public struct Heroi
{
    public Heroi(string classe, double vida, double poderDeAtaque)
    {
        Classe = classe;
        Vida = vida;
        PoderDeAtaque = poderDeAtaque;
    }

    public string Classe { get; set; }
    public double Vida { get; set; }
    public double PoderDeAtaque { get; set; }
}

public struct Vilao
{
    public Vilao(string nome, double vida, double poderDeAtaque)
    {
        Nome = nome;
        Vida = vida;
        PoderDeAtaque = poderDeAtaque;
    }

    public string Nome { get; set; }
    public double Vida { get; set; }
    public double PoderDeAtaque { get; set; }
}