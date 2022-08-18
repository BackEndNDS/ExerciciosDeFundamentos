namespace MediaPonderada;

public class MediaPonderada
{
    //Crie um programa que receba duas notas e seus respectivos pessos e informe a media ponderada

    public static void Main(string[] args)
    {
        //Recebendo o primeiro nota
        Console.WriteLine("Informe a primeira nota");
        double nota1 = double.Parse(Console.ReadLine());
        
        //Recebendo o peso da primeira nota
        Console.WriteLine("Informe o peso da primeira nota");
        double peso1 = double.Parse(Console.ReadLine());
        
        //Recebendo o peso da segunda nota
        Console.WriteLine("Informe o peso da segunda nota");
        double nota2 = double.Parse(Console.ReadLine());
        
        //Recebendo a segunda nota
        Console.WriteLine("Informe a segunda nota");
        double peso2 = double.Parse(Console.ReadLine());
        
        //Calculando a media ponderada
        double mediaPonderada = (((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2));
        
        //printando o resultado
        Console.WriteLine($"A media ponderada de {nota1} com peso {peso1} e {nota2} com peso {peso2} é {mediaPonderada}");
    }
}