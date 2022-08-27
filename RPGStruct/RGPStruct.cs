<<<<<<< Updated upstream
=======
﻿using System.Security.AccessControl;

>>>>>>> Stashed changes
namespace ExerciciosDeFundamentos.RPGStruct;

public class RGPStruct
{
<<<<<<< Updated upstream
    
=======
    public static void Main(string[] args)
    {
        InvocarVilao();
    }

    public static void Tela()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao RGP");
        Thread.Sleep(1000);
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
        var Guerreiro = new Heroi("Guerreiro", 1000, 20);

        Console.Clear();
        
    }

    public static Vilao InvocarVilao()
    {
        var ReiGoblin = new Vilao("Rei goblin", 1000, 10);
        var Slime = new Vilao("Slime", 1000, 10);
        var AranhaGigante = new Vilao("Aranha Gigante", 1000, 10);
        var Ladrao = new Vilao("Ladrao", 1000, 10);

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
    
    public static void StartWithArqueiro()
    {
        
    }
    
    public static void StartWithAssassino()
    {
        
    }
    
    public static void StartWithMago()
    {
        
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
>>>>>>> Stashed changes
}