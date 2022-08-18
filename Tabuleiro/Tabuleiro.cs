namespace Tabuleiro;

public class Tabuleiro
{
    //Crie um programa que imprima um tabuleiro nxm onde as paredes do tabuleiro serão representados por # e as casas por " "

    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o numero de linhas do tabuleiro: ");
        int linha = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe o numero de colunas do tabuleiro: ");
        int colunas = int.Parse(Console.ReadLine());
        
        //teto
        Console.Write("#");
        for (int i = 0; i < linha; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");
        
        //Corpo
        for (int i = 0; i < linha; i++)
        {
            Console.Write("#");
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }
        
        //chao
        Console.Write("#");
        for (int i = 0; i < linha; i++)
        {
            Console.Write("#");
        }
        Console.Write("#");
    }
}