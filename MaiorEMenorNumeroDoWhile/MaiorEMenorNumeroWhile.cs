namespace MaiorEMenorNumeroDoWhile;

public class MaiorEMenorNumeroDoWhile
{
    //Faça um programa que receba n numeros do usuário e informe qual é o maior e o menor valor entre eles

    public static void Main(string[] args)
    {
        int num = 0;
        var maiorNumero = 0;
        var menorNumero = 10000;
        
        do
        {
            Console.WriteLine("Informe um numero (ou 0 para sair): ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine($"O maior numero é {maiorNumero}");
                Console.WriteLine($"O menor numero é {menorNumero}");
            } else if (num > maiorNumero)
            {
                maiorNumero = num;
            } else if (num < menorNumero)
            {
                menorNumero = num;
            }
        } while (num != 0);
    }
}