namespace ExerciciosDeFundamentos.ExerciciosDeFundamentos;

public class MediaAritimetica
{
    //Crie um programa que receba dois valores e faça a media aritimetica deles

    public void Main(string[] args)
    {
        //Recebendo a primeira nota
        Console.WriteLine("Informe a primeira nota: ");
        int nota1 = int.Parse(Console.ReadLine());
        
        //Recebendo a segunda nota
        Console.WriteLine("Informe a segunda nota");
        int nota2 = int.Parse(Console.ReadLine());
        
        //Media
        float media = (nota1 + nota2) / 2;
        
        //Imprimindo a media
        Console.WriteLine($"A média de {nota1} e {nota2} é {media}");
    }
}