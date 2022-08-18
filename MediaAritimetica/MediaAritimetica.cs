namespace MediaAritimetica;

public class MediaAritimetica
{
    //Crie um programa que receba dois valores inteiros e faça a media aritimetica deles

    public static void Main(string[] args)
    {
        //Recebendo a primeira nota
        Console.WriteLine("Informe a primeira nota: ");
        int nota1 = int.Parse(Console.ReadLine());
        
        //Recebendo a segunda nota
        Console.WriteLine("Informe a segunda nota");
        int nota2 = int.Parse(Console.ReadLine());
        
        //Media
        float media = ((float)nota1 + nota2) / 2;
        
        //Imprimindo a media
        Console.WriteLine($"A média de {nota1} e {nota2} é {media}");
    }
}