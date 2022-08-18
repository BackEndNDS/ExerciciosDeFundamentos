namespace CalculadoraSimples;

public class CalculadoraSimples
{
    //Faça um programa que solicite do usuario dois numeros e qual ação ele deseja executar entre soma, divisão, multiplicação e subtração

    public static void Main(string[] args)
    {
       Tela();
    }

    public static void Tela()
    {
        Console.Clear();
        Console.WriteLine("Informe qual ação você deseja executar: ");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("0- Exit");
        var acao = int.Parse(Console.ReadLine());

        switch (acao)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            default: Tela(); break;
        }
    }

    public static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"A soma de {x} e {y} é {x + y}");
        System.Threading.Thread.Sleep(2000);
        Tela();
    }
    
    public static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"A Subtracao de {x} e {y} é {x - y}");
        System.Threading.Thread.Sleep(2000);
        Tela();
    }
    
    public static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"A soma de {x} e {y} é {x * y}");
        System.Threading.Thread.Sleep(2000);
        Tela();
    }
    
    public static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine($"A subtração de {(float)x} e {y} é {x / y}");
        System.Threading.Thread.Sleep(2000);
        Tela();
    }
}