namespace MaiorEMeorNumero;

public class MaiorEMeorNumero
{
    //Faça um programa que receba 3 numeros e informe dentre eles qual é o maior e o menor valor
    public static void Main(string[] args)
    {
        //Recebendo o primeiro valor
        Console.WriteLine("Informe o primeiro numero");
        double num1 = double.Parse(Console.ReadLine());
        
        //Recebendo o segundo valor
        Console.WriteLine("Informe o segundo numero");
        double num2 = double.Parse(Console.ReadLine());
        
        //Recebendo o terceiro valor
        Console.WriteLine("Informe o primeiro numero");
        double num3 = double.Parse(Console.ReadLine());
        
        //definindo o maior valor
        double maiorValor = 0;

        if (num1 > num2 && num1 > num3)
        {
            maiorValor = num1;
        } else if (num2 > num1 && num2 > num3)
        {
            maiorValor = num2;
        }
        else
        {
            maiorValor = num3;
        }
        
        //definindo o menor valor
        double menorValor = 0;

        if (num1 < num2 && num1 < num3)
        {
            menorValor = num1;
        } else if (num2 < num1 && num2 < num3)
        {
            menorValor = num2;
        }
        else
        {
            menorValor = num3;
        }
        
        //printando o maior valor
        Console.WriteLine($"O maior valor entre {num1}, {num2} e {num3} é {maiorValor}");
        Console.WriteLine($"O menor valor entre {num1}, {num2} e {num3} é {menorValor}");
    }
}