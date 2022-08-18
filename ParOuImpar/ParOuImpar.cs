namespace ParOuImpar;

public class ParOuImpar
{
    //faça um programa que recea um numero inteiro do usuario e informe se ele é par ou impar

    public static void Main(string[] args)
    {
        //Recebendo um numero do usuario
        Console.WriteLine("Informe um numero inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O numero {num} é par");
        }
        else
        {
            Console.WriteLine($"O numero {num} é impar");
        }
    }
}