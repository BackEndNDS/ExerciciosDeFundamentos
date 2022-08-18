namespace MediaAritimeticaDoWhile;

public class MediaAritimeticaDoWhile
{
    //Faça um programa que receba n valores e faça a media aritmetica deles
    public static void Main()
    {
        var total = 0;
        var contador = 0;
        var num = 0;
        do
        {
            Console.WriteLine("Informe um valor (0 para sair): ");
            num = int.Parse(Console.ReadLine());
            
            if (num == 0)
            {
                Console.WriteLine($"A media dos valores é {total/contador}");
            }
            
            total += num;
            contador++;

        } while (num != 0);
    }
}